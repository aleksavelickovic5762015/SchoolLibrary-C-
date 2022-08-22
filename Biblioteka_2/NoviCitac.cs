using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_2
{
    public partial class NoviCitac : Form
    {
        readonly string queryCitaci = @"SELECT citac_id, citac_ime, citac_pol, citac_tel, citac_mejl, ck.tip AS tip
                                        FROM citac AS c INNER JOIN citacKategorija AS ck
                                                            ON c.kategorija_id = ck.kategorija_id";
        readonly string queryCitaciUnesi = @"INSERT INTO citac
                                                (citac_ime, citac_pol, citac_tel, citac_mejl, kategorija_id)
                                             VALUES
                                                (@citac_ime, @citac_pol, @citac_tel, @citac_mejl, @kategorija_id)";
        readonly string queryCitaciBrisi = @"DELETE
                                             FROM citac
                                             WHERE citac_id = @citac_id";
        /////////
        readonly string queryCitacKategorije = @"SELECT *
                                                 FROM citacKategorija";
        /////////////////////

        DataTable DT_citaci, DT_citacKategorije;

        public NoviCitac()
        {
            InitializeComponent();
        }

        private void RefreshData_NoviCitac()
        {
            DT_citaci = Utils.Forms.RefreshDataGridView(dGV_Citaci, queryCitaci);
            DT_citacKategorije = Utils.Forms.RefreshDataGridView(dGV_CitacKategorije, queryCitacKategorije);

            dGV_DeselectFirstRow();

            /////Polovi ComboBox
            Dictionary<string, string> dict_polovi = new Dictionary<string, string>();
            dict_polovi.Add("М", "М");
            dict_polovi.Add("Ж", "Ж");
            cB_CitacPol.DataSource = new BindingSource(dict_polovi, null);
            cB_CitacPol.DisplayMember = "Value";
            cB_CitacPol.ValueMember = "Key";
            /////
            /////Unos citaca textboxovi
            tB_CitacIme.Clear();
            tB_CitacTel.Clear();
            tB_CitacMejl.Clear();
        }

        private void NoviCitac_Load(object sender, EventArgs e)
        {
            Utils.Forms.ConfigureForm(this);
            Utils.Forms.ConfigureDataGridView(dGV_Citaci, false);
            Utils.Forms.ConfigureDataGridView(dGV_CitacKategorije, false);

            RefreshData_NoviCitac();
        }

        private void btnCitaciUpisi_Click(object sender, EventArgs e)
        {
            bool tB_CitacIme_uneto = !String.IsNullOrEmpty(tB_CitacIme.Text);
            bool tB_CitacTel_uneto = !String.IsNullOrEmpty(tB_CitacTel.Text);
            bool tB_CitacMejl_uneto = !String.IsNullOrEmpty(tB_CitacMejl.Text);

            if (dGV_CitacKategorije.CurrentRow != null && DT_citacKategorije != null)
            {
                if (tB_CitacIme_uneto && tB_CitacTel_uneto && tB_CitacMejl_uneto)
                {
                    Utils.DB.ExecuteNonQuery(queryCitaciUnesi,
                    new Dictionary<string, object>
                    {
                        ["@citac_ime"] = tB_CitacIme.Text,
                        ["@citac_pol"] = cB_CitacPol.SelectedValue.ToString(),
                        ["@citac_tel"] = tB_CitacTel.Text,
                        ["@citac_mejl"] = tB_CitacMejl.Text,
                        ["@kategorija_id"] = (int)(long)dGV_CitacKategorije.CurrentRow.Cells["kategorija_id"].Value
                    });

                    RefreshData_NoviCitac();
                }
                else
                {
                    MessageBox.Show("Потребно је попунити сва поља!");
                }
            }
            else
            {
                MessageBox.Show("Потребно је обележити категорију у табели!");
            }

        }

        private void btnCitaciBrisi_Click(object sender, EventArgs e)
        {
            if (dGV_Citaci.CurrentRow != null && DT_citaci != null)
            {
                Utils.DB.ExecuteNonQuery(queryCitaciBrisi,
                    new Dictionary<string, object>
                    {
                        ["@citac_id"] = (int)(long)dGV_Citaci.CurrentRow.Cells["citac_id"].Value
                    });
            }
            else
            {
                MessageBox.Show("Није обележен ниједан читач!");
            }

            RefreshData_NoviCitac();
        }

        private void btnCitaciPretraga_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> recnikCitaciPretraga = new Dictionary<string, object>();
            string queryCitaciPretraga = queryCitaci;
            bool tB_CitacIme_uneto = !String.IsNullOrEmpty(tB_CitacIme.Text);

            if (tB_CitacIme_uneto)
            {
                recnikCitaciPretraga.Add("@citac_ime", tB_CitacIme.Text);
                queryCitaciPretraga += @" WHERE citac_ime = @citac_ime";
            }

            if (tB_CitacIme_uneto)
            {
                DT_citaci = Utils.Forms.RefreshDataGridView(dGV_Citaci, queryCitaciPretraga, recnikCitaciPretraga);
                dGV_DeselectFirstRow();
            }
            else
            {
                RefreshData_NoviCitac();
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Utils.Forms.ReplaceForm(this, new Prijava(), true);
        }

        private void btnForm_GlavniMeni_Click(object sender, EventArgs e)
        {
            Utils.Forms.ReplaceForm(this, new GlavniMeni(), true);
        }

        private void dGV_DeselectFirstRow()
        {
            ///da bi se videla boja svih redova..            
            dGV_Citaci.ClearSelection();
            dGV_CitacKategorije.ClearSelection();
            ///deselect the first row
            dGV_Citaci.CurrentCell = null;
            dGV_CitacKategorije.CurrentCell = null;
        }
    }
}

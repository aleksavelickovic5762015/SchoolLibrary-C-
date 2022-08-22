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
    public partial class NovaKnjiga : Form
    {
        /////////////////////
        readonly string queryKnjige = @"SELECT *
                                        FROM knjiga";
        readonly string queryKnjigeUnesi = @"INSERT INTO knjiga
                                                (naziv, godina, zanr)
                                             VALUES
                                                (@naziv, @godina, @zanr)";
        readonly string queryKnjige_MaxID = @"SELECT MAX(knjiga_id)
                                              FROM knjiga";
        readonly string queryKnjigeBrisi = @"DELETE
                                             FROM knjiga
                                             WHERE knjiga_id = @knjiga_id";
        /*readonly string queryKnjigeBrisi_Autori = @"DELETE k
                                                    FROM knjiga AS k INNER JOIN napisao AS n
                                                                  ON k.knjiga_id=n.knjiga_id
                                                    WHERE n.autor_id = @autor_id";*/
        readonly string queryKnjigeBrisi_Autori = @"DELETE
                                                    FROM knjiga
                                                    WHERE knjiga_id IN (SELECT knjiga_id
                                                                        FROM napisao
                                                                        WHERE autor_id = @autor_id)";
        /////////
        readonly string queryAutori = @"SELECT *
                                        FROM autor";
        readonly string queryAutoriUnesi = @"INSERT INTO autor
                                                (autor_ime, autor_pol)
                                             VALUES
                                                (@autor_ime, @autor_pol)";
        readonly string queryAutoriBrisi = @"DELETE
                                             FROM autor
                                             WHERE autor_id = @autor_id";
        /////////
        readonly string queryNapisaoUnesi = @"INSERT INTO napisao
                                                (knjiga_id, autor_id)
                                             VALUES
                                                (@knjiga_id, @autor_id)";
        /////////////////////
        
        DataTable DT_knjige, DT_autori;

        public NovaKnjiga()
        {
            InitializeComponent();
        }

        private void RefreshData_NovaKnjiga()
        {
            DT_knjige = Utils.Forms.RefreshDataGridView(dGV_Knjige, queryKnjige);
            DT_autori = Utils.Forms.RefreshDataGridView(dGV_Autori, queryAutori);

            dGV_DeselectFirstRow();

            /////Polovi ComboBox
            Dictionary<string, string> dict_polovi = new Dictionary<string,string>();
            dict_polovi.Add("М", "М");
            dict_polovi.Add("Ж", "Ж");
            cB_AutorPol.DataSource = new BindingSource(dict_polovi, null);
            cB_AutorPol.DisplayMember = "Value";
            cB_AutorPol.ValueMember = "Key";
            /////

            /////Unos knjige textboxovi
            tB_Naziv.Clear();
            tB_Godina.Clear();
            tB_Zanr.Clear();
            /////Unos autora textboxovi
            tB_AutorIme.Clear();

        }
        private void NovaKnjiga_Load(object sender, EventArgs e)
        {
            Utils.Forms.ConfigureForm(this);
            Utils.Forms.ConfigureDataGridView(dGV_Knjige, false);
            Utils.Forms.ConfigureDataGridView(dGV_Autori, false);

            RefreshData_NovaKnjiga();
        }

        private void btnKnjigeUnesi_Click(object sender, EventArgs e)
        {
            bool tB_Naziv_uneto = !String.IsNullOrEmpty(tB_Naziv.Text);
            bool tB_Godina_uneto = !String.IsNullOrEmpty(tB_Godina.Text);
            bool tB_Zanr_uneto = !String.IsNullOrEmpty(tB_Zanr.Text);

            int n;
            int Knjige_MaxID;

            if (dGV_Autori.CurrentRow != null && DT_autori != null)
            {
                if (tB_Naziv_uneto && tB_Godina_uneto && tB_Zanr_uneto)
                {
                    if (int.TryParse(tB_Godina.Text, out n))
                    {
                        Utils.DB.ExecuteNonQuery(queryKnjigeUnesi,
                        new Dictionary<string, object>
                        {
                            ["@naziv"] = tB_Naziv.Text,
                            ["@godina"] = Convert.ToInt32(tB_Godina.Text),
                            ["@zanr"] = tB_Zanr.Text
                        });
                        ////////////////////////////////////////Prvo vraca indeks unete knjige onda unosi u tabelu NAPISAO sa autorom
                        Knjige_MaxID = Convert.ToInt32(Utils.DB.SelectSingleValueFromQuery(queryKnjige_MaxID));

                        Utils.DB.ExecuteNonQuery(queryNapisaoUnesi,
                        new Dictionary<string, object>
                        {
                            ["@knjiga_id"] = Knjige_MaxID,
                            ["@autor_id"] = (int)(long)dGV_Autori.CurrentRow.Cells["autor_id"].Value
                        });
                        ////////////////////////////////////////
                        RefreshData_NovaKnjiga();
                    }
                    else
                    {
                        MessageBox.Show("Година треба да буде цео број!");
                    }
                }
                else
                {
                    MessageBox.Show("Потребно је попунити сва поља!");
                }
            }
            else
            {
                MessageBox.Show("Потребно је обележити аутора у табели!");
            }
        }

        private void btnAutoriUnesi_Click(object sender, EventArgs e)
        {
            bool tB_AutorIme_uneto = !String.IsNullOrEmpty(tB_AutorIme.Text);

            if (tB_AutorIme_uneto)
            {
                Utils.DB.ExecuteNonQuery(queryAutoriUnesi,
                new Dictionary<string, object>
                {
                    ["@autor_ime"] = tB_AutorIme.Text,
                    ["@autor_pol"] = cB_AutorPol.SelectedValue.ToString()
                });

                RefreshData_NovaKnjiga();
            }
            else
            {
                MessageBox.Show("Потребно је унети име аутора!");
            }
        }

        private void btnAutoriPretraga_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> recnikAutoriPretraga = new Dictionary<string, object>();
            string queryAutoriPretraga = queryAutori;
            bool tB_AutorIme_uneto = !String.IsNullOrEmpty(tB_AutorIme.Text);

            if (tB_AutorIme_uneto)
            {
                recnikAutoriPretraga.Add("@autor_ime", tB_AutorIme.Text);
                queryAutoriPretraga += @" WHERE autor_ime = @autor_ime";
            }

            if (tB_AutorIme_uneto)
            {
                DT_autori = Utils.Forms.RefreshDataGridView(dGV_Autori, queryAutoriPretraga, recnikAutoriPretraga);
                dGV_DeselectFirstRow();
            }
            else
            {
                RefreshData_NovaKnjiga();
            }
        }

        private void btnKnjigeBrisi_Click(object sender, EventArgs e)
        {
            if (dGV_Knjige.CurrentRow != null && DT_knjige != null)
            {
                Utils.DB.ExecuteNonQuery(queryKnjigeBrisi,
                    new Dictionary<string, object>
                    {
                        ["@knjiga_id"] = (int)(long)dGV_Knjige.CurrentRow.Cells["knjiga_id"].Value
                    });
            }
            else
            {
                MessageBox.Show("Није обележенa ниједна књига!");
            }

            RefreshData_NovaKnjiga();

        }

        private void btnAutoriBrisi_Click(object sender, EventArgs e)
        {
            if (dGV_Autori.CurrentRow != null && DT_autori != null)
            {
                Utils.DB.ExecuteNonQuery(queryKnjigeBrisi_Autori,
                    new Dictionary<string, object>
                    {
                        ["@autor_id"] = (int)(long)dGV_Autori.CurrentRow.Cells["autor_id"].Value
                    });
                Utils.DB.ExecuteNonQuery(queryAutoriBrisi,
                    new Dictionary<string, object>
                    {
                        ["@autor_id"] = (int)(long)dGV_Autori.CurrentRow.Cells["autor_id"].Value
                    });
            }
            else
            {
                MessageBox.Show("Није обележен ниједан аутор!");
            }

            RefreshData_NovaKnjiga();
        }

        private void dGV_Knjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dGV_Autori.ClearSelection();
            dGV_Knjige.ClearSelection();
            ///deselect the first row
            dGV_Autori.CurrentCell = null;
            dGV_Knjige.CurrentCell = null;
        }
    }
}

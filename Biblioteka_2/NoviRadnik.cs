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
    public partial class NoviRadnik : Form
    {
        readonly string queryRadnici = @"SELECT *
                                        FROM radnik";
        readonly string queryRadniciUnesi = @"INSERT INTO radnik
                                                 (radnik_ime, sifra, radnik_tel)
                                              VALUES
                                                 (@radnik_ime, @sifra, @radnik_tel)";
        readonly string queryRadniciBrisi = @"DELETE
                                              FROM radnik
                                              WHERE radnik_id = @radnik_id";

        readonly string queryRadnikID_Admin = @"SELECT r.radnik_id AS radnik_id
                                                FROM radnik AS r INNER JOIN admin AS a
                                                                    ON r.radnik_id = a.radnik_id";
        ///////////

        DataTable DT_radnici;
        int RadnikID_admin;

        ////////////////////////////////

        public NoviRadnik()
        {
            InitializeComponent();
        }

        private void RefreshData_NoviRadnik()
        {
            DT_radnici = Utils.Forms.RefreshDataGridView(dGV_Radnici, queryRadnici);

            dGV_RadniciOboji_DeselectFirstRow();

            /////Unos citaca textboxovi
            tB_RadnikIme.Clear();
            tB_Sifra.Clear();
            tB_RadnikTel.Clear();
        }

        private void NoviRadnik_Load(object sender, EventArgs e)
        {
            Utils.Forms.ConfigureForm(this);
            Utils.Forms.ConfigureDataGridView(dGV_Radnici, false);

            RefreshData_NoviRadnik();
        }

        private void dGV_RadniciOboji_DeselectFirstRow()
        {
            foreach (DataGridViewRow row in dGV_Radnici.Rows)
            {
                RadnikID_admin = Convert.ToInt32(Utils.DB.SelectSingleValueFromQuery(queryRadnikID_Admin));

                if (RadnikID_admin == Convert.ToInt32(row.Cells["radnik_id"].Value.ToString())) //row.Cells["datum"].Value.ToString() == "14-Apr-20 04:16:18"
                {
                    row.DefaultCellStyle.BackColor = Color.Cyan;
                }
            }

            dGV_Radnici.ClearSelection();
            ///deselect the first row
            dGV_Radnici.CurrentCell = null;
        }

        private void btnRadniciUnesi_Click(object sender, EventArgs e)
        {
            bool tB_RadnikIme_uneto = !String.IsNullOrEmpty(tB_RadnikIme.Text);
            bool tB_Sifra_uneto = !String.IsNullOrEmpty(tB_Sifra.Text);
            bool tB_RadnikTel_uneto = !String.IsNullOrEmpty(tB_RadnikTel.Text);

            if (tB_RadnikIme_uneto && tB_Sifra_uneto && tB_RadnikTel_uneto)
            {
                Utils.DB.ExecuteNonQuery(queryRadniciUnesi,
                new Dictionary<string, object>
                {
                    ["@radnik_ime"] = tB_RadnikIme.Text,
                    ["@sifra"] = tB_Sifra.Text,
                    ["@radnik_tel"] = tB_RadnikTel.Text
                });

                RefreshData_NoviRadnik();
            }
            else
            {
                MessageBox.Show("Потребно је попунити сва поља!");
            }

            //["@kategorija_id"] = (int)(long)dGV_CitacKategorije.CurrentRow.Cells["kategorija_id"].Value
        }

        private void btnRadniciBrisi_Click(object sender, EventArgs e)
        {
            if (dGV_Radnici.CurrentRow != null && DT_radnici != null)
            {
                if (RadnikID_admin != (int)(long)dGV_Radnici.CurrentRow.Cells["radnik_id"].Value)
                {
                    Utils.DB.ExecuteNonQuery(queryRadniciBrisi,
                        new Dictionary<string, object>
                        {
                            ["@radnik_id"] = (int)(long)dGV_Radnici.CurrentRow.Cells["radnik_id"].Value
                        });
                }
                else
                {
                    MessageBox.Show("Није могуће обрисати администратора!");
                }
            }
            else
            {
                MessageBox.Show("Није обележен ниједан радник!");
            }

            RefreshData_NoviRadnik();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Utils.Forms.ReplaceForm(this, new Prijava(), true);
        }

        private void btnForm_GlavniMeni_Click(object sender, EventArgs e)
        {
            Utils.Forms.ReplaceForm(this, new GlavniMeni(), true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Data.SQLite;

namespace Biblioteka_2
{
    public partial class Prijava : Form
    {
        string queryRadnici = @"SELECT *
                                FROM radnik
                                WHERE radnik_ime=@radnik_ime AND sifra=@sifra";
        string queryID_Radnici = @"SELECT radnik_id
                                   FROM radnik
                                   WHERE radnik_ime=@radnik_ime AND sifra=@sifra";

        readonly string queryID_Admin = @"SELECT COUNT(*)
                                          FROM radnik AS r INNER JOIN admin AS a
                                                              ON r.radnik_id = a.radnik_id
                                          WHERE r.radnik_id = @radnik_id";

        DataTable radnici;
        int ID_radnik;
        int ID_admin;
        ////////////
        public Prijava()
        {
            InitializeComponent();
            this.AcceptButton = btnPrijavа;
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Prijavа_Click(object sender, EventArgs e)
        {
            /*radnici = Utils.DB.DataTableFromQuery(queryRadnici,
                new Dictionary<string, object>
                {
                    ["@radnik_ime"] = tB_ImeRadnika.Text,
                    ["@sifra"] = tB_Sifra.Text
                });
            */

            ID_radnik = Convert.ToInt32(Utils.DB.SelectSingleValueFromQuery(queryID_Radnici,
                                new Dictionary<string, object>
                                {
                                    ["@radnik_ime"] = tB_ImeRadnika.Text,
                                    ["@sifra"] = tB_Sifra.Text
                                })); 

            if (ID_radnik != 0)     //true //radnici.Rows.Count > 0 //TACNI PODACI
            {
                ID_admin = Convert.ToInt32(Utils.DB.SelectSingleValueFromQuery(queryID_Admin,
                                            new Dictionary<string, object>
                                            {
                                                ["@radnik_id"] = ID_radnik
                                            }));
                if (ID_admin > 0) //ADMIN
                {
                    Utils.Forms.ReplaceForm(this, new NoviRadnik(), true);
                }
                else  //RADNIK
                {
                    Utils.Forms.ReplaceForm(this, new GlavniMeni(), true);
                }
            }
            else
            {
                MessageBox.Show("Погрешан унос!");
            }

        }
    }
}

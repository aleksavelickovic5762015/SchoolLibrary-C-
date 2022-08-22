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
    public partial class GlavniMeni : Form
    {
        /*readonly string queryPozajmljene = @"SELECT k.kniga_id AS kniga_id
                                             FROM knjiga AS k, pozajmljivanje AS p
                                             WHERE k.knjiga_id=p.knjiga_id";
        */
        readonly string queryPozajmljene = @"SELECT pozajmljivanje_id, k.knjiga_id AS knjiga_id, naziv, c.citac_id AS citac_id, citac_ime, datum
                                             FROM knjiga AS k INNER JOIN pozajmljivanje AS p
                                                         ON k.knjiga_id = p.knjiga_id,
                                                  citac AS c
                                             WHERE p.citac_id = c.citac_id";
        readonly string queryPozajmljeneBrisi = @"DELETE
                                                  FROM pozajmljivanje
                                                  WHERE pozajmljivanje_id = @pozajmljivanje_id";
        readonly string queryPozajmljeneUnesi = @"INSERT INTO pozajmljivanje
                                                    (citac_id, knjiga_id, datum)
                                                  VALUES
                                                    (@citac_id, @knjiga_id, @datum)";
        readonly string queryPozajmljeneBroj = @"SELECT COUNT(*)
                                                 FROM pozajmljivanje
                                                 WHERE citac_id=@citac_id";

        /*readonly string queryDostupne = @"SELECT k.knjiga_id, naziv, godina, zanr
                                          FROM knjiga AS k LEFT JOIN pozajmljivanje AS p
                                                         ON k.knjiga_id = p.knjiga_id
                                          WHERE p.knjiga_id IS NULL";*/
        string queryDostupne = @"SELECT k.knjiga_id, naziv, godina, zanr, autor_ime
                                          FROM knjiga AS k LEFT JOIN pozajmljivanje AS p
                                                         ON k.knjiga_id = p.knjiga_id,
                                               napisao AS n, autor AS a
                                          WHERE p.knjiga_id IS NULL AND
                                                k.knjiga_id = n.knjiga_id AND n.autor_id = a.autor_id";
        readonly string queryAutori = @"SELECT *
                                        FROM autor";
        readonly string queryZanrovi = @"SELECT DISTINCT zanr
                                        FROM knjiga";
        readonly string queryCitaci = @"SELECT *
                                        FROM citac";
        readonly string queryCitaciBroj = @"SELECT broj_knjiga
                                            FROM citac AS c INNER JOIN citacKategorija AS cK
                                                            ON c.kategorija_id = cK.kategorija_id
                                            WHERE c.citac_id = @citac_id";
        readonly string queryCitaciDani = @"SELECT dani_ogranicenje
                                            FROM citac AS c INNER JOIN citacKategorija AS cK
                                                            ON c.kategorija_id = cK.kategorija_id
                                            WHERE c.citac_id = @citac_id";

        readonly string queryKnjige = @"SELECT *
                                        FROM knjiga";
        readonly string queryDostupneAutora = @"SELECT k.knjiga_id, naziv, godina, zanr, autor_ime
                                                FROM knjiga AS k LEFT JOIN pozajmljivanje AS p
                                                                ON k.knjiga_id = p.knjiga_id,
                                                    napisao AS n, autor AS a
                                                WHERE p.knjiga_id IS NULL AND
                                                    k.knjiga_id = n.knjiga_id AND n.autor_id = a.autor_id AND
                                                    a.autor_id = @autor_id";
        DataTable DT_pozajmljene, DT_dostupne;

        public GlavniMeni()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            DT_pozajmljene = Utils.Forms.RefreshDataGridView(dGV_Pozajmljene, queryPozajmljene);
            DT_dostupne = Utils.Forms.RefreshDataGridView(dGV_Dostupne, queryDostupne);

            dGV_PozajmljeneOboji_DeselectFirstRow();

            /////Autori ComboBox
            DataTable dt_autori = Utils.DB.DataTableFromQuery(queryAutori);
            ////
            DataRow dr_autori = dt_autori.NewRow();
            dr_autori[0] = 0;
            dr_autori[1] = "/";
            dr_autori[2] = "";
            int yourPosition = 0;
            dt_autori.Rows.InsertAt(dr_autori, yourPosition);
            ////
            cB_Autori.ValueMember = "autor_id";
            cB_Autori.DisplayMember = "autor_ime";
            cB_Autori.DataSource = dt_autori;
            /////
            ////////Zanr ComboBox
            DataTable dt_zanrovi = Utils.DB.DataTableFromQuery(queryZanrovi);
            ////
            DataRow dr_zanrovi = dt_zanrovi.NewRow();
            dr_zanrovi[0] = "/";
            //int yourPosition = 0;
            dt_zanrovi.Rows.InsertAt(dr_zanrovi, yourPosition);
            ////
            cB_Zanrovi.ValueMember = "zanr";
            cB_Zanrovi.DisplayMember = "zanr";
            cB_Zanrovi.DataSource = dt_zanrovi;
            /////
            /////Citaci ComboBox
            DataTable dt_citaci = Utils.DB.DataTableFromQuery(queryCitaci);
            ////
            DataRow dr_citaci = dt_citaci.NewRow();
            dr_citaci[0] = 0;
            dr_citaci[1] = "/";
            dr_citaci[2] = "";
            //int yourPosition = 0;
            dt_citaci.Rows.InsertAt(dr_citaci, yourPosition);
            ////
            cB_Citaci.ValueMember = "citac_id";
            cB_Citaci.DisplayMember = "citac_ime";
            cB_Citaci.DataSource = dt_citaci;
            /////
            /////Knjige ComboBox
            DataTable dt_knjige = Utils.DB.DataTableFromQuery(queryKnjige);
            ////
            DataRow dr_knjige = dt_knjige.NewRow();
            dr_knjige[0] = 0;
            dr_knjige[1] = "/";
            dr_knjige[2] = 0;
            dr_knjige[3] = "/";
            //int yourPosition = 0;
            dt_knjige.Rows.InsertAt(dr_knjige, yourPosition);
            ////
            cB_Knjige.ValueMember = "knjiga_id";
            cB_Knjige.DisplayMember = "knjiga_id"; // ili naziv?
            cB_Knjige.DataSource = dt_knjige;
            /////

            /////Naziv TextBox
            tB_Naziv.Clear();
            //tB_Naziv.Text = DateTime.Now.ToString();
            //2020 - 04 - 14 01:51:17
            //tB_Naziv.Text = (DateTime.Now - Convert.ToDateTime("2020 - 03 - 14 01:51:17")).TotalDays.ToString();
            ////
        }
        /*
        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            Utils.Forms.ConfigureForm(this);
            Utils.Forms.ConfigureDataGridView(dGV_Pozajmljene, false);
            Utils.Forms.ConfigureDataGridView(dGV_Dostupne, false);

            RefreshData();
        }
        */
        private void btnDostupnePretraga_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> recnikDostupnePretraga = new Dictionary<string, object>();
            string queryDostupnePretraga = queryDostupne;
            bool cB_Autori_uneto = Convert.ToInt32(cB_Autori.SelectedValue.ToString()) != 0;
            bool cB_Zanrovi_uneto = cB_Zanrovi.SelectedValue.ToString() != "/";
            bool tB_Naziv_uneto = !String.IsNullOrEmpty(tB_Naziv.Text);

            if (cB_Autori_uneto) //Convert.ToInt32(cB_Autori.SelectedValue.ToString()) != 0
            {
                recnikDostupnePretraga.Add("@autor_id", Convert.ToInt32(cB_Autori.SelectedValue.ToString()));
                queryDostupnePretraga += @" AND a.autor_id = @autor_id";
            }
            if(cB_Zanrovi_uneto) //cB_Zanrovi.SelectedValue.ToString() != "/"
            {
                recnikDostupnePretraga.Add("@zanr", cB_Zanrovi.SelectedValue.ToString());
                queryDostupnePretraga += @" AND zanr = @zanr";
            }
            if (tB_Naziv_uneto) //!String.IsNullOrEmpty(tB_Naziv.Text)
            {
                recnikDostupnePretraga.Add("@naziv", tB_Naziv.Text);
                queryDostupnePretraga += @" AND naziv = @naziv";
            }

            if (cB_Autori_uneto || cB_Zanrovi_uneto || tB_Naziv_uneto) //Convert.ToInt32(cB_Autori.SelectedValue.ToString()) != 0 || cB_Zanrovi.SelectedValue.ToString() != "/" || !String.IsNullOrEmpty(tB_Naziv.Text)
            {
                DT_dostupne = Utils.Forms.RefreshDataGridView(dGV_Dostupne, queryDostupnePretraga, recnikDostupnePretraga);
                dGV_PozajmljeneOboji_DeselectFirstRow();
            }
            else
            {
                RefreshData();
            }

        }

        private void GlavniMeni_Load(object sender, EventArgs e)
        {
            Utils.Forms.ConfigureForm(this);
            Utils.Forms.ConfigureDataGridView(dGV_Pozajmljene, false);
            Utils.Forms.ConfigureDataGridView(dGV_Dostupne, false);

            ////Naziv TextBox
            dGV_Pozajmljene.RowsAdded += (s, a) => OnRowNumberChanged();
            ////

            RefreshData();
        }
        /////Naziv TextBox
        private void OnRowNumberChanged()
        {
            tB_PozajmljeneBroj.Text = dGV_Pozajmljene.Rows.Count.ToString();

        }
        /////

        private void dGV_Pozajmljene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPozajmljeneObrisi_Click(object sender, EventArgs e)
        {
            if (dGV_Pozajmljene.CurrentRow != null && DT_pozajmljene != null)
            {
                //DataRow DR_brisiPozajmljene = Utils.Forms.GetDataRowFromDataGridViewSelection(dGV_Pozajmljene, "pozajmljivanje_id", DT_pozajmljene, "pozajmljivanje_id");
                //Convert.ToInt32(DR_brisiPozajmljene["pozajmljivanje_id"].ToString())

                Utils.DB.ExecuteNonQuery(queryPozajmljeneBrisi,
                    new Dictionary<string, object>
                    {
                        ["@pozajmljivanje_id"] = (int)(long)dGV_Pozajmljene.CurrentRow.Cells["pozajmljivanje_id"].Value
                });
            }
            else
            {
                MessageBox.Show("Није обележенa ниједна књига!");
            }

            RefreshData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDostupnePozajmi_Click(object sender, EventArgs e)
        {
            bool cB_Citaci_uneto = Convert.ToInt32(cB_Citaci.SelectedValue.ToString()) != 0;

            //DataTableFromQuery(string query, Dictionary<string, object> parameters = null)
            int pozajmljeneBroj = Convert.ToInt32(Utils.DB.SelectSingleValueFromQuery(queryPozajmljeneBroj, 
                                                    new Dictionary<string, object>
                                                    {
                                                        ["@citac_id"] = Convert.ToInt32(cB_Citaci.SelectedValue.ToString())
                                                    }));
            int citaciBroj = Convert.ToInt32(Utils.DB.SelectSingleValueFromQuery(queryCitaciBroj,
                                                    new Dictionary<string, object>
                                                    {
                                                        ["@citac_id"] = Convert.ToInt32(cB_Citaci.SelectedValue.ToString())
                                                    }));

            if (dGV_Dostupne.CurrentRow != null && DT_dostupne != null)
            {
                if (cB_Citaci_uneto)
                {
                    if (pozajmljeneBroj < citaciBroj)
                    {
                        Utils.DB.ExecuteNonQuery(queryPozajmljeneUnesi,
                        new Dictionary<string, object>
                        {
                            ["@citac_id"] = Convert.ToInt32(cB_Citaci.SelectedValue.ToString()),
                            ["@knjiga_id"] = (int)(long)dGV_Dostupne.CurrentRow.Cells["knjiga_id_dGV_Dostupne"].Value, //0 knjiga_id
                            ["@datum"] = DateTime.Now.ToString() //Utils.DB.SelectSingleValueFromQuery("SELECT CURRENT_TIMESTAMP")
                        });

                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Читач је достигао лимит броја књига!");
                    }
                }
                else
                {
                    MessageBox.Show("Није обележен читач!");
                }
            }
            else
            {
                MessageBox.Show("Није обележенa ниједна књига!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPozajmljenePretraga_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> recnikPozajmljenePretraga = new Dictionary<string, object>();
            string queryPozajmljenePretraga = queryPozajmljene;
            bool cB_Knjige_uneto = Convert.ToInt32(cB_Knjige.SelectedValue.ToString()) != 0;
            bool cB_Citaci_uneto = Convert.ToInt32(cB_Citaci.SelectedValue.ToString()) != 0;

            if (cB_Knjige_uneto)
            {
                recnikPozajmljenePretraga.Add("@knjiga_id", Convert.ToInt32(cB_Knjige.SelectedValue.ToString()));
                queryPozajmljenePretraga += @" AND k.knjiga_id = @knjiga_id";
            }
            if (cB_Citaci_uneto)
            {
                recnikPozajmljenePretraga.Add("@citac_id", cB_Citaci.SelectedValue.ToString());
                queryPozajmljenePretraga += @" AND c.citac_id = @citac_id";
            }

            if (cB_Knjige_uneto || cB_Citaci_uneto)
            {
                DT_pozajmljene = Utils.Forms.RefreshDataGridView(dGV_Pozajmljene, queryPozajmljenePretraga, recnikPozajmljenePretraga);
                dGV_PozajmljeneOboji_DeselectFirstRow();
            }
            else
            {
                RefreshData();
            }

            if (dGV_Pozajmljene.Rows.Count == 0)
                tB_PozajmljeneBroj.Text = "0";
        }
        ///////////////////Dani ogranicenje oboji redove
        private void dGV_PozajmljeneOboji_DeselectFirstRow()
        {
            int citaciDani;

            foreach (DataGridViewRow row in dGV_Pozajmljene.Rows)
            {
                citaciDani = Convert.ToInt32(Utils.DB.SelectSingleValueFromQuery(queryCitaciDani,
                                                new Dictionary<string, object>
                                                {
                                                    ["@citac_id"] = Convert.ToInt32(row.Cells["citac_id"].Value.ToString())
                                                }));

                if ((DateTime.Now - Convert.ToDateTime(row.Cells["datum"].Value.ToString())).TotalDays > citaciDani) //row.Cells["datum"].Value.ToString() == "14-Apr-20 04:16:18"
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            
            ///da bi se videla boja svih redova..
            dGV_Pozajmljene.ClearSelection();
            dGV_Dostupne.ClearSelection();
            ///deselect the first row
            dGV_Pozajmljene.CurrentCell = null;
            dGV_Dostupne.CurrentCell = null;
        }

        private void btnForm_NovaKnjiga_Click(object sender, EventArgs e)
        {
            Utils.Forms.ReplaceForm(this, new NovaKnjiga(), true);
        }

        private void btnForm_NoviCitac_Click(object sender, EventArgs e)
        {
            Utils.Forms.ReplaceForm(this, new NoviCitac(), true);
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Utils.Forms.ReplaceForm(this, new Prijava(), true);
        }

        ///////////////////

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

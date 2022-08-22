namespace Biblioteka_2
{
    partial class GlavniMeni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.dGV_Pozajmljene = new System.Windows.Forms.DataGridView();
            this.pozajmljivanje_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjiga_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citac_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citac_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Dostupne = new System.Windows.Forms.DataGridView();
            this.knjiga_id_dGV_Dostupne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDostupnePretraga = new System.Windows.Forms.Button();
            this.cB_Autori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_Zanrovi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPozajmljeneObrisi = new System.Windows.Forms.Button();
            this.tB_Naziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cB_Citaci = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDostupnePozajmi = new System.Windows.Forms.Button();
            this.btnPozajmljenePretraga = new System.Windows.Forms.Button();
            this.cB_Knjige = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_PozajmljeneBroj = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnForm_NovaKnjiga = new System.Windows.Forms.Button();
            this.btnForm_NoviCitac = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Pozajmljene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Dostupne)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(905, 12);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(137, 23);
            this.btnOsvezi.TabIndex = 1;
            this.btnOsvezi.Text = "ОСВЕЖИ ПОДАТКЕ";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.GlavniMeni_Load);
            // 
            // dGV_Pozajmljene
            // 
            this.dGV_Pozajmljene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Pozajmljene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pozajmljivanje_id,
            this.knjiga_id,
            this.naziv,
            this.citac_id,
            this.citac_ime,
            this.datum});
            this.dGV_Pozajmljene.Location = new System.Drawing.Point(12, 65);
            this.dGV_Pozajmljene.Name = "dGV_Pozajmljene";
            this.dGV_Pozajmljene.Size = new System.Drawing.Size(695, 143);
            this.dGV_Pozajmljene.TabIndex = 2;
            // 
            // pozajmljivanje_id
            // 
            this.pozajmljivanje_id.DataPropertyName = "pozajmljivanje_id";
            this.pozajmljivanje_id.HeaderText = "ИД Поз.";
            this.pozajmljivanje_id.Name = "pozajmljivanje_id";
            // 
            // knjiga_id
            // 
            this.knjiga_id.DataPropertyName = "knjiga_id";
            this.knjiga_id.HeaderText = "ИД Књиге";
            this.knjiga_id.Name = "knjiga_id";
            // 
            // naziv
            // 
            this.naziv.DataPropertyName = "naziv";
            this.naziv.HeaderText = "Назив";
            this.naziv.Name = "naziv";
            // 
            // citac_id
            // 
            this.citac_id.DataPropertyName = "citac_id";
            this.citac_id.HeaderText = "ИД читача";
            this.citac_id.Name = "citac_id";
            // 
            // citac_ime
            // 
            this.citac_ime.DataPropertyName = "citac_ime";
            this.citac_ime.HeaderText = "Име читача";
            this.citac_ime.Name = "citac_ime";
            // 
            // datum
            // 
            this.datum.DataPropertyName = "datum";
            this.datum.HeaderText = "Датум";
            this.datum.Name = "datum";
            this.datum.Width = 130;
            // 
            // dGV_Dostupne
            // 
            this.dGV_Dostupne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Dostupne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjiga_id_dGV_Dostupne,
            this.dataGridViewTextBoxColumn2,
            this.godina,
            this.zanr,
            this.autor_ime});
            this.dGV_Dostupne.Location = new System.Drawing.Point(12, 321);
            this.dGV_Dostupne.Name = "dGV_Dostupne";
            this.dGV_Dostupne.Size = new System.Drawing.Size(567, 143);
            this.dGV_Dostupne.TabIndex = 3;
            // 
            // knjiga_id_dGV_Dostupne
            // 
            this.knjiga_id_dGV_Dostupne.DataPropertyName = "knjiga_id";
            this.knjiga_id_dGV_Dostupne.HeaderText = "ИД Књиге";
            this.knjiga_id_dGV_Dostupne.Name = "knjiga_id_dGV_Dostupne";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назив";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // godina
            // 
            this.godina.DataPropertyName = "godina";
            this.godina.HeaderText = "Година";
            this.godina.Name = "godina";
            // 
            // zanr
            // 
            this.zanr.DataPropertyName = "zanr";
            this.zanr.HeaderText = "Жанр";
            this.zanr.Name = "zanr";
            // 
            // autor_ime
            // 
            this.autor_ime.DataPropertyName = "autor_ime";
            this.autor_ime.HeaderText = "Име аутора";
            this.autor_ime.Name = "autor_ime";
            // 
            // btnDostupnePretraga
            // 
            this.btnDostupnePretraga.Location = new System.Drawing.Point(443, 291);
            this.btnDostupnePretraga.Name = "btnDostupnePretraga";
            this.btnDostupnePretraga.Size = new System.Drawing.Size(137, 24);
            this.btnDostupnePretraga.TabIndex = 4;
            this.btnDostupnePretraga.Text = "ПРЕТРАГА";
            this.btnDostupnePretraga.UseVisualStyleBackColor = true;
            this.btnDostupnePretraga.Click += new System.EventHandler(this.btnDostupnePretraga_Click);
            // 
            // cB_Autori
            // 
            this.cB_Autori.FormattingEnabled = true;
            this.cB_Autori.Location = new System.Drawing.Point(32, 294);
            this.cB_Autori.Name = "cB_Autori";
            this.cB_Autori.Size = new System.Drawing.Size(121, 21);
            this.cB_Autori.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ПОЗАЈМЉЕНЕ КЊИГЕ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ДОСТУПНЕ КЊИГЕ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "АУТОР";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cB_Zanrovi
            // 
            this.cB_Zanrovi.FormattingEnabled = true;
            this.cB_Zanrovi.Location = new System.Drawing.Point(159, 294);
            this.cB_Zanrovi.Name = "cB_Zanrovi";
            this.cB_Zanrovi.Size = new System.Drawing.Size(121, 21);
            this.cB_Zanrovi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ЖАНР";
            // 
            // btnPozajmljeneObrisi
            // 
            this.btnPozajmljeneObrisi.Location = new System.Drawing.Point(713, 185);
            this.btnPozajmljeneObrisi.Name = "btnPozajmljeneObrisi";
            this.btnPozajmljeneObrisi.Size = new System.Drawing.Size(180, 23);
            this.btnPozajmljeneObrisi.TabIndex = 11;
            this.btnPozajmljeneObrisi.Text = "ВРАЋАЊЕ ОЗНАЧЕНЕ КЊИГЕ";
            this.btnPozajmljeneObrisi.UseVisualStyleBackColor = true;
            this.btnPozajmljeneObrisi.Click += new System.EventHandler(this.btnPozajmljeneObrisi_Click);
            // 
            // tB_Naziv
            // 
            this.tB_Naziv.Location = new System.Drawing.Point(286, 294);
            this.tB_Naziv.Name = "tB_Naziv";
            this.tB_Naziv.Size = new System.Drawing.Size(151, 20);
            this.tB_Naziv.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "НАЗИВ";
            // 
            // cB_Citaci
            // 
            this.cB_Citaci.FormattingEnabled = true;
            this.cB_Citaci.Location = new System.Drawing.Point(443, 38);
            this.cB_Citaci.Name = "cB_Citaci";
            this.cB_Citaci.Size = new System.Drawing.Size(121, 21);
            this.cB_Citaci.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ЧИТАЧ";
            // 
            // btnDostupnePozajmi
            // 
            this.btnDostupnePozajmi.Location = new System.Drawing.Point(621, 321);
            this.btnDostupnePozajmi.Name = "btnDostupnePozajmi";
            this.btnDostupnePozajmi.Size = new System.Drawing.Size(217, 24);
            this.btnDostupnePozajmi.TabIndex = 16;
            this.btnDostupnePozajmi.Text = "ПОЗАЈМЉИВАЊЕ ОЗНАЧЕНЕ КЊИГЕ";
            this.btnDostupnePozajmi.UseVisualStyleBackColor = true;
            this.btnDostupnePozajmi.Click += new System.EventHandler(this.btnDostupnePozajmi_Click);
            // 
            // btnPozajmljenePretraga
            // 
            this.btnPozajmljenePretraga.Location = new System.Drawing.Point(570, 35);
            this.btnPozajmljenePretraga.Name = "btnPozajmljenePretraga";
            this.btnPozajmljenePretraga.Size = new System.Drawing.Size(137, 24);
            this.btnPozajmljenePretraga.TabIndex = 18;
            this.btnPozajmljenePretraga.Text = "ПРЕТРАГА";
            this.btnPozajmljenePretraga.UseVisualStyleBackColor = true;
            this.btnPozajmljenePretraga.Click += new System.EventHandler(this.btnPozajmljenePretraga_Click);
            // 
            // cB_Knjige
            // 
            this.cB_Knjige.FormattingEnabled = true;
            this.cB_Knjige.Location = new System.Drawing.Point(316, 38);
            this.cB_Knjige.Name = "cB_Knjige";
            this.cB_Knjige.Size = new System.Drawing.Size(121, 21);
            this.cB_Knjige.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ИД Књиге";
            // 
            // tB_PozajmljeneBroj
            // 
            this.tB_PozajmljeneBroj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tB_PozajmljeneBroj.Location = new System.Drawing.Point(786, 81);
            this.tB_PozajmljeneBroj.Name = "tB_PozajmljeneBroj";
            this.tB_PozajmljeneBroj.Size = new System.Drawing.Size(39, 20);
            this.tB_PozajmljeneBroj.TabIndex = 21;
            this.tB_PozajmljeneBroj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "БРОЈ ПОЗАЈМЉЕНИХ КЊИГА";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(428, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "* ПРЕКОРАЧЕНО ОГРАНИЧЕЊЕ У БРОЈУ ДАНА";
            // 
            // btnForm_NovaKnjiga
            // 
            this.btnForm_NovaKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm_NovaKnjiga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForm_NovaKnjiga.Location = new System.Drawing.Point(762, 420);
            this.btnForm_NovaKnjiga.Name = "btnForm_NovaKnjiga";
            this.btnForm_NovaKnjiga.Size = new System.Drawing.Size(137, 23);
            this.btnForm_NovaKnjiga.TabIndex = 24;
            this.btnForm_NovaKnjiga.Text = "КЊИГЕ И АУТОРИ";
            this.btnForm_NovaKnjiga.UseVisualStyleBackColor = true;
            this.btnForm_NovaKnjiga.Click += new System.EventHandler(this.btnForm_NovaKnjiga_Click);
            // 
            // btnForm_NoviCitac
            // 
            this.btnForm_NoviCitac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm_NoviCitac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForm_NoviCitac.Location = new System.Drawing.Point(762, 449);
            this.btnForm_NoviCitac.Name = "btnForm_NoviCitac";
            this.btnForm_NoviCitac.Size = new System.Drawing.Size(137, 23);
            this.btnForm_NoviCitac.TabIndex = 25;
            this.btnForm_NoviCitac.Text = "ЧИТАЧИ";
            this.btnForm_NoviCitac.UseVisualStyleBackColor = true;
            this.btnForm_NoviCitac.Click += new System.EventHandler(this.btnForm_NoviCitac_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.Red;
            this.btnOdjava.Location = new System.Drawing.Point(905, 449);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(137, 23);
            this.btnOdjava.TabIndex = 26;
            this.btnOdjava.Text = "ОДЈАВА";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // GlavniMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteka_2.Properties.Resources.book_res1;
            this.ClientSize = new System.Drawing.Size(1054, 484);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnForm_NoviCitac);
            this.Controls.Add(this.btnForm_NovaKnjiga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tB_PozajmljeneBroj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cB_Knjige);
            this.Controls.Add(this.btnPozajmljenePretraga);
            this.Controls.Add(this.btnDostupnePozajmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cB_Citaci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tB_Naziv);
            this.Controls.Add(this.btnPozajmljeneObrisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cB_Zanrovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_Autori);
            this.Controls.Add(this.btnDostupnePretraga);
            this.Controls.Add(this.dGV_Dostupne);
            this.Controls.Add(this.dGV_Pozajmljene);
            this.Controls.Add(this.btnOsvezi);
            this.Name = "GlavniMeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Школска библиотека - Главни мени";
            this.Load += new System.EventHandler(this.GlavniMeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Pozajmljene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Dostupne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.DataGridView dGV_Pozajmljene;
        private System.Windows.Forms.DataGridView dGV_Dostupne;
        private System.Windows.Forms.Button btnDostupnePretraga;
        private System.Windows.Forms.ComboBox cB_Autori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_Zanrovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPozajmljeneObrisi;
        private System.Windows.Forms.TextBox tB_Naziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cB_Citaci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDostupnePozajmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjiga_id_dGV_Dostupne;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor_ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozajmljivanje_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjiga_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn citac_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn citac_ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.Button btnPozajmljenePretraga;
        private System.Windows.Forms.ComboBox cB_Knjige;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_PozajmljeneBroj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnForm_NovaKnjiga;
        private System.Windows.Forms.Button btnForm_NoviCitac;
        private System.Windows.Forms.Button btnOdjava;
    }
}
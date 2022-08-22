namespace Biblioteka_2
{
    partial class NovaKnjiga
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKnjigeUnesi = new System.Windows.Forms.Button();
            this.tB_AutorIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAutoriUnesi = new System.Windows.Forms.Button();
            this.cB_AutorPol = new System.Windows.Forms.ComboBox();
            this.btnAutoriPretraga = new System.Windows.Forms.Button();
            this.btnKnjigeBrisi = new System.Windows.Forms.Button();
            this.btnAutoriBrisi = new System.Windows.Forms.Button();
            this.dGV_Knjige = new System.Windows.Forms.DataGridView();
            this.knjiga_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Autori = new System.Windows.Forms.DataGridView();
            this.autor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor_pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.tB_Naziv = new System.Windows.Forms.TextBox();
            this.tB_Godina = new System.Windows.Forms.TextBox();
            this.tB_Zanr = new System.Windows.Forms.TextBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnForm_GlavniMeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Knjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Autori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "КЊИГЕ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "АУТОРИ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "НАЗИВ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ГОДИНА";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ЖАНР";
            // 
            // btnKnjigeUnesi
            // 
            this.btnKnjigeUnesi.Location = new System.Drawing.Point(759, 168);
            this.btnKnjigeUnesi.Name = "btnKnjigeUnesi";
            this.btnKnjigeUnesi.Size = new System.Drawing.Size(138, 23);
            this.btnKnjigeUnesi.TabIndex = 11;
            this.btnKnjigeUnesi.Text = "УНОС НОВЕ КЊИГЕ";
            this.btnKnjigeUnesi.UseVisualStyleBackColor = true;
            this.btnKnjigeUnesi.Click += new System.EventHandler(this.btnKnjigeUnesi_Click);
            // 
            // tB_AutorIme
            // 
            this.tB_AutorIme.Location = new System.Drawing.Point(414, 271);
            this.tB_AutorIme.Name = "tB_AutorIme";
            this.tB_AutorIme.Size = new System.Drawing.Size(100, 20);
            this.tB_AutorIme.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ИМЕ АУТОРА";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "ПОЛ АУТОРА";
            // 
            // btnAutoriUnesi
            // 
            this.btnAutoriUnesi.Location = new System.Drawing.Point(503, 298);
            this.btnAutoriUnesi.Name = "btnAutoriUnesi";
            this.btnAutoriUnesi.Size = new System.Drawing.Size(138, 23);
            this.btnAutoriUnesi.TabIndex = 17;
            this.btnAutoriUnesi.Text = "УНОС НОВОГ АУТОРА";
            this.btnAutoriUnesi.UseVisualStyleBackColor = true;
            this.btnAutoriUnesi.Click += new System.EventHandler(this.btnAutoriUnesi_Click);
            // 
            // cB_AutorPol
            // 
            this.cB_AutorPol.FormattingEnabled = true;
            this.cB_AutorPol.Location = new System.Drawing.Point(520, 271);
            this.cB_AutorPol.Name = "cB_AutorPol";
            this.cB_AutorPol.Size = new System.Drawing.Size(121, 21);
            this.cB_AutorPol.TabIndex = 18;
            // 
            // btnAutoriPretraga
            // 
            this.btnAutoriPretraga.Location = new System.Drawing.Point(271, 227);
            this.btnAutoriPretraga.Name = "btnAutoriPretraga";
            this.btnAutoriPretraga.Size = new System.Drawing.Size(137, 21);
            this.btnAutoriPretraga.TabIndex = 19;
            this.btnAutoriPretraga.Text = "ПРЕТРАГА ПО ИМЕНУ";
            this.btnAutoriPretraga.UseVisualStyleBackColor = true;
            this.btnAutoriPretraga.Click += new System.EventHandler(this.btnAutoriPretraga_Click);
            // 
            // btnKnjigeBrisi
            // 
            this.btnKnjigeBrisi.Location = new System.Drawing.Point(388, 12);
            this.btnKnjigeBrisi.Name = "btnKnjigeBrisi";
            this.btnKnjigeBrisi.Size = new System.Drawing.Size(188, 23);
            this.btnKnjigeBrisi.TabIndex = 20;
            this.btnKnjigeBrisi.Text = "БРИСАЊЕ ОЗНАЧЕНЕ КЊИГЕ";
            this.btnKnjigeBrisi.UseVisualStyleBackColor = true;
            this.btnKnjigeBrisi.Click += new System.EventHandler(this.btnKnjigeBrisi_Click);
            // 
            // btnAutoriBrisi
            // 
            this.btnAutoriBrisi.Location = new System.Drawing.Point(76, 226);
            this.btnAutoriBrisi.Name = "btnAutoriBrisi";
            this.btnAutoriBrisi.Size = new System.Drawing.Size(188, 23);
            this.btnAutoriBrisi.TabIndex = 21;
            this.btnAutoriBrisi.Text = "БРИСАЊЕ ОЗНАЧЕНОГ АУТОРА";
            this.btnAutoriBrisi.UseVisualStyleBackColor = true;
            this.btnAutoriBrisi.Click += new System.EventHandler(this.btnAutoriBrisi_Click);
            // 
            // dGV_Knjige
            // 
            this.dGV_Knjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Knjige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjiga_id,
            this.naziv,
            this.godina,
            this.zanr});
            this.dGV_Knjige.Location = new System.Drawing.Point(15, 41);
            this.dGV_Knjige.Name = "dGV_Knjige";
            this.dGV_Knjige.Size = new System.Drawing.Size(561, 150);
            this.dGV_Knjige.TabIndex = 22;
            this.dGV_Knjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Knjige_CellContentClick);
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
            this.naziv.Width = 200;
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
            // dGV_Autori
            // 
            this.dGV_Autori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Autori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autor_id,
            this.autor_ime,
            this.autor_pol});
            this.dGV_Autori.Location = new System.Drawing.Point(15, 255);
            this.dGV_Autori.Name = "dGV_Autori";
            this.dGV_Autori.Size = new System.Drawing.Size(393, 150);
            this.dGV_Autori.TabIndex = 23;
            // 
            // autor_id
            // 
            this.autor_id.DataPropertyName = "autor_id";
            this.autor_id.HeaderText = "ИД Аутора";
            this.autor_id.Name = "autor_id";
            // 
            // autor_ime
            // 
            this.autor_ime.DataPropertyName = "autor_ime";
            this.autor_ime.HeaderText = "Име аутора";
            this.autor_ime.Name = "autor_ime";
            this.autor_ime.Width = 130;
            // 
            // autor_pol
            // 
            this.autor_pol.DataPropertyName = "autor_pol";
            this.autor_pol.HeaderText = "Пол аутора";
            this.autor_pol.Name = "autor_pol";
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(760, 12);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(137, 23);
            this.btnOsvezi.TabIndex = 24;
            this.btnOsvezi.Text = "ОСВЕЖИ ПОДАТКЕ";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.NovaKnjiga_Load);
            // 
            // tB_Naziv
            // 
            this.tB_Naziv.Location = new System.Drawing.Point(585, 142);
            this.tB_Naziv.Name = "tB_Naziv";
            this.tB_Naziv.Size = new System.Drawing.Size(100, 20);
            this.tB_Naziv.TabIndex = 25;
            // 
            // tB_Godina
            // 
            this.tB_Godina.Location = new System.Drawing.Point(691, 142);
            this.tB_Godina.Name = "tB_Godina";
            this.tB_Godina.Size = new System.Drawing.Size(100, 20);
            this.tB_Godina.TabIndex = 26;
            // 
            // tB_Zanr
            // 
            this.tB_Zanr.Location = new System.Drawing.Point(797, 142);
            this.tB_Zanr.Name = "tB_Zanr";
            this.tB_Zanr.Size = new System.Drawing.Size(100, 20);
            this.tB_Zanr.TabIndex = 27;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.Red;
            this.btnOdjava.Location = new System.Drawing.Point(760, 415);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(137, 23);
            this.btnOdjava.TabIndex = 28;
            this.btnOdjava.Text = "ОДЈАВА";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnForm_GlavniMeni
            // 
            this.btnForm_GlavniMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm_GlavniMeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForm_GlavniMeni.Location = new System.Drawing.Point(617, 415);
            this.btnForm_GlavniMeni.Name = "btnForm_GlavniMeni";
            this.btnForm_GlavniMeni.Size = new System.Drawing.Size(137, 23);
            this.btnForm_GlavniMeni.TabIndex = 29;
            this.btnForm_GlavniMeni.Text = "ГЛАВНИ МЕНИ";
            this.btnForm_GlavniMeni.UseVisualStyleBackColor = true;
            this.btnForm_GlavniMeni.Click += new System.EventHandler(this.btnForm_GlavniMeni_Click);
            // 
            // NovaKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteka_2.Properties.Resources.book_res2;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.btnForm_GlavniMeni);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.tB_Zanr);
            this.Controls.Add(this.tB_Godina);
            this.Controls.Add(this.tB_Naziv);
            this.Controls.Add(this.btnOsvezi);
            this.Controls.Add(this.dGV_Autori);
            this.Controls.Add(this.dGV_Knjige);
            this.Controls.Add(this.btnAutoriBrisi);
            this.Controls.Add(this.btnKnjigeBrisi);
            this.Controls.Add(this.btnAutoriPretraga);
            this.Controls.Add(this.cB_AutorPol);
            this.Controls.Add(this.btnAutoriUnesi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tB_AutorIme);
            this.Controls.Add(this.btnKnjigeUnesi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovaKnjiga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Школска библиотека - Нова књига";
            this.Load += new System.EventHandler(this.NovaKnjiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Knjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Autori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKnjigeUnesi;
        private System.Windows.Forms.TextBox tB_AutorIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAutoriUnesi;
        private System.Windows.Forms.ComboBox cB_AutorPol;
        private System.Windows.Forms.Button btnAutoriPretraga;
        private System.Windows.Forms.Button btnKnjigeBrisi;
        private System.Windows.Forms.Button btnAutoriBrisi;
        private System.Windows.Forms.DataGridView dGV_Knjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn knjiga_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanr;
        private System.Windows.Forms.DataGridView dGV_Autori;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor_ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor_pol;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.TextBox tB_Naziv;
        private System.Windows.Forms.TextBox tB_Godina;
        private System.Windows.Forms.TextBox tB_Zanr;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnForm_GlavniMeni;
    }
}
namespace Biblioteka_2
{
    partial class NoviRadnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_Radnici = new System.Windows.Forms.DataGridView();
            this.radnik_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnik_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnik_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tB_RadnikIme = new System.Windows.Forms.TextBox();
            this.tB_RadnikTel = new System.Windows.Forms.TextBox();
            this.tB_Sifra = new System.Windows.Forms.TextBox();
            this.btnRadniciUnesi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRadniciBrisi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnForm_GlavniMeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Radnici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(671, 12);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(130, 23);
            this.btnOsvezi.TabIndex = 0;
            this.btnOsvezi.Text = "ОСВЕЖИ ПОДАТКЕ";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.NoviRadnik_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "РАДНИЦИ";
            // 
            // dGV_Radnici
            // 
            this.dGV_Radnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Radnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radnik_id,
            this.radnik_ime,
            this.sifra,
            this.radnik_tel});
            this.dGV_Radnici.Location = new System.Drawing.Point(15, 87);
            this.dGV_Radnici.Name = "dGV_Radnici";
            this.dGV_Radnici.Size = new System.Drawing.Size(466, 187);
            this.dGV_Radnici.TabIndex = 2;
            // 
            // radnik_id
            // 
            this.radnik_id.DataPropertyName = "radnik_id";
            this.radnik_id.HeaderText = "ИД Радника";
            this.radnik_id.Name = "radnik_id";
            // 
            // radnik_ime
            // 
            this.radnik_ime.DataPropertyName = "radnik_ime";
            this.radnik_ime.HeaderText = "Име радника";
            this.radnik_ime.Name = "radnik_ime";
            this.radnik_ime.Width = 120;
            // 
            // sifra
            // 
            this.sifra.DataPropertyName = "sifra";
            this.sifra.HeaderText = "Шифра";
            this.sifra.Name = "sifra";
            // 
            // radnik_tel
            // 
            this.radnik_tel.DataPropertyName = "radnik_tel";
            this.radnik_tel.HeaderText = "Телефон";
            this.radnik_tel.Name = "radnik_tel";
            // 
            // tB_RadnikIme
            // 
            this.tB_RadnikIme.Location = new System.Drawing.Point(489, 225);
            this.tB_RadnikIme.Name = "tB_RadnikIme";
            this.tB_RadnikIme.Size = new System.Drawing.Size(100, 20);
            this.tB_RadnikIme.TabIndex = 3;
            // 
            // tB_RadnikTel
            // 
            this.tB_RadnikTel.Location = new System.Drawing.Point(701, 225);
            this.tB_RadnikTel.Name = "tB_RadnikTel";
            this.tB_RadnikTel.Size = new System.Drawing.Size(100, 20);
            this.tB_RadnikTel.TabIndex = 4;
            // 
            // tB_Sifra
            // 
            this.tB_Sifra.Location = new System.Drawing.Point(595, 225);
            this.tB_Sifra.Name = "tB_Sifra";
            this.tB_Sifra.Size = new System.Drawing.Size(100, 20);
            this.tB_Sifra.TabIndex = 5;
            // 
            // btnRadniciUnesi
            // 
            this.btnRadniciUnesi.Location = new System.Drawing.Point(657, 251);
            this.btnRadniciUnesi.Name = "btnRadniciUnesi";
            this.btnRadniciUnesi.Size = new System.Drawing.Size(144, 23);
            this.btnRadniciUnesi.TabIndex = 18;
            this.btnRadniciUnesi.Text = "УНОС НОВОГ РАДНИКА";
            this.btnRadniciUnesi.UseVisualStyleBackColor = true;
            this.btnRadniciUnesi.Click += new System.EventHandler(this.btnRadniciUnesi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ИМЕ РАДНИКА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ШИФРА";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ТЕЛЕФОН";
            // 
            // btnRadniciBrisi
            // 
            this.btnRadniciBrisi.Location = new System.Drawing.Point(282, 58);
            this.btnRadniciBrisi.Name = "btnRadniciBrisi";
            this.btnRadniciBrisi.Size = new System.Drawing.Size(199, 23);
            this.btnRadniciBrisi.TabIndex = 22;
            this.btnRadniciBrisi.Text = "БРИСАЊЕ ОЗНАЧЕНОГ РАДНИКА";
            this.btnRadniciBrisi.UseVisualStyleBackColor = true;
            this.btnRadniciBrisi.Click += new System.EventHandler(this.btnRadniciBrisi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(368, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "* АДМИНИСТРАТОР";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.Red;
            this.btnOdjava.Location = new System.Drawing.Point(664, 415);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(137, 23);
            this.btnOdjava.TabIndex = 27;
            this.btnOdjava.Text = "ОДЈАВА";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnForm_GlavniMeni
            // 
            this.btnForm_GlavniMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm_GlavniMeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForm_GlavniMeni.Location = new System.Drawing.Point(521, 415);
            this.btnForm_GlavniMeni.Name = "btnForm_GlavniMeni";
            this.btnForm_GlavniMeni.Size = new System.Drawing.Size(137, 23);
            this.btnForm_GlavniMeni.TabIndex = 28;
            this.btnForm_GlavniMeni.Text = "ГЛАВНИ МЕНИ";
            this.btnForm_GlavniMeni.UseVisualStyleBackColor = true;
            this.btnForm_GlavniMeni.Click += new System.EventHandler(this.btnForm_GlavniMeni_Click);
            // 
            // NoviRadnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteka_2.Properties.Resources.book_res4;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.btnForm_GlavniMeni);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRadniciBrisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRadniciUnesi);
            this.Controls.Add(this.tB_Sifra);
            this.Controls.Add(this.tB_RadnikTel);
            this.Controls.Add(this.tB_RadnikIme);
            this.Controls.Add(this.dGV_Radnici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOsvezi);
            this.Name = "NoviRadnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Школска библиотека - АДМИНИСТРАТОР";
            this.Load += new System.EventHandler(this.NoviRadnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Radnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_Radnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnik_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnik_ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnik_tel;
        private System.Windows.Forms.TextBox tB_RadnikIme;
        private System.Windows.Forms.TextBox tB_RadnikTel;
        private System.Windows.Forms.TextBox tB_Sifra;
        private System.Windows.Forms.Button btnRadniciUnesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRadniciBrisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnForm_GlavniMeni;
    }
}
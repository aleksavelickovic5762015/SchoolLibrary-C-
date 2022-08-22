namespace Biblioteka_2
{
    partial class NoviCitac
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
            this.tB_CitacIme = new System.Windows.Forms.TextBox();
            this.tB_CitacMejl = new System.Windows.Forms.TextBox();
            this.tB_CitacTel = new System.Windows.Forms.TextBox();
            this.dGV_Citaci = new System.Windows.Forms.DataGridView();
            this.citac_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citac_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citac_pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citac_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citac_mejl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip_citaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_CitacKategorije = new System.Windows.Forms.DataGridView();
            this.kategorija_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broj_knjiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dani_ogranicenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCitaciUpisi = new System.Windows.Forms.Button();
            this.cB_CitacPol = new System.Windows.Forms.ComboBox();
            this.btnCitaciBrisi = new System.Windows.Forms.Button();
            this.btnCitaciPretraga = new System.Windows.Forms.Button();
            this.btnForm_GlavniMeni = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Citaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CitacKategorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(759, 12);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(137, 23);
            this.btnOsvezi.TabIndex = 0;
            this.btnOsvezi.Text = "ОСВЕЖИ ПОДАТКЕ";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.NoviCitac_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ЧИТАЧИ";
            // 
            // tB_CitacIme
            // 
            this.tB_CitacIme.Location = new System.Drawing.Point(388, 252);
            this.tB_CitacIme.Name = "tB_CitacIme";
            this.tB_CitacIme.Size = new System.Drawing.Size(100, 20);
            this.tB_CitacIme.TabIndex = 2;
            // 
            // tB_CitacMejl
            // 
            this.tB_CitacMejl.Location = new System.Drawing.Point(727, 251);
            this.tB_CitacMejl.Name = "tB_CitacMejl";
            this.tB_CitacMejl.Size = new System.Drawing.Size(169, 20);
            this.tB_CitacMejl.TabIndex = 3;
            // 
            // tB_CitacTel
            // 
            this.tB_CitacTel.Location = new System.Drawing.Point(621, 251);
            this.tB_CitacTel.Name = "tB_CitacTel";
            this.tB_CitacTel.Size = new System.Drawing.Size(100, 20);
            this.tB_CitacTel.TabIndex = 4;
            // 
            // dGV_Citaci
            // 
            this.dGV_Citaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Citaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citac_id,
            this.citac_ime,
            this.citac_pol,
            this.citac_tel,
            this.citac_mejl,
            this.tip_citaci});
            this.dGV_Citaci.Location = new System.Drawing.Point(12, 65);
            this.dGV_Citaci.Name = "dGV_Citaci";
            this.dGV_Citaci.Size = new System.Drawing.Size(764, 150);
            this.dGV_Citaci.TabIndex = 6;
            // 
            // citac_id
            // 
            this.citac_id.DataPropertyName = "citac_id";
            this.citac_id.HeaderText = "ИД Читача";
            this.citac_id.Name = "citac_id";
            // 
            // citac_ime
            // 
            this.citac_ime.DataPropertyName = "citac_ime";
            this.citac_ime.HeaderText = "Име читача";
            this.citac_ime.Name = "citac_ime";
            this.citac_ime.Width = 150;
            // 
            // citac_pol
            // 
            this.citac_pol.DataPropertyName = "citac_pol";
            this.citac_pol.HeaderText = "Пол читача";
            this.citac_pol.Name = "citac_pol";
            // 
            // citac_tel
            // 
            this.citac_tel.DataPropertyName = "citac_tel";
            this.citac_tel.HeaderText = "Телефон";
            this.citac_tel.Name = "citac_tel";
            // 
            // citac_mejl
            // 
            this.citac_mejl.DataPropertyName = "citac_mejl";
            this.citac_mejl.HeaderText = "Е - пошта";
            this.citac_mejl.Name = "citac_mejl";
            this.citac_mejl.Width = 150;
            // 
            // tip_citaci
            // 
            this.tip_citaci.DataPropertyName = "tip";
            this.tip_citaci.HeaderText = "Тип";
            this.tip_citaci.Name = "tip_citaci";
            // 
            // dGV_CitacKategorije
            // 
            this.dGV_CitacKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_CitacKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategorija_id,
            this.tip,
            this.broj_knjiga,
            this.dani_ogranicenje});
            this.dGV_CitacKategorije.Location = new System.Drawing.Point(12, 286);
            this.dGV_CitacKategorije.Name = "dGV_CitacKategorije";
            this.dGV_CitacKategorije.Size = new System.Drawing.Size(484, 70);
            this.dGV_CitacKategorije.TabIndex = 7;
            // 
            // kategorija_id
            // 
            this.kategorija_id.DataPropertyName = "kategorija_id";
            this.kategorija_id.HeaderText = "ИД Категорије";
            this.kategorija_id.Name = "kategorija_id";
            this.kategorija_id.Width = 110;
            // 
            // tip
            // 
            this.tip.DataPropertyName = "tip";
            this.tip.HeaderText = "Тип";
            this.tip.Name = "tip";
            // 
            // broj_knjiga
            // 
            this.broj_knjiga.DataPropertyName = "broj_knjiga";
            this.broj_knjiga.HeaderText = "Број књига";
            this.broj_knjiga.Name = "broj_knjiga";
            // 
            // dani_ogranicenje
            // 
            this.dani_ogranicenje.DataPropertyName = "dani_ogranicenje";
            this.dani_ogranicenje.HeaderText = "Дани - ограничење";
            this.dani_ogranicenje.Name = "dani_ogranicenje";
            this.dani_ogranicenje.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "КАТЕГОРИЈЕ ЧИТАЧА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ИМЕ ЧИТАЧА";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ПОЛ ЧИТАЧА";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ТЕЛЕФОН";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(724, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Е - пошта";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView3.Location = new System.Drawing.Point(475, 499);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(472, 101);
            this.dataGridView3.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kategorija_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД Категорија";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tip";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "broj_knjiga";
            this.dataGridViewTextBoxColumn3.HeaderText = "Број књига";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dani_ogranicenje";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дани - ограничење";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnCitaciUpisi
            // 
            this.btnCitaciUpisi.Location = new System.Drawing.Point(759, 277);
            this.btnCitaciUpisi.Name = "btnCitaciUpisi";
            this.btnCitaciUpisi.Size = new System.Drawing.Size(137, 23);
            this.btnCitaciUpisi.TabIndex = 13;
            this.btnCitaciUpisi.Text = "УНОС НОВОГ ЧЛАНА";
            this.btnCitaciUpisi.UseVisualStyleBackColor = true;
            this.btnCitaciUpisi.Click += new System.EventHandler(this.btnCitaciUpisi_Click);
            // 
            // cB_CitacPol
            // 
            this.cB_CitacPol.FormattingEnabled = true;
            this.cB_CitacPol.Location = new System.Drawing.Point(494, 251);
            this.cB_CitacPol.Name = "cB_CitacPol";
            this.cB_CitacPol.Size = new System.Drawing.Size(121, 21);
            this.cB_CitacPol.TabIndex = 19;
            // 
            // btnCitaciBrisi
            // 
            this.btnCitaciBrisi.Location = new System.Drawing.Point(503, 36);
            this.btnCitaciBrisi.Name = "btnCitaciBrisi";
            this.btnCitaciBrisi.Size = new System.Drawing.Size(188, 23);
            this.btnCitaciBrisi.TabIndex = 21;
            this.btnCitaciBrisi.Text = "БРИСАЊЕ ОЗНАЧЕНОГ ЧЛАНА";
            this.btnCitaciBrisi.UseVisualStyleBackColor = true;
            this.btnCitaciBrisi.Click += new System.EventHandler(this.btnCitaciBrisi_Click);
            // 
            // btnCitaciPretraga
            // 
            this.btnCitaciPretraga.Location = new System.Drawing.Point(351, 38);
            this.btnCitaciPretraga.Name = "btnCitaciPretraga";
            this.btnCitaciPretraga.Size = new System.Drawing.Size(137, 21);
            this.btnCitaciPretraga.TabIndex = 22;
            this.btnCitaciPretraga.Text = "ПРЕТРАГА ПО ИМЕНУ";
            this.btnCitaciPretraga.UseVisualStyleBackColor = true;
            this.btnCitaciPretraga.Click += new System.EventHandler(this.btnCitaciPretraga_Click);
            // 
            // btnForm_GlavniMeni
            // 
            this.btnForm_GlavniMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm_GlavniMeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnForm_GlavniMeni.Location = new System.Drawing.Point(616, 415);
            this.btnForm_GlavniMeni.Name = "btnForm_GlavniMeni";
            this.btnForm_GlavniMeni.Size = new System.Drawing.Size(137, 23);
            this.btnForm_GlavniMeni.TabIndex = 30;
            this.btnForm_GlavniMeni.Text = "ГЛАВНИ МЕНИ";
            this.btnForm_GlavniMeni.UseVisualStyleBackColor = true;
            this.btnForm_GlavniMeni.Click += new System.EventHandler(this.btnForm_GlavniMeni_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.Red;
            this.btnOdjava.Location = new System.Drawing.Point(759, 415);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(137, 23);
            this.btnOdjava.TabIndex = 31;
            this.btnOdjava.Text = "ОДЈАВА";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // NoviCitac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biblioteka_2.Properties.Resources.book_res3;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnForm_GlavniMeni);
            this.Controls.Add(this.btnCitaciPretraga);
            this.Controls.Add(this.btnCitaciBrisi);
            this.Controls.Add(this.cB_CitacPol);
            this.Controls.Add(this.btnCitaciUpisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dGV_CitacKategorije);
            this.Controls.Add(this.dGV_Citaci);
            this.Controls.Add(this.tB_CitacTel);
            this.Controls.Add(this.tB_CitacMejl);
            this.Controls.Add(this.tB_CitacIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOsvezi);
            this.Name = "NoviCitac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Школска библиотека - Нови читач";
            this.Load += new System.EventHandler(this.NoviCitac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Citaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CitacKategorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_CitacIme;
        private System.Windows.Forms.TextBox tB_CitacMejl;
        private System.Windows.Forms.TextBox tB_CitacTel;
        private System.Windows.Forms.DataGridView dGV_Citaci;
        private System.Windows.Forms.DataGridView dGV_CitacKategorije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn citac_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn citac_ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn citac_pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn citac_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn citac_mejl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip_citaci;
        private System.Windows.Forms.Button btnCitaciUpisi;
        private System.Windows.Forms.ComboBox cB_CitacPol;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorija_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_knjiga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dani_ogranicenje;
        private System.Windows.Forms.Button btnCitaciBrisi;
        private System.Windows.Forms.Button btnCitaciPretraga;
        private System.Windows.Forms.Button btnForm_GlavniMeni;
        private System.Windows.Forms.Button btnOdjava;
    }
}
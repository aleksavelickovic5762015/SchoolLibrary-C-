namespace Biblioteka_2
{
    partial class Prijava
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
            this.tB_ImeRadnika = new System.Windows.Forms.TextBox();
            this.tB_Sifra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrijavа = new System.Windows.Forms.Button();
            this.Izlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_ImeRadnika
            // 
            this.tB_ImeRadnika.Location = new System.Drawing.Point(305, 101);
            this.tB_ImeRadnika.Name = "tB_ImeRadnika";
            this.tB_ImeRadnika.Size = new System.Drawing.Size(100, 20);
            this.tB_ImeRadnika.TabIndex = 0;
            // 
            // tB_Sifra
            // 
            this.tB_Sifra.Location = new System.Drawing.Point(305, 165);
            this.tB_Sifra.Name = "tB_Sifra";
            this.tB_Sifra.Size = new System.Drawing.Size(100, 20);
            this.tB_Sifra.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Име радника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Шифра";
            // 
            // btnPrijavа
            // 
            this.btnPrijavа.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijavа.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPrijavа.Location = new System.Drawing.Point(210, 262);
            this.btnPrijavа.Name = "btnPrijavа";
            this.btnPrijavа.Size = new System.Drawing.Size(75, 23);
            this.btnPrijavа.TabIndex = 4;
            this.btnPrijavа.Text = "ПРИЈАВА";
            this.btnPrijavа.UseVisualStyleBackColor = true;
            this.btnPrijavа.Click += new System.EventHandler(this.Prijavа_Click);
            // 
            // Izlaz
            // 
            this.Izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izlaz.ForeColor = System.Drawing.Color.Red;
            this.Izlaz.Location = new System.Drawing.Point(330, 262);
            this.Izlaz.Name = "Izlaz";
            this.Izlaz.Size = new System.Drawing.Size(75, 23);
            this.Izlaz.TabIndex = 5;
            this.Izlaz.Text = "ИЗЛАЗ";
            this.Izlaz.UseVisualStyleBackColor = true;
            this.Izlaz.Click += new System.EventHandler(this.Izlaz_Click);
            // 
            // Prijava
            // 
            this.BackgroundImage = global::Biblioteka_2.Properties.Resources.book_res;
            this.ClientSize = new System.Drawing.Size(648, 382);
            this.Controls.Add(this.Izlaz);
            this.Controls.Add(this.btnPrijavа);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_Sifra);
            this.Controls.Add(this.tB_ImeRadnika);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Школска библиотека - Пријава";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_ImeRadnika;
        private System.Windows.Forms.TextBox tB_Sifra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrijavа;
        private System.Windows.Forms.Button Izlaz;
    }
}


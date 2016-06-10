namespace BlackJack
{
    partial class Form2
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
            this.dajKarte = new System.Windows.Forms.Button();
            this.Pasuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Punkty_Krupiera = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Punkty_Gracza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Wartosc_zetonow_krupiera = new System.Windows.Forms.Label();
            this.Wartosc_puli = new System.Windows.Forms.Label();
            this.Wartosc_zetonow_gracza = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dajKarte
            // 
            this.dajKarte.Location = new System.Drawing.Point(28, 147);
            this.dajKarte.Name = "dajKarte";
            this.dajKarte.Size = new System.Drawing.Size(75, 23);
            this.dajKarte.TabIndex = 0;
            this.dajKarte.Text = "Rozdaj";
            this.dajKarte.UseVisualStyleBackColor = true;
            this.dajKarte.Click += new System.EventHandler(this.dajKarte_Click);
            // 
            // Pasuj
            // 
            this.Pasuj.Location = new System.Drawing.Point(160, 147);
            this.Pasuj.Name = "Pasuj";
            this.Pasuj.Size = new System.Drawing.Size(75, 23);
            this.Pasuj.TabIndex = 1;
            this.Pasuj.Text = "Pas";
            this.Pasuj.UseVisualStyleBackColor = true;
            this.Pasuj.Click += new System.EventHandler(this.Pasuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Krupier";
            // 
            // Punkty_Krupiera
            // 
            this.Punkty_Krupiera.AutoSize = true;
            this.Punkty_Krupiera.Location = new System.Drawing.Point(206, 60);
            this.Punkty_Krupiera.Name = "Punkty_Krupiera";
            this.Punkty_Krupiera.Size = new System.Drawing.Size(13, 13);
            this.Punkty_Krupiera.TabIndex = 3;
            this.Punkty_Krupiera.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gracz";
            // 
            // Punkty_Gracza
            // 
            this.Punkty_Gracza.AutoSize = true;
            this.Punkty_Gracza.Location = new System.Drawing.Point(40, 190);
            this.Punkty_Gracza.Name = "Punkty_Gracza";
            this.Punkty_Gracza.Size = new System.Drawing.Size(13, 13);
            this.Punkty_Gracza.TabIndex = 5;
            this.Punkty_Gracza.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zetony Gracza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zetony Krupiera";
            // 
            // Wartosc_zetonow_krupiera
            // 
            this.Wartosc_zetonow_krupiera.AutoSize = true;
            this.Wartosc_zetonow_krupiera.Location = new System.Drawing.Point(38, 71);
            this.Wartosc_zetonow_krupiera.Name = "Wartosc_zetonow_krupiera";
            this.Wartosc_zetonow_krupiera.Size = new System.Drawing.Size(29, 13);
            this.Wartosc_zetonow_krupiera.TabIndex = 8;
            this.Wartosc_zetonow_krupiera.Text = "Ilosc";
            // 
            // Wartosc_puli
            // 
            this.Wartosc_puli.AutoSize = true;
            this.Wartosc_puli.Location = new System.Drawing.Point(60, 239);
            this.Wartosc_puli.Name = "Wartosc_puli";
            this.Wartosc_puli.Size = new System.Drawing.Size(29, 13);
            this.Wartosc_puli.TabIndex = 9;
            this.Wartosc_puli.Text = "Ilosc";
            // 
            // Wartosc_zetonow_gracza
            // 
            this.Wartosc_zetonow_gracza.AutoSize = true;
            this.Wartosc_zetonow_gracza.Location = new System.Drawing.Point(182, 190);
            this.Wartosc_zetonow_gracza.Name = "Wartosc_zetonow_gracza";
            this.Wartosc_zetonow_gracza.Size = new System.Drawing.Size(29, 13);
            this.Wartosc_zetonow_gracza.TabIndex = 10;
            this.Wartosc_zetonow_gracza.Text = "Ilosc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pula";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Wartosc_zetonow_gracza);
            this.Controls.Add(this.Wartosc_puli);
            this.Controls.Add(this.Wartosc_zetonow_krupiera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Punkty_Gracza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Punkty_Krupiera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pasuj);
            this.Controls.Add(this.dajKarte);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dajKarte;
        private System.Windows.Forms.Button Pasuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Punkty_Krupiera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Punkty_Gracza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Wartosc_zetonow_krupiera;
        private System.Windows.Forms.Label Wartosc_puli;
        private System.Windows.Forms.Label Wartosc_zetonow_gracza;
        private System.Windows.Forms.Label label8;
    }
}
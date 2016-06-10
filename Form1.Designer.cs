namespace BlackJack
{
    partial class Form1
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
            this.Zeton10 = new System.Windows.Forms.Button();
            this.Zeton25 = new System.Windows.Forms.Button();
            this.Zeton50 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zeton10
            // 
            this.Zeton10.Location = new System.Drawing.Point(42, 198);
            this.Zeton10.Name = "Zeton10";
            this.Zeton10.Size = new System.Drawing.Size(75, 23);
            this.Zeton10.TabIndex = 0;
            this.Zeton10.Text = "10";
            this.Zeton10.UseVisualStyleBackColor = true;
            this.Zeton10.Click += new System.EventHandler(this.Zeton10_Click);
            // 
            // Zeton25
            // 
            this.Zeton25.Location = new System.Drawing.Point(150, 198);
            this.Zeton25.Name = "Zeton25";
            this.Zeton25.Size = new System.Drawing.Size(75, 23);
            this.Zeton25.TabIndex = 1;
            this.Zeton25.Text = "25";
            this.Zeton25.UseVisualStyleBackColor = true;
            this.Zeton25.Click += new System.EventHandler(this.Zeton25_Click);
            // 
            // Zeton50
            // 
            this.Zeton50.Location = new System.Drawing.Point(272, 197);
            this.Zeton50.Name = "Zeton50";
            this.Zeton50.Size = new System.Drawing.Size(75, 23);
            this.Zeton50.TabIndex = 2;
            this.Zeton50.Text = "50";
            this.Zeton50.UseVisualStyleBackColor = true;
            this.Zeton50.Click += new System.EventHandler(this.Zeton50_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(418, 261);
            this.Controls.Add(this.Zeton50);
            this.Controls.Add(this.Zeton25);
            this.Controls.Add(this.Zeton10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zeton10;
        private System.Windows.Forms.Button Zeton25;
        private System.Windows.Forms.Button Zeton50;
    }
}


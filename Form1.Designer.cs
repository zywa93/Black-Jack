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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Zeton10 = new System.Windows.Forms.Button();
            this.Zeton25 = new System.Windows.Forms.Button();
            this.Zeton50 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Zeton10
            // 
            this.Zeton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Zeton10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Zeton10.BackgroundImage")));
            this.Zeton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zeton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Zeton10.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.Zeton10.FlatAppearance.BorderSize = 0;
            this.Zeton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Zeton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zeton10.ForeColor = System.Drawing.Color.Transparent;
            this.Zeton10.Location = new System.Drawing.Point(52, 411);
            this.Zeton10.Name = "Zeton10";
            this.Zeton10.Size = new System.Drawing.Size(218, 142);
            this.Zeton10.TabIndex = 0;
            this.Zeton10.UseVisualStyleBackColor = false;
            this.Zeton10.Click += new System.EventHandler(this.Zeton10_Click);
            // 
            // Zeton25
            // 
            this.Zeton25.BackColor = System.Drawing.Color.Transparent;
            this.Zeton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Zeton25.BackgroundImage")));
            this.Zeton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zeton25.FlatAppearance.BorderSize = 0;
            this.Zeton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zeton25.ForeColor = System.Drawing.Color.Transparent;
            this.Zeton25.Location = new System.Drawing.Point(482, 411);
            this.Zeton25.Name = "Zeton25";
            this.Zeton25.Size = new System.Drawing.Size(218, 142);
            this.Zeton25.TabIndex = 1;
            this.Zeton25.UseVisualStyleBackColor = false;
            this.Zeton25.Click += new System.EventHandler(this.Zeton25_Click);
            // 
            // Zeton50
            // 
            this.Zeton50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Zeton50.BackgroundImage")));
            this.Zeton50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zeton50.FlatAppearance.BorderSize = 0;
            this.Zeton50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zeton50.Location = new System.Drawing.Point(965, 411);
            this.Zeton50.Name = "Zeton50";
            this.Zeton50.Size = new System.Drawing.Size(218, 142);
            this.Zeton50.TabIndex = 2;
            this.Zeton50.UseVisualStyleBackColor = true;
            this.Zeton50.Click += new System.EventHandler(this.Zeton50_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(360, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 137);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ile obstawiasz?";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1289, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zeton50);
            this.Controls.Add(this.Zeton25);
            this.Controls.Add(this.Zeton10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zeton25;
        private System.Windows.Forms.Button Zeton50;
        private System.Windows.Forms.Button Zeton10;
        private System.Windows.Forms.Label label1;
    }
}


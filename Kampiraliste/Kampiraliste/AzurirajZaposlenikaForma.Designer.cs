﻿namespace Kampiraliste
{
    partial class AzurirajZaposlenikaForma
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxKorIme = new System.Windows.Forms.TextBox();
            this.textBoxVrsta = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(97, 134);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(349, 22);
            this.textBoxIme.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(101, 180);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(290, 22);
            this.textBoxPrezime.TabIndex = 2;
            // 
            // textBoxKorIme
            // 
            this.textBoxKorIme.Location = new System.Drawing.Point(101, 228);
            this.textBoxKorIme.Name = "textBoxKorIme";
            this.textBoxKorIme.Size = new System.Drawing.Size(300, 22);
            this.textBoxKorIme.TabIndex = 3;
            // 
            // textBoxVrsta
            // 
            this.textBoxVrsta.Location = new System.Drawing.Point(100, 279);
            this.textBoxVrsta.Name = "textBoxVrsta";
            this.textBoxVrsta.Size = new System.Drawing.Size(300, 22);
            this.textBoxVrsta.TabIndex = 4;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(103, 321);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(296, 22);
            this.textBoxLozinka.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AzurirajZaposlenikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxVrsta);
            this.Controls.Add(this.textBoxKorIme);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBox1);
            this.Name = "AzurirajZaposlenikaForma";
            this.Text = "AzurirajZaposlenikaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxKorIme;
        private System.Windows.Forms.TextBox textBoxVrsta;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button button1;
    }
}
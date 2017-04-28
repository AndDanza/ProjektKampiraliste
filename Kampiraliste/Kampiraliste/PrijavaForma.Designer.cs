﻿namespace Kampiraliste
{
    partial class PrijavaForma
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
            this.components = new System.ComponentModel.Container();
            this.zapamtiMe = new System.Windows.Forms.CheckBox();
            this.korisnickoIme = new System.Windows.Forms.TextBox();
            this.lozinka = new System.Windows.Forms.TextBox();
            this.korisnickoImeLabela = new System.Windows.Forms.Label();
            this.lozinkaLabela = new System.Windows.Forms.Label();
            this.prijavaGumb = new System.Windows.Forms.Button();
            this.toolTipForHelpIcon = new System.Windows.Forms.ToolTip(this.components);
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.helpPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // zapamtiMe
            // 
            this.zapamtiMe.AutoSize = true;
            this.zapamtiMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zapamtiMe.ForeColor = System.Drawing.Color.Navy;
            this.zapamtiMe.Location = new System.Drawing.Point(301, 486);
            this.zapamtiMe.Name = "zapamtiMe";
            this.zapamtiMe.Size = new System.Drawing.Size(161, 33);
            this.zapamtiMe.TabIndex = 0;
            this.zapamtiMe.Text = "Zapamti me";
            this.zapamtiMe.UseVisualStyleBackColor = true;
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.korisnickoIme.Location = new System.Drawing.Point(301, 377);
            this.korisnickoIme.Multiline = true;
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(258, 28);
            this.korisnickoIme.TabIndex = 1;
            // 
            // lozinka
            // 
            this.lozinka.Location = new System.Drawing.Point(301, 428);
            this.lozinka.Multiline = true;
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(258, 29);
            this.lozinka.TabIndex = 2;
            // 
            // korisnickoImeLabela
            // 
            this.korisnickoImeLabela.AutoSize = true;
            this.korisnickoImeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoImeLabela.ForeColor = System.Drawing.Color.MidnightBlue;
            this.korisnickoImeLabela.Location = new System.Drawing.Point(91, 377);
            this.korisnickoImeLabela.Name = "korisnickoImeLabela";
            this.korisnickoImeLabela.Size = new System.Drawing.Size(178, 29);
            this.korisnickoImeLabela.TabIndex = 3;
            this.korisnickoImeLabela.Text = "Korisnicko ime:";
            // 
            // lozinkaLabela
            // 
            this.lozinkaLabela.AutoSize = true;
            this.lozinkaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaLabela.ForeColor = System.Drawing.Color.Navy;
            this.lozinkaLabela.Location = new System.Drawing.Point(171, 428);
            this.lozinkaLabela.Name = "lozinkaLabela";
            this.lozinkaLabela.Size = new System.Drawing.Size(101, 29);
            this.lozinkaLabela.TabIndex = 4;
            this.lozinkaLabela.Text = "Lozinka:";
            // 
            // prijavaGumb
            // 
            this.prijavaGumb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.prijavaGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijavaGumb.ForeColor = System.Drawing.Color.Black;
            this.prijavaGumb.Location = new System.Drawing.Point(96, 538);
            this.prijavaGumb.Name = "prijavaGumb";
            this.prijavaGumb.Size = new System.Drawing.Size(463, 54);
            this.prijavaGumb.TabIndex = 5;
            this.prijavaGumb.Text = "Prijava";
            this.prijavaGumb.UseVisualStyleBackColor = false;
            this.prijavaGumb.Click += new System.EventHandler(this.PrijaviMe);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = global::Kampiraliste.Properties.Resources.login_ic1;
            this.loginPictureBox.Location = new System.Drawing.Point(176, 16);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(265, 275);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loginPictureBox.TabIndex = 7;
            this.loginPictureBox.TabStop = false;
            // 
            // helpPictureBox
            // 
            this.helpPictureBox.Image = global::Kampiraliste.Properties.Resources.help_ic;
            this.helpPictureBox.Location = new System.Drawing.Point(10, 16);
            this.helpPictureBox.Name = "helpPictureBox";
            this.helpPictureBox.Size = new System.Drawing.Size(52, 49);
            this.helpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.helpPictureBox.TabIndex = 6;
            this.helpPictureBox.TabStop = false;
            this.helpPictureBox.Click += new System.EventHandler(this.helpPictureBox_Click);
            this.helpPictureBox.MouseHover += new System.EventHandler(this.helpPictureBox_MouseHover);
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(678, 658);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.helpPictureBox);
            this.Controls.Add(this.prijavaGumb);
            this.Controls.Add(this.lozinkaLabela);
            this.Controls.Add(this.korisnickoImeLabela);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korisnickoIme);
            this.Controls.Add(this.zapamtiMe);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PrijavaForma";
            this.ShowIcon = false;
            this.Text = "Prijava u sustav";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PrijavaForma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox zapamtiMe;
        private System.Windows.Forms.TextBox korisnickoIme;
        private System.Windows.Forms.TextBox lozinka;
        private System.Windows.Forms.Label korisnickoImeLabela;
        private System.Windows.Forms.Label lozinkaLabela;
        private System.Windows.Forms.Button prijavaGumb;
        private System.Windows.Forms.PictureBox helpPictureBox;
        private System.Windows.Forms.ToolTip toolTipForHelpIcon;
        private System.Windows.Forms.PictureBox loginPictureBox;
    }
}


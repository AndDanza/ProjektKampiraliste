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
            this.zapamtiMe.BackColor = System.Drawing.Color.Transparent;
            this.zapamtiMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zapamtiMe.ForeColor = System.Drawing.Color.Navy;
            this.zapamtiMe.Location = new System.Drawing.Point(226, 395);
            this.zapamtiMe.Margin = new System.Windows.Forms.Padding(2);
            this.zapamtiMe.Name = "zapamtiMe";
            this.zapamtiMe.Size = new System.Drawing.Size(128, 28);
            this.zapamtiMe.TabIndex = 0;
            this.zapamtiMe.Text = "Zapamti me";
            this.zapamtiMe.UseVisualStyleBackColor = false;
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.korisnickoIme.Location = new System.Drawing.Point(226, 306);
            this.korisnickoIme.Margin = new System.Windows.Forms.Padding(2);
            this.korisnickoIme.Multiline = true;
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(194, 24);
            this.korisnickoIme.TabIndex = 1;
            // 
            // lozinka
            // 
            this.lozinka.Location = new System.Drawing.Point(226, 348);
            this.lozinka.Margin = new System.Windows.Forms.Padding(2);
            this.lozinka.Multiline = true;
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(194, 24);
            this.lozinka.TabIndex = 2;
            // 
            // korisnickoImeLabela
            // 
            this.korisnickoImeLabela.AutoSize = true;
            this.korisnickoImeLabela.BackColor = System.Drawing.Color.Transparent;
            this.korisnickoImeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoImeLabela.ForeColor = System.Drawing.Color.MidnightBlue;
            this.korisnickoImeLabela.Location = new System.Drawing.Point(68, 306);
            this.korisnickoImeLabela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.korisnickoImeLabela.Name = "korisnickoImeLabela";
            this.korisnickoImeLabela.Size = new System.Drawing.Size(138, 24);
            this.korisnickoImeLabela.TabIndex = 3;
            this.korisnickoImeLabela.Text = "Korisnicko ime:";
            // 
            // lozinkaLabela
            // 
            this.lozinkaLabela.AutoSize = true;
            this.lozinkaLabela.BackColor = System.Drawing.Color.Transparent;
            this.lozinkaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaLabela.ForeColor = System.Drawing.Color.Navy;
            this.lozinkaLabela.Location = new System.Drawing.Point(128, 348);
            this.lozinkaLabela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lozinkaLabela.Name = "lozinkaLabela";
            this.lozinkaLabela.Size = new System.Drawing.Size(79, 24);
            this.lozinkaLabela.TabIndex = 4;
            this.lozinkaLabela.Text = "Lozinka:";
            // 
            // prijavaGumb
            // 
            this.prijavaGumb.BackColor = System.Drawing.Color.Tan;
            this.prijavaGumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prijavaGumb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prijavaGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijavaGumb.ForeColor = System.Drawing.Color.Black;
            this.prijavaGumb.Location = new System.Drawing.Point(73, 441);
            this.prijavaGumb.Margin = new System.Windows.Forms.Padding(2);
            this.prijavaGumb.Name = "prijavaGumb";
            this.prijavaGumb.Size = new System.Drawing.Size(347, 44);
            this.prijavaGumb.TabIndex = 5;
            this.prijavaGumb.Text = "Prijava";
            this.prijavaGumb.UseVisualStyleBackColor = false;
            this.prijavaGumb.Click += new System.EventHandler(this.PrijaviMe);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loginPictureBox.Image = global::Kampiraliste.Properties.Resources.login_ic;
            this.loginPictureBox.Location = new System.Drawing.Point(132, 13);
            this.loginPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(265, 275);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loginPictureBox.TabIndex = 7;
            this.loginPictureBox.TabStop = false;
            // 
            // helpPictureBox
            // 
            this.helpPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.helpPictureBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.helpPictureBox.Image = global::Kampiraliste.Properties.Resources.help_icon1;
            this.helpPictureBox.Location = new System.Drawing.Point(11, 13);
            this.helpPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.helpPictureBox.Name = "helpPictureBox";
            this.helpPictureBox.Size = new System.Drawing.Size(52, 48);
            this.helpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpPictureBox.TabIndex = 6;
            this.helpPictureBox.TabStop = false;
            this.helpPictureBox.Click += new System.EventHandler(this.helpPictureBox_Click);
            this.helpPictureBox.MouseHover += new System.EventHandler(this.helpPictureBox_MouseHover);
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.ClientSize = new System.Drawing.Size(508, 535);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.helpPictureBox);
            this.Controls.Add(this.prijavaGumb);
            this.Controls.Add(this.lozinkaLabela);
            this.Controls.Add(this.korisnickoImeLabela);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korisnickoIme);
            this.Controls.Add(this.zapamtiMe);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrijavaForma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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


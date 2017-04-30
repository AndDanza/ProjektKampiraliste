namespace Kampiraliste
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
            this.unosKorisnickoIme = new System.Windows.Forms.TextBox();
            this.unosLozinka = new System.Windows.Forms.TextBox();
            this.korisnickoImeLabela = new System.Windows.Forms.Label();
            this.lozinkaLabela = new System.Windows.Forms.Label();
            this.akcijaPrijava = new System.Windows.Forms.Button();
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
            this.zapamtiMe.ForeColor = System.Drawing.Color.Black;
            this.zapamtiMe.Location = new System.Drawing.Point(301, 464);
            this.zapamtiMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zapamtiMe.Name = "zapamtiMe";
            this.zapamtiMe.Size = new System.Drawing.Size(161, 33);
            this.zapamtiMe.TabIndex = 0;
            this.zapamtiMe.Text = "Zapamti me";
            this.zapamtiMe.UseVisualStyleBackColor = false;
            // 
            // unosKorisnickoIme
            // 
            this.unosKorisnickoIme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.unosKorisnickoIme.Location = new System.Drawing.Point(301, 377);
            this.unosKorisnickoIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unosKorisnickoIme.Multiline = true;
            this.unosKorisnickoIme.Name = "unosKorisnickoIme";
            this.unosKorisnickoIme.Size = new System.Drawing.Size(257, 29);
            this.unosKorisnickoIme.TabIndex = 1;
            // 
            // unosLozinka
            // 
            this.unosLozinka.Location = new System.Drawing.Point(301, 411);
            this.unosLozinka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unosLozinka.Multiline = true;
            this.unosLozinka.Name = "unosLozinka";
            this.unosLozinka.PasswordChar = '*';
            this.unosLozinka.Size = new System.Drawing.Size(257, 29);
            this.unosLozinka.TabIndex = 2;
            // 
            // korisnickoImeLabela
            // 
            this.korisnickoImeLabela.AutoSize = true;
            this.korisnickoImeLabela.BackColor = System.Drawing.Color.Transparent;
            this.korisnickoImeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoImeLabela.ForeColor = System.Drawing.Color.Black;
            this.korisnickoImeLabela.Location = new System.Drawing.Point(91, 377);
            this.korisnickoImeLabela.Name = "korisnickoImeLabela";
            this.korisnickoImeLabela.Size = new System.Drawing.Size(178, 29);
            this.korisnickoImeLabela.TabIndex = 3;
            this.korisnickoImeLabela.Text = "Korisnicko ime:";
            // 
            // lozinkaLabela
            // 
            this.lozinkaLabela.AutoSize = true;
            this.lozinkaLabela.BackColor = System.Drawing.Color.Transparent;
            this.lozinkaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaLabela.ForeColor = System.Drawing.Color.Black;
            this.lozinkaLabela.Location = new System.Drawing.Point(171, 411);
            this.lozinkaLabela.Name = "lozinkaLabela";
            this.lozinkaLabela.Size = new System.Drawing.Size(101, 29);
            this.lozinkaLabela.TabIndex = 4;
            this.lozinkaLabela.Text = "Lozinka:";
            // 
            // akcijaPrijava
            // 
            this.akcijaPrijava.BackColor = System.Drawing.Color.Peru;
            this.akcijaPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.akcijaPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.akcijaPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akcijaPrijava.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.akcijaPrijava.Location = new System.Drawing.Point(97, 519);
            this.akcijaPrijava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.akcijaPrijava.Name = "akcijaPrijava";
            this.akcijaPrijava.Size = new System.Drawing.Size(463, 54);
            this.akcijaPrijava.TabIndex = 5;
            this.akcijaPrijava.Text = "Prijava";
            this.akcijaPrijava.UseVisualStyleBackColor = false;
            this.akcijaPrijava.Click += new System.EventHandler(this.PrijaviMe);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loginPictureBox.Image = global::Kampiraliste.Properties.Resources.login_ic;
            this.loginPictureBox.Location = new System.Drawing.Point(176, 16);
            this.loginPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.helpPictureBox.Location = new System.Drawing.Point(15, 16);
            this.helpPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpPictureBox.Name = "helpPictureBox";
            this.helpPictureBox.Size = new System.Drawing.Size(69, 59);
            this.helpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.ClientSize = new System.Drawing.Size(677, 658);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.helpPictureBox);
            this.Controls.Add(this.akcijaPrijava);
            this.Controls.Add(this.lozinkaLabela);
            this.Controls.Add(this.korisnickoImeLabela);
            this.Controls.Add(this.unosLozinka);
            this.Controls.Add(this.unosKorisnickoIme);
            this.Controls.Add(this.zapamtiMe);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PrijavaForma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava u sustav eKamp";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PrijavaForma_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox zapamtiMe;
        private System.Windows.Forms.TextBox unosKorisnickoIme;
        private System.Windows.Forms.TextBox unosLozinka;
        private System.Windows.Forms.Label korisnickoImeLabela;
        private System.Windows.Forms.Label lozinkaLabela;
        private System.Windows.Forms.Button akcijaPrijava;
        private System.Windows.Forms.PictureBox helpPictureBox;
        private System.Windows.Forms.ToolTip toolTipForHelpIcon;
        private System.Windows.Forms.PictureBox loginPictureBox;
    }
}


namespace Kampiraliste
{
    partial class DodajZaposlenikaForma
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
            this.imeLabela = new System.Windows.Forms.Label();
            this.unosIme = new System.Windows.Forms.TextBox();
            this.prezimeLabela = new System.Windows.Forms.Label();
            this.unosPrezime = new System.Windows.Forms.TextBox();
            this.korImeLabela = new System.Windows.Forms.Label();
            this.unosKorIme = new System.Windows.Forms.TextBox();
            this.tipLabela = new System.Windows.Forms.Label();
            this.unosVrstaZaposlenika = new System.Windows.Forms.ComboBox();
            this.lozinkaLabela = new System.Windows.Forms.Label();
            this.unosLozinka = new System.Windows.Forms.TextBox();
            this.dodajZaposlenika = new System.Windows.Forms.Button();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabela
            // 
            this.imeLabela.AutoSize = true;
            this.imeLabela.BackColor = System.Drawing.Color.Transparent;
            this.imeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeLabela.Location = new System.Drawing.Point(52, 47);
            this.imeLabela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imeLabela.Name = "imeLabela";
            this.imeLabela.Size = new System.Drawing.Size(36, 18);
            this.imeLabela.TabIndex = 0;
            this.imeLabela.Text = "Ime:";
            // 
            // unosIme
            // 
            this.unosIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosIme.Location = new System.Drawing.Point(160, 41);
            this.unosIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unosIme.Multiline = true;
            this.unosIme.Name = "unosIme";
            this.unosIme.Size = new System.Drawing.Size(157, 26);
            this.unosIme.TabIndex = 1;
            // 
            // prezimeLabela
            // 
            this.prezimeLabela.AutoSize = true;
            this.prezimeLabela.BackColor = System.Drawing.Color.Transparent;
            this.prezimeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimeLabela.Location = new System.Drawing.Point(52, 92);
            this.prezimeLabela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prezimeLabela.Name = "prezimeLabela";
            this.prezimeLabela.Size = new System.Drawing.Size(67, 18);
            this.prezimeLabela.TabIndex = 2;
            this.prezimeLabela.Text = "Prezime:";
            // 
            // unosPrezime
            // 
            this.unosPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosPrezime.Location = new System.Drawing.Point(160, 84);
            this.unosPrezime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unosPrezime.Multiline = true;
            this.unosPrezime.Name = "unosPrezime";
            this.unosPrezime.Size = new System.Drawing.Size(157, 28);
            this.unosPrezime.TabIndex = 3;
            // 
            // korImeLabela
            // 
            this.korImeLabela.AutoSize = true;
            this.korImeLabela.BackColor = System.Drawing.Color.Transparent;
            this.korImeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korImeLabela.Location = new System.Drawing.Point(52, 133);
            this.korImeLabela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.korImeLabela.Name = "korImeLabela";
            this.korImeLabela.Size = new System.Drawing.Size(111, 18);
            this.korImeLabela.TabIndex = 4;
            this.korImeLabela.Text = "Korisnicko ime:";
            // 
            // unosKorIme
            // 
            this.unosKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosKorIme.Location = new System.Drawing.Point(160, 131);
            this.unosKorIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unosKorIme.Multiline = true;
            this.unosKorIme.Name = "unosKorIme";
            this.unosKorIme.Size = new System.Drawing.Size(157, 29);
            this.unosKorIme.TabIndex = 5;
            // 
            // tipLabela
            // 
            this.tipLabela.AutoSize = true;
            this.tipLabela.BackColor = System.Drawing.Color.Transparent;
            this.tipLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabela.Location = new System.Drawing.Point(52, 181);
            this.tipLabela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipLabela.Name = "tipLabela";
            this.tipLabela.Size = new System.Drawing.Size(32, 18);
            this.tipLabela.TabIndex = 6;
            this.tipLabela.Text = "Tip:";
            // 
            // unosVrstaZaposlenika
            // 
            this.unosVrstaZaposlenika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unosVrstaZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosVrstaZaposlenika.FormattingEnabled = true;
            this.unosVrstaZaposlenika.Location = new System.Drawing.Point(160, 176);
            this.unosVrstaZaposlenika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unosVrstaZaposlenika.Name = "unosVrstaZaposlenika";
            this.unosVrstaZaposlenika.Size = new System.Drawing.Size(74, 25);
            this.unosVrstaZaposlenika.TabIndex = 7;
            // 
            // lozinkaLabela
            // 
            this.lozinkaLabela.AutoSize = true;
            this.lozinkaLabela.BackColor = System.Drawing.Color.Transparent;
            this.lozinkaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaLabela.Location = new System.Drawing.Point(52, 214);
            this.lozinkaLabela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lozinkaLabela.Name = "lozinkaLabela";
            this.lozinkaLabela.Size = new System.Drawing.Size(64, 18);
            this.lozinkaLabela.TabIndex = 8;
            this.lozinkaLabela.Text = "Lozinka:";
            // 
            // unosLozinka
            // 
            this.unosLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosLozinka.Location = new System.Drawing.Point(160, 211);
            this.unosLozinka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unosLozinka.Multiline = true;
            this.unosLozinka.Name = "unosLozinka";
            this.unosLozinka.Size = new System.Drawing.Size(160, 26);
            this.unosLozinka.TabIndex = 9;
            // 
            // dodajZaposlenika
            // 
            this.dodajZaposlenika.BackColor = System.Drawing.Color.Peru;
            this.dodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dodajZaposlenika.Location = new System.Drawing.Point(55, 278);
            this.dodajZaposlenika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dodajZaposlenika.Name = "dodajZaposlenika";
            this.dodajZaposlenika.Size = new System.Drawing.Size(264, 39);
            this.dodajZaposlenika.TabIndex = 10;
            this.dodajZaposlenika.Text = "Dodaj";
            this.dodajZaposlenika.UseVisualStyleBackColor = false;
            this.dodajZaposlenika.Click += new System.EventHandler(this.dodajZaposlenika_Click);
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Kampiraliste.zaposlenik);
            // 
            // DodajZaposlenikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 337);
            this.Controls.Add(this.dodajZaposlenika);
            this.Controls.Add(this.unosLozinka);
            this.Controls.Add(this.lozinkaLabela);
            this.Controls.Add(this.unosVrstaZaposlenika);
            this.Controls.Add(this.tipLabela);
            this.Controls.Add(this.unosKorIme);
            this.Controls.Add(this.korImeLabela);
            this.Controls.Add(this.unosPrezime);
            this.Controls.Add(this.prezimeLabela);
            this.Controls.Add(this.unosIme);
            this.Controls.Add(this.imeLabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodajZaposlenikaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zaposlenika";
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imeLabela;
        private System.Windows.Forms.TextBox unosIme;
        private System.Windows.Forms.Label prezimeLabela;
        private System.Windows.Forms.TextBox unosPrezime;
        private System.Windows.Forms.Label korImeLabela;
        private System.Windows.Forms.TextBox unosKorIme;
        private System.Windows.Forms.Label tipLabela;
        private System.Windows.Forms.ComboBox unosVrstaZaposlenika;
        private System.Windows.Forms.Label lozinkaLabela;
        private System.Windows.Forms.TextBox unosLozinka;
        private System.Windows.Forms.Button dodajZaposlenika;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
    }
}
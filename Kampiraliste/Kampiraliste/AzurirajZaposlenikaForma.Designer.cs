namespace Kampiraliste
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
            this.components = new System.ComponentModel.Container();
            this.unosIme = new System.Windows.Forms.TextBox();
            this.unosPrezime = new System.Windows.Forms.TextBox();
            this.unosKorIme = new System.Windows.Forms.TextBox();
            this.unosVrsta = new System.Windows.Forms.TextBox();
            this.unosLozinka = new System.Windows.Forms.TextBox();
            this.spremiNovePodatke = new System.Windows.Forms.Button();
            this.imeLabela = new System.Windows.Forms.Label();
            this.prezimeLabela = new System.Windows.Forms.Label();
            this.korisnickoImeLabela = new System.Windows.Forms.Label();
            this.tipLabela = new System.Windows.Forms.Label();
            this.lozinkaLabela = new System.Windows.Forms.Label();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // unosIme
            // 
            this.unosIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosIme.Location = new System.Drawing.Point(221, 57);
            this.unosIme.Multiline = true;
            this.unosIme.Name = "unosIme";
            this.unosIme.Size = new System.Drawing.Size(232, 29);
            this.unosIme.TabIndex = 1;
            // 
            // unosPrezime
            // 
            this.unosPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosPrezime.Location = new System.Drawing.Point(221, 111);
            this.unosPrezime.Multiline = true;
            this.unosPrezime.Name = "unosPrezime";
            this.unosPrezime.Size = new System.Drawing.Size(232, 29);
            this.unosPrezime.TabIndex = 2;
            // 
            // unosKorIme
            // 
            this.unosKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosKorIme.Location = new System.Drawing.Point(221, 164);
            this.unosKorIme.Multiline = true;
            this.unosKorIme.Name = "unosKorIme";
            this.unosKorIme.Size = new System.Drawing.Size(232, 29);
            this.unosKorIme.TabIndex = 3;
            // 
            // unosVrsta
            // 
            this.unosVrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosVrsta.Location = new System.Drawing.Point(221, 217);
            this.unosVrsta.Multiline = true;
            this.unosVrsta.Name = "unosVrsta";
            this.unosVrsta.Size = new System.Drawing.Size(127, 29);
            this.unosVrsta.TabIndex = 4;
            // 
            // unosLozinka
            // 
            this.unosLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosLozinka.Location = new System.Drawing.Point(221, 271);
            this.unosLozinka.Multiline = true;
            this.unosLozinka.Name = "unosLozinka";
            this.unosLozinka.Size = new System.Drawing.Size(232, 29);
            this.unosLozinka.TabIndex = 5;
            // 
            // spremiNovePodatke
            // 
            this.spremiNovePodatke.BackColor = System.Drawing.Color.Peru;
            this.spremiNovePodatke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spremiNovePodatke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spremiNovePodatke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spremiNovePodatke.Location = new System.Drawing.Point(42, 334);
            this.spremiNovePodatke.Name = "spremiNovePodatke";
            this.spremiNovePodatke.Size = new System.Drawing.Size(411, 51);
            this.spremiNovePodatke.TabIndex = 6;
            this.spremiNovePodatke.Text = "Spremi";
            this.spremiNovePodatke.UseVisualStyleBackColor = false;
            this.spremiNovePodatke.Click += new System.EventHandler(this.spremiNovePodatke_Click);
            // 
            // imeLabela
            // 
            this.imeLabela.AutoSize = true;
            this.imeLabela.BackColor = System.Drawing.Color.Transparent;
            this.imeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeLabela.Location = new System.Drawing.Point(37, 57);
            this.imeLabela.Name = "imeLabela";
            this.imeLabela.Size = new System.Drawing.Size(59, 29);
            this.imeLabela.TabIndex = 7;
            this.imeLabela.Text = "Ime:";
            // 
            // prezimeLabela
            // 
            this.prezimeLabela.AutoSize = true;
            this.prezimeLabela.BackColor = System.Drawing.Color.Transparent;
            this.prezimeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimeLabela.Location = new System.Drawing.Point(37, 111);
            this.prezimeLabela.Name = "prezimeLabela";
            this.prezimeLabela.Size = new System.Drawing.Size(108, 29);
            this.prezimeLabela.TabIndex = 8;
            this.prezimeLabela.Text = "Prezime:";
            // 
            // korisnickoImeLabela
            // 
            this.korisnickoImeLabela.AutoSize = true;
            this.korisnickoImeLabela.BackColor = System.Drawing.Color.Transparent;
            this.korisnickoImeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoImeLabela.Location = new System.Drawing.Point(37, 164);
            this.korisnickoImeLabela.Name = "korisnickoImeLabela";
            this.korisnickoImeLabela.Size = new System.Drawing.Size(178, 29);
            this.korisnickoImeLabela.TabIndex = 9;
            this.korisnickoImeLabela.Text = "Korisnicko ime:";
            // 
            // tipLabela
            // 
            this.tipLabela.AutoSize = true;
            this.tipLabela.BackColor = System.Drawing.Color.Transparent;
            this.tipLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabela.Location = new System.Drawing.Point(41, 217);
            this.tipLabela.Name = "tipLabela";
            this.tipLabela.Size = new System.Drawing.Size(55, 29);
            this.tipLabela.TabIndex = 10;
            this.tipLabela.Text = "Tip:";
            // 
            // lozinkaLabela
            // 
            this.lozinkaLabela.AutoSize = true;
            this.lozinkaLabela.BackColor = System.Drawing.Color.Transparent;
            this.lozinkaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaLabela.Location = new System.Drawing.Point(41, 271);
            this.lozinkaLabela.Name = "lozinkaLabela";
            this.lozinkaLabela.Size = new System.Drawing.Size(101, 29);
            this.lozinkaLabela.TabIndex = 11;
            this.lozinkaLabela.Text = "Lozinka:";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Kampiraliste.zaposlenik);
            // 
            // AzurirajZaposlenikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 420);
            this.Controls.Add(this.lozinkaLabela);
            this.Controls.Add(this.tipLabela);
            this.Controls.Add(this.korisnickoImeLabela);
            this.Controls.Add(this.prezimeLabela);
            this.Controls.Add(this.imeLabela);
            this.Controls.Add(this.spremiNovePodatke);
            this.Controls.Add(this.unosLozinka);
            this.Controls.Add(this.unosVrsta);
            this.Controls.Add(this.unosKorIme);
            this.Controls.Add(this.unosPrezime);
            this.Controls.Add(this.unosIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AzurirajZaposlenikaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azuriraj zaposlenika";
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox unosIme;
        private System.Windows.Forms.TextBox unosPrezime;
        private System.Windows.Forms.TextBox unosKorIme;
        private System.Windows.Forms.TextBox unosVrsta;
        private System.Windows.Forms.TextBox unosLozinka;
        private System.Windows.Forms.Button spremiNovePodatke;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.Label imeLabela;
        private System.Windows.Forms.Label prezimeLabela;
        private System.Windows.Forms.Label korisnickoImeLabela;
        private System.Windows.Forms.Label tipLabela;
        private System.Windows.Forms.Label lozinkaLabela;
    }
}
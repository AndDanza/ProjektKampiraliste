namespace Kampiraliste
{
    partial class UnosSmjestajForma
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
            this.vrstaSmjestajaLabela = new System.Windows.Forms.Label();
            this.unosVrstaSmjestaja = new System.Windows.Forms.ComboBox();
            this.vrstasmjestajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unosParcele = new System.Windows.Forms.ComboBox();
            this.parcelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcelaLabela = new System.Windows.Forms.Label();
            this.brojOsobaLabela = new System.Windows.Forms.Label();
            this.unosBrojOsoba = new System.Windows.Forms.TextBox();
            this.naslovLabela = new System.Windows.Forms.Label();
            this.potvrdiUnosSmjestaja = new System.Windows.Forms.Button();
            this.unosOznakaSmjestaja = new System.Windows.Forms.TextBox();
            this.oznakaSmjestajaLabela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vrstasmjestajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vrstaSmjestajaLabela
            // 
            this.vrstaSmjestajaLabela.AutoSize = true;
            this.vrstaSmjestajaLabela.BackColor = System.Drawing.Color.Transparent;
            this.vrstaSmjestajaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrstaSmjestajaLabela.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vrstaSmjestajaLabela.Location = new System.Drawing.Point(40, 133);
            this.vrstaSmjestajaLabela.Name = "vrstaSmjestajaLabela";
            this.vrstaSmjestajaLabela.Size = new System.Drawing.Size(113, 18);
            this.vrstaSmjestajaLabela.TabIndex = 0;
            this.vrstaSmjestajaLabela.Text = "Vrsta smještaja:";
            // 
            // unosVrstaSmjestaja
            // 
            this.unosVrstaSmjestaja.DataSource = this.vrstasmjestajaBindingSource;
            this.unosVrstaSmjestaja.DisplayMember = "naziv";
            this.unosVrstaSmjestaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unosVrstaSmjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosVrstaSmjestaja.FormattingEnabled = true;
            this.unosVrstaSmjestaja.Location = new System.Drawing.Point(159, 130);
            this.unosVrstaSmjestaja.Name = "unosVrstaSmjestaja";
            this.unosVrstaSmjestaja.Size = new System.Drawing.Size(167, 26);
            this.unosVrstaSmjestaja.TabIndex = 1;
            this.unosVrstaSmjestaja.ValueMember = "id";
            // 
            // vrstasmjestajaBindingSource
            // 
            this.vrstasmjestajaBindingSource.DataSource = typeof(Kampiraliste.vrsta_smjestaja);
            // 
            // unosParcele
            // 
            this.unosParcele.DataSource = this.parcelaBindingSource;
            this.unosParcele.DisplayMember = "naziv";
            this.unosParcele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unosParcele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosParcele.FormattingEnabled = true;
            this.unosParcele.Location = new System.Drawing.Point(159, 173);
            this.unosParcele.Name = "unosParcele";
            this.unosParcele.Size = new System.Drawing.Size(167, 26);
            this.unosParcele.TabIndex = 3;
            this.unosParcele.ValueMember = "id";
            // 
            // parcelaBindingSource
            // 
            this.parcelaBindingSource.DataSource = typeof(Kampiraliste.parcela);
            // 
            // parcelaLabela
            // 
            this.parcelaLabela.AutoSize = true;
            this.parcelaLabela.BackColor = System.Drawing.Color.Transparent;
            this.parcelaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcelaLabela.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parcelaLabela.Location = new System.Drawing.Point(91, 176);
            this.parcelaLabela.Name = "parcelaLabela";
            this.parcelaLabela.Size = new System.Drawing.Size(62, 18);
            this.parcelaLabela.TabIndex = 2;
            this.parcelaLabela.Text = "Parcela:";
            // 
            // brojOsobaLabela
            // 
            this.brojOsobaLabela.AutoSize = true;
            this.brojOsobaLabela.BackColor = System.Drawing.Color.Transparent;
            this.brojOsobaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojOsobaLabela.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brojOsobaLabela.Location = new System.Drawing.Point(68, 259);
            this.brojOsobaLabela.Name = "brojOsobaLabela";
            this.brojOsobaLabela.Size = new System.Drawing.Size(85, 18);
            this.brojOsobaLabela.TabIndex = 4;
            this.brojOsobaLabela.Text = "Broj osoba:";
            // 
            // unosBrojOsoba
            // 
            this.unosBrojOsoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosBrojOsoba.Location = new System.Drawing.Point(159, 256);
            this.unosBrojOsoba.Name = "unosBrojOsoba";
            this.unosBrojOsoba.Size = new System.Drawing.Size(57, 24);
            this.unosBrojOsoba.TabIndex = 5;
            // 
            // naslovLabela
            // 
            this.naslovLabela.AutoSize = true;
            this.naslovLabela.BackColor = System.Drawing.Color.Transparent;
            this.naslovLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovLabela.Location = new System.Drawing.Point(76, 66);
            this.naslovLabela.Name = "naslovLabela";
            this.naslovLabela.Size = new System.Drawing.Size(191, 29);
            this.naslovLabela.TabIndex = 6;
            this.naslovLabela.Text = "Unos smještaja";
            // 
            // potvrdiUnosSmjestaja
            // 
            this.potvrdiUnosSmjestaja.BackColor = System.Drawing.Color.Peru;
            this.potvrdiUnosSmjestaja.Cursor = System.Windows.Forms.Cursors.Default;
            this.potvrdiUnosSmjestaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.potvrdiUnosSmjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potvrdiUnosSmjestaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.potvrdiUnosSmjestaja.Location = new System.Drawing.Point(94, 318);
            this.potvrdiUnosSmjestaja.Name = "potvrdiUnosSmjestaja";
            this.potvrdiUnosSmjestaja.Size = new System.Drawing.Size(173, 46);
            this.potvrdiUnosSmjestaja.TabIndex = 7;
            this.potvrdiUnosSmjestaja.Text = "Unesi smještaj";
            this.potvrdiUnosSmjestaja.UseVisualStyleBackColor = false;
            this.potvrdiUnosSmjestaja.Click += new System.EventHandler(this.potvrdiUnosSmjestaja_Click);
            // 
            // unosOznakaSmjestaja
            // 
            this.unosOznakaSmjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosOznakaSmjestaja.Location = new System.Drawing.Point(159, 217);
            this.unosOznakaSmjestaja.Name = "unosOznakaSmjestaja";
            this.unosOznakaSmjestaja.Size = new System.Drawing.Size(167, 24);
            this.unosOznakaSmjestaja.TabIndex = 9;
            // 
            // oznakaSmjestajaLabela
            // 
            this.oznakaSmjestajaLabela.AutoSize = true;
            this.oznakaSmjestajaLabela.BackColor = System.Drawing.Color.Transparent;
            this.oznakaSmjestajaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oznakaSmjestajaLabela.ForeColor = System.Drawing.SystemColors.ControlText;
            this.oznakaSmjestajaLabela.Location = new System.Drawing.Point(22, 220);
            this.oznakaSmjestajaLabela.Name = "oznakaSmjestajaLabela";
            this.oznakaSmjestajaLabela.Size = new System.Drawing.Size(131, 18);
            this.oznakaSmjestajaLabela.TabIndex = 8;
            this.oznakaSmjestajaLabela.Text = "Oznaka smještaja:";
            // 
            // UnosSmjestajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.ClientSize = new System.Drawing.Size(353, 526);
            this.Controls.Add(this.unosOznakaSmjestaja);
            this.Controls.Add(this.oznakaSmjestajaLabela);
            this.Controls.Add(this.potvrdiUnosSmjestaja);
            this.Controls.Add(this.naslovLabela);
            this.Controls.Add(this.unosBrojOsoba);
            this.Controls.Add(this.brojOsobaLabela);
            this.Controls.Add(this.unosParcele);
            this.Controls.Add(this.parcelaLabela);
            this.Controls.Add(this.unosVrstaSmjestaja);
            this.Controls.Add(this.vrstaSmjestajaLabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnosSmjestajForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnosSmjestajForma";
            this.Load += new System.EventHandler(this.UnosSmjestajForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vrstasmjestajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vrstaSmjestajaLabela;
        private System.Windows.Forms.ComboBox unosVrstaSmjestaja;
        private System.Windows.Forms.ComboBox unosParcele;
        private System.Windows.Forms.Label parcelaLabela;
        private System.Windows.Forms.Label brojOsobaLabela;
        private System.Windows.Forms.TextBox unosBrojOsoba;
        private System.Windows.Forms.Label naslovLabela;
        private System.Windows.Forms.Button potvrdiUnosSmjestaja;
        private System.Windows.Forms.BindingSource vrstasmjestajaBindingSource;
        private System.Windows.Forms.BindingSource parcelaBindingSource;
        private System.Windows.Forms.TextBox unosOznakaSmjestaja;
        private System.Windows.Forms.Label oznakaSmjestajaLabela;
    }
}
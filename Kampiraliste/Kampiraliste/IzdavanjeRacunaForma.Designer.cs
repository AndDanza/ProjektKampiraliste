namespace Kampiraliste
{
    partial class IzdavanjeRacunaForma
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
            this.parcelaLabela = new System.Windows.Forms.Label();
            this.gostiNaOdabranojParceli = new System.Windows.Forms.Label();
            this.odabraniGostiLabela = new System.Windows.Forms.Label();
            this.iznosRacunaLabela = new System.Windows.Forms.Label();
            this.ispisRacuna = new System.Windows.Forms.TextBox();
            this.akcijaKreirajRacun = new System.Windows.Forms.Button();
            this.smjestajLabela = new System.Windows.Forms.Label();
            this.ispisOznakeSmjestaja = new System.Windows.Forms.TextBox();
            this.odabirParcele = new System.Windows.Forms.ComboBox();
            this.parcelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispisSviGosti = new System.Windows.Forms.ListBox();
            this.prijavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispisOdabraniGosti = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.parcelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prijavaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // parcelaLabela
            // 
            this.parcelaLabela.AutoSize = true;
            this.parcelaLabela.BackColor = System.Drawing.Color.Transparent;
            this.parcelaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parcelaLabela.Location = new System.Drawing.Point(30, 35);
            this.parcelaLabela.Name = "parcelaLabela";
            this.parcelaLabela.Size = new System.Drawing.Size(60, 17);
            this.parcelaLabela.TabIndex = 0;
            this.parcelaLabela.Text = "Parcela:";
            // 
            // gostiNaOdabranojParceli
            // 
            this.gostiNaOdabranojParceli.AutoSize = true;
            this.gostiNaOdabranojParceli.BackColor = System.Drawing.Color.Transparent;
            this.gostiNaOdabranojParceli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gostiNaOdabranojParceli.Location = new System.Drawing.Point(294, 10);
            this.gostiNaOdabranojParceli.Name = "gostiNaOdabranojParceli";
            this.gostiNaOdabranojParceli.Size = new System.Drawing.Size(183, 17);
            this.gostiNaOdabranojParceli.TabIndex = 3;
            this.gostiNaOdabranojParceli.Text = "Gosti na odabranoj parceli: ";
            // 
            // odabraniGostiLabela
            // 
            this.odabraniGostiLabela.AutoSize = true;
            this.odabraniGostiLabela.BackColor = System.Drawing.Color.Transparent;
            this.odabraniGostiLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabraniGostiLabela.Location = new System.Drawing.Point(294, 177);
            this.odabraniGostiLabela.Name = "odabraniGostiLabela";
            this.odabraniGostiLabela.Size = new System.Drawing.Size(105, 17);
            this.odabraniGostiLabela.TabIndex = 9;
            this.odabraniGostiLabela.Text = "Odabrani gosti:";
            // 
            // iznosRacunaLabela
            // 
            this.iznosRacunaLabela.AutoSize = true;
            this.iznosRacunaLabela.BackColor = System.Drawing.Color.Transparent;
            this.iznosRacunaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iznosRacunaLabela.Location = new System.Drawing.Point(28, 208);
            this.iznosRacunaLabela.Name = "iznosRacunaLabela";
            this.iznosRacunaLabela.Size = new System.Drawing.Size(143, 25);
            this.iznosRacunaLabela.TabIndex = 11;
            this.iznosRacunaLabela.Text = "Iznos računa:";
            // 
            // ispisRacuna
            // 
            this.ispisRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ispisRacuna.Location = new System.Drawing.Point(177, 210);
            this.ispisRacuna.Name = "ispisRacuna";
            this.ispisRacuna.ReadOnly = true;
            this.ispisRacuna.Size = new System.Drawing.Size(88, 24);
            this.ispisRacuna.TabIndex = 10;
            // 
            // akcijaKreirajRacun
            // 
            this.akcijaKreirajRacun.BackColor = System.Drawing.Color.Peru;
            this.akcijaKreirajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.akcijaKreirajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.akcijaKreirajRacun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.akcijaKreirajRacun.Location = new System.Drawing.Point(12, 263);
            this.akcijaKreirajRacun.Name = "akcijaKreirajRacun";
            this.akcijaKreirajRacun.Size = new System.Drawing.Size(265, 55);
            this.akcijaKreirajRacun.TabIndex = 12;
            this.akcijaKreirajRacun.Text = "Kreiraj račun";
            this.akcijaKreirajRacun.UseVisualStyleBackColor = false;
            this.akcijaKreirajRacun.Click += new System.EventHandler(this.akcijaKreirajRacun_Click);
            // 
            // smjestajLabela
            // 
            this.smjestajLabela.AutoSize = true;
            this.smjestajLabela.BackColor = System.Drawing.Color.Transparent;
            this.smjestajLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smjestajLabela.Location = new System.Drawing.Point(30, 71);
            this.smjestajLabela.Name = "smjestajLabela";
            this.smjestajLabela.Size = new System.Drawing.Size(124, 17);
            this.smjestajLabela.TabIndex = 16;
            this.smjestajLabela.Text = "Oznaka smještaja:";
            // 
            // ispisOznakeSmjestaja
            // 
            this.ispisOznakeSmjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ispisOznakeSmjestaja.Location = new System.Drawing.Point(33, 91);
            this.ispisOznakeSmjestaja.Name = "ispisOznakeSmjestaja";
            this.ispisOznakeSmjestaja.ReadOnly = true;
            this.ispisOznakeSmjestaja.Size = new System.Drawing.Size(222, 24);
            this.ispisOznakeSmjestaja.TabIndex = 15;
            // 
            // odabirParcele
            // 
            this.odabirParcele.DataSource = this.parcelaBindingSource;
            this.odabirParcele.DisplayMember = "naziv";
            this.odabirParcele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabirParcele.FormattingEnabled = true;
            this.odabirParcele.Location = new System.Drawing.Point(96, 30);
            this.odabirParcele.Name = "odabirParcele";
            this.odabirParcele.Size = new System.Drawing.Size(154, 26);
            this.odabirParcele.TabIndex = 17;
            this.odabirParcele.ValueMember = "id";
            this.odabirParcele.SelectedIndexChanged += new System.EventHandler(this.odabirParcele_SelectedIndexChanged);
            // 
            // parcelaBindingSource
            // 
            this.parcelaBindingSource.DataSource = typeof(Kampiraliste.parcela);
            // 
            // ispisSviGosti
            // 
            this.ispisSviGosti.FormattingEnabled = true;
            this.ispisSviGosti.Location = new System.Drawing.Point(297, 30);
            this.ispisSviGosti.Name = "ispisSviGosti";
            this.ispisSviGosti.Size = new System.Drawing.Size(348, 121);
            this.ispisSviGosti.TabIndex = 18;
            this.ispisSviGosti.DoubleClick += new System.EventHandler(this.ispisSviGosti_DoubleClick);
            // 
            // prijavaBindingSource
            // 
            this.prijavaBindingSource.DataSource = typeof(Kampiraliste.prijava);
            // 
            // ispisOdabraniGosti
            // 
            this.ispisOdabraniGosti.FormattingEnabled = true;
            this.ispisOdabraniGosti.Location = new System.Drawing.Point(297, 197);
            this.ispisOdabraniGosti.Name = "ispisOdabraniGosti";
            this.ispisOdabraniGosti.Size = new System.Drawing.Size(348, 121);
            this.ispisOdabraniGosti.TabIndex = 19;
            this.ispisOdabraniGosti.DoubleClick += new System.EventHandler(this.ispisOdabraniGosti_DoubleClick);
            // 
            // IzdavanjeRacunaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 342);
            this.Controls.Add(this.ispisOdabraniGosti);
            this.Controls.Add(this.ispisSviGosti);
            this.Controls.Add(this.odabirParcele);
            this.Controls.Add(this.smjestajLabela);
            this.Controls.Add(this.ispisOznakeSmjestaja);
            this.Controls.Add(this.akcijaKreirajRacun);
            this.Controls.Add(this.iznosRacunaLabela);
            this.Controls.Add(this.ispisRacuna);
            this.Controls.Add(this.odabraniGostiLabela);
            this.Controls.Add(this.gostiNaOdabranojParceli);
            this.Controls.Add(this.parcelaLabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "IzdavanjeRacunaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavanje računa";
            this.Load += new System.EventHandler(this.IzdavanjeRacunaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parcelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prijavaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label parcelaLabela;
        private System.Windows.Forms.Label gostiNaOdabranojParceli;
        private System.Windows.Forms.Label odabraniGostiLabela;
        private System.Windows.Forms.Label iznosRacunaLabela;
        private System.Windows.Forms.TextBox ispisRacuna;
        private System.Windows.Forms.Button akcijaKreirajRacun;
        private System.Windows.Forms.Label smjestajLabela;
        private System.Windows.Forms.TextBox ispisOznakeSmjestaja;
        private System.Windows.Forms.ComboBox odabirParcele;
        private System.Windows.Forms.BindingSource parcelaBindingSource;
        private System.Windows.Forms.ListBox ispisSviGosti;
        private System.Windows.Forms.BindingSource prijavaBindingSource;
        private System.Windows.Forms.ListBox ispisOdabraniGosti;
    }
}
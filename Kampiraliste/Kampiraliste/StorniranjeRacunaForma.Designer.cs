namespace Kampiraliste
{
    partial class StorniranjeRacunaForma
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
            this.akcijaStornirajRacun = new System.Windows.Forms.Button();
            this.izdaniRacuniLabela = new System.Windows.Forms.Label();
            this.ispisIzdanihRacuna = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smjestajidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preostalozaplatitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijavaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smjestajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ispisIzdanihRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // akcijaStornirajRacun
            // 
            this.akcijaStornirajRacun.BackColor = System.Drawing.Color.Peru;
            this.akcijaStornirajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.akcijaStornirajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.akcijaStornirajRacun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.akcijaStornirajRacun.Location = new System.Drawing.Point(328, 303);
            this.akcijaStornirajRacun.Name = "akcijaStornirajRacun";
            this.akcijaStornirajRacun.Size = new System.Drawing.Size(385, 44);
            this.akcijaStornirajRacun.TabIndex = 0;
            this.akcijaStornirajRacun.Text = "Storniraj račun";
            this.akcijaStornirajRacun.UseVisualStyleBackColor = false;
            this.akcijaStornirajRacun.Click += new System.EventHandler(this.akcijaStornirajRacun_Click);
            // 
            // izdaniRacuniLabela
            // 
            this.izdaniRacuniLabela.AutoSize = true;
            this.izdaniRacuniLabela.BackColor = System.Drawing.Color.Transparent;
            this.izdaniRacuniLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izdaniRacuniLabela.Location = new System.Drawing.Point(28, 29);
            this.izdaniRacuniLabela.Name = "izdaniRacuniLabela";
            this.izdaniRacuniLabela.Size = new System.Drawing.Size(92, 17);
            this.izdaniRacuniLabela.TabIndex = 2;
            this.izdaniRacuniLabela.Text = "Izdani racuni:";
            // 
            // ispisIzdanihRacuna
            // 
            this.ispisIzdanihRacuna.AllowUserToAddRows = false;
            this.ispisIzdanihRacuna.AllowUserToDeleteRows = false;
            this.ispisIzdanihRacuna.AutoGenerateColumns = false;
            this.ispisIzdanihRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ispisIzdanihRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.smjestajidDataGridViewTextBoxColumn,
            this.jIRDataGridViewTextBoxColumn,
            this.zIRDataGridViewTextBoxColumn,
            this.preostalozaplatitDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn,
            this.prijavaidDataGridViewTextBoxColumn,
            this.smjestajDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.prijavaDataGridViewTextBoxColumn});
            this.ispisIzdanihRacuna.DataSource = this.racunBindingSource;
            this.ispisIzdanihRacuna.Location = new System.Drawing.Point(31, 59);
            this.ispisIzdanihRacuna.Name = "ispisIzdanihRacuna";
            this.ispisIzdanihRacuna.ReadOnly = true;
            this.ispisIzdanihRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ispisIzdanihRacuna.Size = new System.Drawing.Size(944, 214);
            this.ispisIzdanihRacuna.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            this.zaposlenikidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smjestajidDataGridViewTextBoxColumn
            // 
            this.smjestajidDataGridViewTextBoxColumn.DataPropertyName = "smjestaj_id";
            this.smjestajidDataGridViewTextBoxColumn.HeaderText = "smjestaj_id";
            this.smjestajidDataGridViewTextBoxColumn.Name = "smjestajidDataGridViewTextBoxColumn";
            this.smjestajidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jIRDataGridViewTextBoxColumn
            // 
            this.jIRDataGridViewTextBoxColumn.DataPropertyName = "JIR";
            this.jIRDataGridViewTextBoxColumn.HeaderText = "JIR";
            this.jIRDataGridViewTextBoxColumn.Name = "jIRDataGridViewTextBoxColumn";
            this.jIRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zIRDataGridViewTextBoxColumn
            // 
            this.zIRDataGridViewTextBoxColumn.DataPropertyName = "ZIR";
            this.zIRDataGridViewTextBoxColumn.HeaderText = "ZIR";
            this.zIRDataGridViewTextBoxColumn.Name = "zIRDataGridViewTextBoxColumn";
            this.zIRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preostalozaplatitDataGridViewTextBoxColumn
            // 
            this.preostalozaplatitDataGridViewTextBoxColumn.DataPropertyName = "preostalo_za_platit";
            this.preostalozaplatitDataGridViewTextBoxColumn.HeaderText = "preostalo_za_platit";
            this.preostalozaplatitDataGridViewTextBoxColumn.Name = "preostalozaplatitDataGridViewTextBoxColumn";
            this.preostalozaplatitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            this.iznosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumvrijemeizdavanjaDataGridViewTextBoxColumn
            // 
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn.DataPropertyName = "datum_vrijeme_izdavanja";
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn.HeaderText = "datum_vrijeme_izdavanja";
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn.Name = "datumvrijemeizdavanjaDataGridViewTextBoxColumn";
            this.datumvrijemeizdavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prijavaidDataGridViewTextBoxColumn
            // 
            this.prijavaidDataGridViewTextBoxColumn.DataPropertyName = "prijava_id";
            this.prijavaidDataGridViewTextBoxColumn.HeaderText = "prijava_id";
            this.prijavaidDataGridViewTextBoxColumn.Name = "prijavaidDataGridViewTextBoxColumn";
            this.prijavaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smjestajDataGridViewTextBoxColumn
            // 
            this.smjestajDataGridViewTextBoxColumn.DataPropertyName = "smjestaj";
            this.smjestajDataGridViewTextBoxColumn.HeaderText = "smjestaj";
            this.smjestajDataGridViewTextBoxColumn.Name = "smjestajDataGridViewTextBoxColumn";
            this.smjestajDataGridViewTextBoxColumn.ReadOnly = true;
            this.smjestajDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // prijavaDataGridViewTextBoxColumn
            // 
            this.prijavaDataGridViewTextBoxColumn.DataPropertyName = "prijava";
            this.prijavaDataGridViewTextBoxColumn.HeaderText = "prijava";
            this.prijavaDataGridViewTextBoxColumn.Name = "prijavaDataGridViewTextBoxColumn";
            this.prijavaDataGridViewTextBoxColumn.ReadOnly = true;
            this.prijavaDataGridViewTextBoxColumn.Visible = false;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(Kampiraliste.racun);
            // 
            // StorniranjeRacunaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 379);
            this.Controls.Add(this.ispisIzdanihRacuna);
            this.Controls.Add(this.izdaniRacuniLabela);
            this.Controls.Add(this.akcijaStornirajRacun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StorniranjeRacunaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storniranje računa";
            this.Load += new System.EventHandler(this.StorniranjeRacunaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ispisIzdanihRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button akcijaStornirajRacun;
        private System.Windows.Forms.Label izdaniRacuniLabela;
        private System.Windows.Forms.DataGridView ispisIzdanihRacuna;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smjestajidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preostalozaplatitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeizdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijavaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smjestajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijavaDataGridViewTextBoxColumn;
    }
}
namespace Kampiraliste
{
    partial class ZaposleniciForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dodajNovogZaposlenika = new System.Windows.Forms.Button();
            this.azurirajZaposlenika = new System.Windows.Forms.Button();
            this.obrisiZaposlenika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zaposlenikDataBinding = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstazaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijavasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikDataBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajNovogZaposlenika
            // 
            this.dodajNovogZaposlenika.BackColor = System.Drawing.Color.Peru;
            this.dodajNovogZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajNovogZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajNovogZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dodajNovogZaposlenika.Location = new System.Drawing.Point(12, 12);
            this.dodajNovogZaposlenika.Name = "dodajNovogZaposlenika";
            this.dodajNovogZaposlenika.Size = new System.Drawing.Size(256, 65);
            this.dodajNovogZaposlenika.TabIndex = 1;
            this.dodajNovogZaposlenika.Text = "Dodaj novog zaposlenika";
            this.dodajNovogZaposlenika.UseVisualStyleBackColor = false;
            this.dodajNovogZaposlenika.Click += new System.EventHandler(this.dodajNovogZaposlenika_Click);
            // 
            // azurirajZaposlenika
            // 
            this.azurirajZaposlenika.BackColor = System.Drawing.Color.Peru;
            this.azurirajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.azurirajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azurirajZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.azurirajZaposlenika.Location = new System.Drawing.Point(553, 12);
            this.azurirajZaposlenika.Name = "azurirajZaposlenika";
            this.azurirajZaposlenika.Size = new System.Drawing.Size(277, 65);
            this.azurirajZaposlenika.TabIndex = 2;
            this.azurirajZaposlenika.Text = "Ažuriraj zaposlenika";
            this.azurirajZaposlenika.UseVisualStyleBackColor = false;
            this.azurirajZaposlenika.Click += new System.EventHandler(this.azurirajZaposlenika_Click);
            // 
            // obrisiZaposlenika
            // 
            this.obrisiZaposlenika.BackColor = System.Drawing.Color.Peru;
            this.obrisiZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.obrisiZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.obrisiZaposlenika.Location = new System.Drawing.Point(274, 12);
            this.obrisiZaposlenika.Name = "obrisiZaposlenika";
            this.obrisiZaposlenika.Size = new System.Drawing.Size(273, 65);
            this.obrisiZaposlenika.TabIndex = 3;
            this.obrisiZaposlenika.Text = "Obriši zaposlenika";
            this.obrisiZaposlenika.UseVisualStyleBackColor = false;
            this.obrisiZaposlenika.Click += new System.EventHandler(this.obrisiZaposlenika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(333, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zaposlenici";
            // 
            // zaposlenikDataBinding
            // 
            this.zaposlenikDataBinding.AllowUserToAddRows = false;
            this.zaposlenikDataBinding.AllowUserToDeleteRows = false;
            this.zaposlenikDataBinding.AutoGenerateColumns = false;
            this.zaposlenikDataBinding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zaposlenikDataBinding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposlenikDataBinding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.vrstazaposlenikaDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.prijavasDataGridViewTextBoxColumn,
            this.racunsDataGridViewTextBoxColumn});
            this.zaposlenikDataBinding.DataSource = this.zaposlenikBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.zaposlenikDataBinding.DefaultCellStyle = dataGridViewCellStyle7;
            this.zaposlenikDataBinding.Location = new System.Drawing.Point(45, 167);
            this.zaposlenikDataBinding.Name = "zaposlenikDataBinding";
            this.zaposlenikDataBinding.ReadOnly = true;
            this.zaposlenikDataBinding.RowTemplate.Height = 24;
            this.zaposlenikDataBinding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zaposlenikDataBinding.Size = new System.Drawing.Size(749, 308);
            this.zaposlenikDataBinding.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.FillWeight = 85.27919F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.imeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.imeDataGridViewTextBoxColumn.FillWeight = 102.9442F;
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.prezimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.prezimeDataGridViewTextBoxColumn.FillWeight = 102.9442F;
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.korisnickoimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.korisnickoimeDataGridViewTextBoxColumn.FillWeight = 102.9442F;
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisnicko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstazaposlenikaDataGridViewTextBoxColumn
            // 
            this.vrstazaposlenikaDataGridViewTextBoxColumn.DataPropertyName = "vrsta_zaposlenika";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.vrstazaposlenikaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.vrstazaposlenikaDataGridViewTextBoxColumn.FillWeight = 102.9442F;
            this.vrstazaposlenikaDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.vrstazaposlenikaDataGridViewTextBoxColumn.Name = "vrstazaposlenikaDataGridViewTextBoxColumn";
            this.vrstazaposlenikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.lozinkaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.lozinkaDataGridViewTextBoxColumn.FillWeight = 102.9442F;
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prijavasDataGridViewTextBoxColumn
            // 
            this.prijavasDataGridViewTextBoxColumn.DataPropertyName = "prijavas";
            this.prijavasDataGridViewTextBoxColumn.HeaderText = "prijavas";
            this.prijavasDataGridViewTextBoxColumn.Name = "prijavasDataGridViewTextBoxColumn";
            this.prijavasDataGridViewTextBoxColumn.ReadOnly = true;
            this.prijavasDataGridViewTextBoxColumn.Visible = false;
            // 
            // racunsDataGridViewTextBoxColumn
            // 
            this.racunsDataGridViewTextBoxColumn.DataPropertyName = "racuns";
            this.racunsDataGridViewTextBoxColumn.HeaderText = "racuns";
            this.racunsDataGridViewTextBoxColumn.Name = "racunsDataGridViewTextBoxColumn";
            this.racunsDataGridViewTextBoxColumn.ReadOnly = true;
            this.racunsDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(Kampiraliste.zaposlenik);
            // 
            // ZaposleniciForma
            // 
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 551);
            this.Controls.Add(this.zaposlenikDataBinding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obrisiZaposlenika);
            this.Controls.Add(this.azurirajZaposlenika);
            this.Controls.Add(this.dodajNovogZaposlenika);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ZaposleniciForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikDataBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dodajNovogZaposlenika;
        private System.Windows.Forms.Button azurirajZaposlenika;
        private System.Windows.Forms.Button obrisiZaposlenika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView zaposlenikDataBinding;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstazaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijavasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunsDataGridViewTextBoxColumn;
    }
}
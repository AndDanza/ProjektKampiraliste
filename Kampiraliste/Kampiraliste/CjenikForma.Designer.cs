namespace Kampiraliste
{
    partial class CjenikForma
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
            this.dodajNoviCjenik = new System.Windows.Forms.Button();
            this.azurirajCjenik = new System.Windows.Forms.Button();
            this.obrisiCjenik = new System.Windows.Forms.Button();
            this.cjenikBindingSource = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstasmjestajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naslovLabela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstasmjestajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajNoviCjenik
            // 
            this.dodajNoviCjenik.BackColor = System.Drawing.Color.Peru;
            this.dodajNoviCjenik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajNoviCjenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajNoviCjenik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dodajNoviCjenik.Location = new System.Drawing.Point(38, 206);
            this.dodajNoviCjenik.Name = "dodajNoviCjenik";
            this.dodajNoviCjenik.Size = new System.Drawing.Size(233, 70);
            this.dodajNoviCjenik.TabIndex = 0;
            this.dodajNoviCjenik.Text = "Dodaj novi cjenik";
            this.dodajNoviCjenik.UseVisualStyleBackColor = false;
            this.dodajNoviCjenik.Click += new System.EventHandler(this.dodajNoviCjenik_Click);
            // 
            // azurirajCjenik
            // 
            this.azurirajCjenik.BackColor = System.Drawing.Color.Peru;
            this.azurirajCjenik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.azurirajCjenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azurirajCjenik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.azurirajCjenik.Location = new System.Drawing.Point(38, 311);
            this.azurirajCjenik.Name = "azurirajCjenik";
            this.azurirajCjenik.Size = new System.Drawing.Size(233, 64);
            this.azurirajCjenik.TabIndex = 1;
            this.azurirajCjenik.Text = "Ažuriraj cjenik";
            this.azurirajCjenik.UseVisualStyleBackColor = false;
            this.azurirajCjenik.Click += new System.EventHandler(this.azurirajCjenik_Click);
            // 
            // obrisiCjenik
            // 
            this.obrisiCjenik.BackColor = System.Drawing.Color.Peru;
            this.obrisiCjenik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.obrisiCjenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiCjenik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.obrisiCjenik.Location = new System.Drawing.Point(38, 112);
            this.obrisiCjenik.Name = "obrisiCjenik";
            this.obrisiCjenik.Size = new System.Drawing.Size(233, 66);
            this.obrisiCjenik.TabIndex = 2;
            this.obrisiCjenik.Text = "Obriši cjenik";
            this.obrisiCjenik.UseVisualStyleBackColor = false;
            this.obrisiCjenik.Click += new System.EventHandler(this.obrisiCjenik_Click);
            // 
            // cjenikBindingSource
            // 
            this.cjenikBindingSource.AllowUserToAddRows = false;
            this.cjenikBindingSource.AllowUserToDeleteRows = false;
            this.cjenikBindingSource.AutoGenerateColumns = false;
            this.cjenikBindingSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cjenikBindingSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cjenikBindingSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.iznos});
            this.cjenikBindingSource.DataSource = this.vrstasmjestajaBindingSource;
            this.cjenikBindingSource.Location = new System.Drawing.Point(307, 112);
            this.cjenikBindingSource.Name = "cjenikBindingSource";
            this.cjenikBindingSource.ReadOnly = true;
            this.cjenikBindingSource.RowTemplate.Height = 24;
            this.cjenikBindingSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cjenikBindingSource.Size = new System.Drawing.Size(388, 263);
            this.cjenikBindingSource.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznos
            // 
            this.iznos.DataPropertyName = "iznos";
            this.iznos.HeaderText = "iznos";
            this.iznos.Name = "iznos";
            this.iznos.ReadOnly = true;
            // 
            // vrstasmjestajaBindingSource
            // 
            this.vrstasmjestajaBindingSource.DataSource = typeof(Kampiraliste.vrsta_smjestaja);
            // 
            // naslovLabela
            // 
            this.naslovLabela.AutoSize = true;
            this.naslovLabela.BackColor = System.Drawing.Color.Transparent;
            this.naslovLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovLabela.ForeColor = System.Drawing.Color.Black;
            this.naslovLabela.Location = new System.Drawing.Point(301, 32);
            this.naslovLabela.Name = "naslovLabela";
            this.naslovLabela.Size = new System.Drawing.Size(104, 36);
            this.naslovLabela.TabIndex = 4;
            this.naslovLabela.Text = "Cjenik";
            // 
            // CjenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 415);
            this.Controls.Add(this.naslovLabela);
            this.Controls.Add(this.cjenikBindingSource);
            this.Controls.Add(this.obrisiCjenik);
            this.Controls.Add(this.azurirajCjenik);
            this.Controls.Add(this.dodajNoviCjenik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CjenikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cjenik";
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstasmjestajaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajNoviCjenik;
        private System.Windows.Forms.Button azurirajCjenik;
        private System.Windows.Forms.Button obrisiCjenik;
        private System.Windows.Forms.DataGridView cjenikBindingSource;
        private System.Windows.Forms.BindingSource vrstasmjestajaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
        private System.Windows.Forms.Label naslovLabela;
    }
}
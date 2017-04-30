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
            this.zaposlenikBindingSource = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposlenikBindingSource.Location = new System.Drawing.Point(24, 198);
            this.zaposlenikBindingSource.Name = "zaposlenikBindingSource";
            this.zaposlenikBindingSource.RowTemplate.Height = 24;
            this.zaposlenikBindingSource.Size = new System.Drawing.Size(1291, 332);
            this.zaposlenikBindingSource.TabIndex = 0;
            // 
            // ZaposleniciForma
            // 
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1335, 551);
            this.Controls.Add(this.zaposlenikBindingSource);
            this.Name = "ZaposleniciForma";
            this.Text = "Zaposlenici";
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zaposlenikBindingSource;
    }
}
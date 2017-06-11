namespace Kampiraliste
{
    partial class KnjigaGostijuForma
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
        /// <param name="straniGost">Određuje iz kojeg data set-a i binding source-a dolaze podaci. True 
        /// je za strane goste, false za domaće.</param>
        private void InitializeComponent(bool straniGost)
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KnjigaDomacihGostijuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kampiralisteDataSet = new Kampiraliste.kampiralisteDataSet();
            this.pregledKnjigeGostiju = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KnjigaDomacihGostijuTableAdapter = new Kampiraliste.kampiralisteDataSetTableAdapters.KnjigaDomacihGostijuTableAdapter();
            this.KnjigaStranihGostijuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KnjigaStranihGostijuTableAdapter = new Kampiraliste.kampiralisteDataSetTableAdapters.KnjigaStranihGostijuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KnjigaDomacihGostijuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnjigaStranihGostijuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kampiralisteDataSet)).BeginInit();     
            this.SuspendLayout();
            // 
            // KnjigaDomacihGostijuBindingSource
            // 
            this.KnjigaDomacihGostijuBindingSource.DataMember = "KnjigaDomacihGostiju";
            this.KnjigaDomacihGostijuBindingSource.DataSource = this.kampiralisteDataSet;
            // 
            // kampiralisteDataSet
            // 
            this.kampiralisteDataSet.DataSetName = "kampiralisteDataSet";
            this.kampiralisteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pregledKnjigeGostiju
            //
            if (!straniGost)
            {
                //ako je strani gost false postavi data set z domaće i postavi binging source
                reportDataSource1.Name = "domaciGostiDataSet";
                reportDataSource1.Value = this.KnjigaDomacihGostijuBindingSource;
                this.pregledKnjigeGostiju.LocalReport.DataSources.Add(reportDataSource1);
                this.pregledKnjigeGostiju.LocalReport.ReportEmbeddedResource = "Kampiraliste.DomaciGostiReport.rdlc";
            }
            else
            {
                reportDataSource1.Name = "straniGostiDataSet";
                reportDataSource1.Value = this.KnjigaStranihGostijuBindingSource;
                this.pregledKnjigeGostiju.LocalReport.DataSources.Add(reportDataSource1);
                this.pregledKnjigeGostiju.LocalReport.ReportEmbeddedResource = "Kampiraliste.StraniGostiReport.rdlc";
            }
            this.pregledKnjigeGostiju.Location = new System.Drawing.Point(0, 0);
            this.pregledKnjigeGostiju.Name = "pregledKnjigeGostiju";
            this.pregledKnjigeGostiju.Size = new System.Drawing.Size(1167, 559);
            this.pregledKnjigeGostiju.TabIndex = 0;
            // 
            // KnjigaDomacihGostijuTableAdapter
            // 
            this.KnjigaDomacihGostijuTableAdapter.ClearBeforeFill = true;
            // 
            // KnjigaStranihGostijuBindingSource
            // 
            this.KnjigaStranihGostijuBindingSource.DataMember = "KnjigaStranihGostiju";
            this.KnjigaStranihGostijuBindingSource.DataSource = this.kampiralisteDataSet;
            // 
            // KnjigaStranihGostijuTableAdapter
            // 
            this.KnjigaStranihGostijuTableAdapter.ClearBeforeFill = true;
            // 
            // KnjigaGostijuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 552);
            this.Controls.Add(this.pregledKnjigeGostiju);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "KnjigaGostijuForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KnjigaGostijuForma";
            this.Load += new System.EventHandler(this.KnjigaGostijuForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KnjigaDomacihGostijuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kampiralisteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KnjigaStranihGostijuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer pregledKnjigeGostiju;
        private System.Windows.Forms.BindingSource KnjigaDomacihGostijuBindingSource;
        private kampiralisteDataSet kampiralisteDataSet;
        private kampiralisteDataSetTableAdapters.KnjigaDomacihGostijuTableAdapter KnjigaDomacihGostijuTableAdapter;
        private System.Windows.Forms.BindingSource KnjigaStranihGostijuBindingSource;
        private kampiralisteDataSetTableAdapters.KnjigaStranihGostijuTableAdapter KnjigaStranihGostijuTableAdapter;
    }
}
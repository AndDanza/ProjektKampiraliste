namespace Kampiraliste
{
    partial class PrikazStatistikeForma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.unosDatumaZaPrikazStatistike = new System.Windows.Forms.DateTimePicker();
            this.prikazGostijuPremaDatumuLabela = new System.Windows.Forms.Label();
            this.ispisStatDatumGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prikazGostijuPremaDrzaviLabela = new System.Windows.Forms.Label();
            this.ispisStatDrzaveGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.odabirDrzaveZaPrikazStatistike = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ispisStatDatumGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispisStatDrzaveGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // unosDatumaZaPrikazStatistike
            // 
            this.unosDatumaZaPrikazStatistike.Location = new System.Drawing.Point(353, 33);
            this.unosDatumaZaPrikazStatistike.Name = "unosDatumaZaPrikazStatistike";
            this.unosDatumaZaPrikazStatistike.Size = new System.Drawing.Size(191, 20);
            this.unosDatumaZaPrikazStatistike.TabIndex = 0;
            // 
            // prikazGostijuPremaDatumuLabela
            // 
            this.prikazGostijuPremaDatumuLabela.AutoSize = true;
            this.prikazGostijuPremaDatumuLabela.BackColor = System.Drawing.Color.Transparent;
            this.prikazGostijuPremaDatumuLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazGostijuPremaDatumuLabela.Location = new System.Drawing.Point(84, 30);
            this.prikazGostijuPremaDatumuLabela.Name = "prikazGostijuPremaDatumuLabela";
            this.prikazGostijuPremaDatumuLabela.Size = new System.Drawing.Size(263, 25);
            this.prikazGostijuPremaDatumuLabela.TabIndex = 2;
            this.prikazGostijuPremaDatumuLabela.Text = "Prikaz gostiju prema datumu:";
            // 
            // ispisStatDatumGraf
            // 
            chartArea1.Name = "ChartArea1";
            this.ispisStatDatumGraf.ChartAreas.Add(chartArea1);
            this.ispisStatDatumGraf.Location = new System.Drawing.Point(38, 73);
            this.ispisStatDatumGraf.Name = "ispisStatDatumGraf";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.IndianRed;
            series1.Name = "Series1";
            this.ispisStatDatumGraf.Series.Add(series1);
            this.ispisStatDatumGraf.Size = new System.Drawing.Size(593, 256);
            this.ispisStatDatumGraf.TabIndex = 3;
            this.ispisStatDatumGraf.Text = "chart1";
            // 
            // prikazGostijuPremaDrzaviLabela
            // 
            this.prikazGostijuPremaDrzaviLabela.AutoSize = true;
            this.prikazGostijuPremaDrzaviLabela.BackColor = System.Drawing.Color.Transparent;
            this.prikazGostijuPremaDrzaviLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazGostijuPremaDrzaviLabela.Location = new System.Drawing.Point(84, 354);
            this.prikazGostijuPremaDrzaviLabela.Name = "prikazGostijuPremaDrzaviLabela";
            this.prikazGostijuPremaDrzaviLabela.Size = new System.Drawing.Size(250, 25);
            this.prikazGostijuPremaDrzaviLabela.TabIndex = 4;
            this.prikazGostijuPremaDrzaviLabela.Text = "Prikaz gostiju prema državi:";
            // 
            // ispisStatDrzaveGraf
            // 
            chartArea2.Name = "ChartArea1";
            this.ispisStatDrzaveGraf.ChartAreas.Add(chartArea2);
            this.ispisStatDrzaveGraf.Location = new System.Drawing.Point(38, 399);
            this.ispisStatDrzaveGraf.Name = "ispisStatDrzaveGraf";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.IndianRed;
            series2.Name = "Series1";
            this.ispisStatDrzaveGraf.Series.Add(series2);
            this.ispisStatDrzaveGraf.Size = new System.Drawing.Size(593, 256);
            this.ispisStatDrzaveGraf.TabIndex = 5;
            this.ispisStatDrzaveGraf.Text = "chart2";
            // 
            // odabirDrzaveZaPrikazStatistike
            // 
            this.odabirDrzaveZaPrikazStatistike.FormattingEnabled = true;
            this.odabirDrzaveZaPrikazStatistike.Location = new System.Drawing.Point(353, 358);
            this.odabirDrzaveZaPrikazStatistike.Name = "odabirDrzaveZaPrikazStatistike";
            this.odabirDrzaveZaPrikazStatistike.Size = new System.Drawing.Size(191, 21);
            this.odabirDrzaveZaPrikazStatistike.TabIndex = 6;
            // 
            // PrikazStatistikeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 676);
            this.Controls.Add(this.odabirDrzaveZaPrikazStatistike);
            this.Controls.Add(this.ispisStatDrzaveGraf);
            this.Controls.Add(this.prikazGostijuPremaDrzaviLabela);
            this.Controls.Add(this.ispisStatDatumGraf);
            this.Controls.Add(this.prikazGostijuPremaDatumuLabela);
            this.Controls.Add(this.unosDatumaZaPrikazStatistike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PrikazStatistikeForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrikazStatistike";
            ((System.ComponentModel.ISupportInitialize)(this.ispisStatDatumGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispisStatDrzaveGraf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker unosDatumaZaPrikazStatistike;
        private System.Windows.Forms.Label prikazGostijuPremaDatumuLabela;
        private System.Windows.Forms.DataVisualization.Charting.Chart ispisStatDatumGraf;
        private System.Windows.Forms.Label prikazGostijuPremaDrzaviLabela;
        private System.Windows.Forms.DataVisualization.Charting.Chart ispisStatDrzaveGraf;
        private System.Windows.Forms.ComboBox odabirDrzaveZaPrikazStatistike;
    }
}
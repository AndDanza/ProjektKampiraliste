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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.unosDatumaZaPrikazStatistike = new System.Windows.Forms.DateTimePicker();
            this.prikazGostijuPremaDatumuLabela = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prikazGostijuPremaDrzaviLabela = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.odabirDrzaveZaPrikazStatistike = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // unosDatumaZaPrikazStatistike
            // 
            this.unosDatumaZaPrikazStatistike.Location = new System.Drawing.Point(406, 34);
            this.unosDatumaZaPrikazStatistike.Name = "unosDatumaZaPrikazStatistike";
            this.unosDatumaZaPrikazStatistike.Size = new System.Drawing.Size(191, 20);
            this.unosDatumaZaPrikazStatistike.TabIndex = 0;
            // 
            // prikazGostijuPremaDatumuLabela
            // 
            this.prikazGostijuPremaDatumuLabela.AutoSize = true;
            this.prikazGostijuPremaDatumuLabela.BackColor = System.Drawing.Color.Transparent;
            this.prikazGostijuPremaDatumuLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazGostijuPremaDatumuLabela.Location = new System.Drawing.Point(137, 31);
            this.prikazGostijuPremaDatumuLabela.Name = "prikazGostijuPremaDatumuLabela";
            this.prikazGostijuPremaDatumuLabela.Size = new System.Drawing.Size(263, 25);
            this.prikazGostijuPremaDatumuLabela.TabIndex = 2;
            this.prikazGostijuPremaDatumuLabela.Text = "Prikaz gostiju prema datumu:";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(91, 74);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.IndianRed;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(593, 256);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // prikazGostijuPremaDrzaviLabela
            // 
            this.prikazGostijuPremaDrzaviLabela.AutoSize = true;
            this.prikazGostijuPremaDrzaviLabela.BackColor = System.Drawing.Color.Transparent;
            this.prikazGostijuPremaDrzaviLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazGostijuPremaDrzaviLabela.Location = new System.Drawing.Point(137, 355);
            this.prikazGostijuPremaDrzaviLabela.Name = "prikazGostijuPremaDrzaviLabela";
            this.prikazGostijuPremaDrzaviLabela.Size = new System.Drawing.Size(250, 25);
            this.prikazGostijuPremaDrzaviLabela.TabIndex = 4;
            this.prikazGostijuPremaDrzaviLabela.Text = "Prikaz gostiju prema državi:";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.Location = new System.Drawing.Point(91, 397);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.IndianRed;
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(593, 256);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // odabirDrzaveZaPrikazStatistike
            // 
            this.odabirDrzaveZaPrikazStatistike.FormattingEnabled = true;
            this.odabirDrzaveZaPrikazStatistike.Location = new System.Drawing.Point(406, 359);
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
            this.ClientSize = new System.Drawing.Size(764, 720);
            this.Controls.Add(this.odabirDrzaveZaPrikazStatistike);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.prikazGostijuPremaDrzaviLabela);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.prikazGostijuPremaDatumuLabela);
            this.Controls.Add(this.unosDatumaZaPrikazStatistike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PrikazStatistikeForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrikazStatistike";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker unosDatumaZaPrikazStatistike;
        private System.Windows.Forms.Label prikazGostijuPremaDatumuLabela;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label prikazGostijuPremaDrzaviLabela;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox odabirDrzaveZaPrikazStatistike;
    }
}
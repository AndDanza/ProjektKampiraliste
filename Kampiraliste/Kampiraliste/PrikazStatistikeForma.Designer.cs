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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.prikazGostijuPremaDatumuLabela = new System.Windows.Forms.Label();
            this.ispisStatDatumGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prikazGostijuPremaParceliLabela = new System.Windows.Forms.Label();
            this.ispisStatParceleGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.drzavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unosDatumFiltiranja = new System.Windows.Forms.TextBox();
            this.akcijaPrikaziStatPoDatumu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ispisStatDatumGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispisStatParceleGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzavaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            series1.BorderColor = System.Drawing.Color.Firebrick;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.IndianRed;
            series1.IsXValueIndexed = true;
            series1.Name = "prikazBrojGostiju";
            this.ispisStatDatumGraf.Series.Add(series1);
            this.ispisStatDatumGraf.Size = new System.Drawing.Size(593, 256);
            this.ispisStatDatumGraf.TabIndex = 3;
            this.ispisStatDatumGraf.Text = "chart1";
            // 
            // prikazGostijuPremaParceliLabela
            // 
            this.prikazGostijuPremaParceliLabela.AutoSize = true;
            this.prikazGostijuPremaParceliLabela.BackColor = System.Drawing.Color.Transparent;
            this.prikazGostijuPremaParceliLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazGostijuPremaParceliLabela.Location = new System.Drawing.Point(231, 361);
            this.prikazGostijuPremaParceliLabela.Name = "prikazGostijuPremaParceliLabela";
            this.prikazGostijuPremaParceliLabela.Size = new System.Drawing.Size(255, 25);
            this.prikazGostijuPremaParceliLabela.TabIndex = 4;
            this.prikazGostijuPremaParceliLabela.Text = "Prikaz gostiju prema parceli:";
            // 
            // ispisStatParceleGraf
            // 
            chartArea2.Name = "ChartArea1";
            this.ispisStatParceleGraf.ChartAreas.Add(chartArea2);
            this.ispisStatParceleGraf.Location = new System.Drawing.Point(38, 399);
            this.ispisStatParceleGraf.Name = "ispisStatParceleGraf";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.IndianRed;
            series2.IsXValueIndexed = true;
            series2.Name = "prikazPoParceli";
            this.ispisStatParceleGraf.Series.Add(series2);
            this.ispisStatParceleGraf.Size = new System.Drawing.Size(593, 256);
            this.ispisStatParceleGraf.TabIndex = 5;
            this.ispisStatParceleGraf.Text = "chart2";
            // 
            // drzavaBindingSource
            // 
            this.drzavaBindingSource.DataSource = typeof(Kampiraliste.drzava);
            // 
            // unosDatumFiltiranja
            // 
            this.unosDatumFiltiranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosDatumFiltiranja.Location = new System.Drawing.Point(353, 30);
            this.unosDatumFiltiranja.Name = "unosDatumFiltiranja";
            this.unosDatumFiltiranja.Size = new System.Drawing.Size(173, 24);
            this.unosDatumFiltiranja.TabIndex = 7;
            this.unosDatumFiltiranja.Leave += new System.EventHandler(this.unosDatumFiltiranja_Leave);
            // 
            // akcijaPrikaziStatPoDatumu
            // 
            this.akcijaPrikaziStatPoDatumu.Location = new System.Drawing.Point(544, 25);
            this.akcijaPrikaziStatPoDatumu.Name = "akcijaPrikaziStatPoDatumu";
            this.akcijaPrikaziStatPoDatumu.Size = new System.Drawing.Size(87, 36);
            this.akcijaPrikaziStatPoDatumu.TabIndex = 8;
            this.akcijaPrikaziStatPoDatumu.Text = "Prikaži";
            this.akcijaPrikaziStatPoDatumu.UseVisualStyleBackColor = true;
            this.akcijaPrikaziStatPoDatumu.Click += new System.EventHandler(this.akcijaPrikaziStatPoDatumu_Click);
            // 
            // PrikazStatistikeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 676);
            this.Controls.Add(this.akcijaPrikaziStatPoDatumu);
            this.Controls.Add(this.unosDatumFiltiranja);
            this.Controls.Add(this.ispisStatParceleGraf);
            this.Controls.Add(this.prikazGostijuPremaParceliLabela);
            this.Controls.Add(this.ispisStatDatumGraf);
            this.Controls.Add(this.prikazGostijuPremaDatumuLabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PrikazStatistikeForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrikazStatistike";
            this.Load += new System.EventHandler(this.PrikazStatistikeForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ispisStatDatumGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispisStatParceleGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drzavaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label prikazGostijuPremaDatumuLabela;
        private System.Windows.Forms.DataVisualization.Charting.Chart ispisStatDatumGraf;
        private System.Windows.Forms.Label prikazGostijuPremaParceliLabela;
        private System.Windows.Forms.DataVisualization.Charting.Chart ispisStatParceleGraf;
        private System.Windows.Forms.TextBox unosDatumFiltiranja;
        private System.Windows.Forms.Button akcijaPrikaziStatPoDatumu;
        private System.Windows.Forms.BindingSource drzavaBindingSource;
    }
}
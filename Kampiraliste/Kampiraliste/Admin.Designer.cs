namespace Kampiraliste
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.zaposleniciLista = new System.Windows.Forms.ListBox();
            this.ucitajZaposlenike = new System.Windows.Forms.Button();
            this.tablicaZaposlenika = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "admin";
            // 
            // zaposleniciLista
            // 
            this.zaposleniciLista.FormattingEnabled = true;
            this.zaposleniciLista.ItemHeight = 16;
            this.zaposleniciLista.Location = new System.Drawing.Point(14, 362);
            this.zaposleniciLista.Name = "zaposleniciLista";
            this.zaposleniciLista.Size = new System.Drawing.Size(705, 100);
            this.zaposleniciLista.TabIndex = 1;
            // 
            // ucitajZaposlenike
            // 
            this.ucitajZaposlenike.Location = new System.Drawing.Point(357, 29);
            this.ucitajZaposlenike.Name = "ucitajZaposlenike";
            this.ucitajZaposlenike.Size = new System.Drawing.Size(267, 55);
            this.ucitajZaposlenike.TabIndex = 2;
            this.ucitajZaposlenike.Text = "Ucitaj zaposlenike";
            this.ucitajZaposlenike.UseVisualStyleBackColor = true;
            this.ucitajZaposlenike.Click += new System.EventHandler(this.UcitajZaposlenike);
            // 
            // tablicaZaposlenika
            // 
            this.tablicaZaposlenika.ColumnCount = 5;
            this.tablicaZaposlenika.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablicaZaposlenika.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablicaZaposlenika.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablicaZaposlenika.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablicaZaposlenika.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablicaZaposlenika.Location = new System.Drawing.Point(19, 132);
            this.tablicaZaposlenika.Name = "tablicaZaposlenika";
            this.tablicaZaposlenika.RowCount = 1;
            this.tablicaZaposlenika.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablicaZaposlenika.Size = new System.Drawing.Size(695, 202);
            this.tablicaZaposlenika.TabIndex = 3;
            this.tablicaZaposlenika.Paint += new System.Windows.Forms.PaintEventHandler(this.tablicaZaposlenika_Paint);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 481);
            this.Controls.Add(this.tablicaZaposlenika);
            this.Controls.Add(this.ucitajZaposlenike);
            this.Controls.Add(this.zaposleniciLista);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "UrediRadnika";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox zaposleniciLista;
        private System.Windows.Forms.Button ucitajZaposlenike;
        private System.Windows.Forms.TableLayoutPanel tablicaZaposlenika;
    }
}
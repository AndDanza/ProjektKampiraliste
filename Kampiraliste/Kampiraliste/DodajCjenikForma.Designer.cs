namespace Kampiraliste
{
    partial class DodajCjenikForma
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
            this.unosNaziv = new System.Windows.Forms.TextBox();
            this.unosCijena = new System.Windows.Forms.TextBox();
            this.nazivLabela = new System.Windows.Forms.Label();
            this.cijenaLabela = new System.Windows.Forms.Label();
            this.dodajNoviCjenik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unosNaziv
            // 
            this.unosNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosNaziv.Location = new System.Drawing.Point(150, 89);
            this.unosNaziv.Name = "unosNaziv";
            this.unosNaziv.Size = new System.Drawing.Size(238, 28);
            this.unosNaziv.TabIndex = 0;
            // 
            // unosCijena
            // 
            this.unosCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosCijena.Location = new System.Drawing.Point(150, 132);
            this.unosCijena.Name = "unosCijena";
            this.unosCijena.Size = new System.Drawing.Size(238, 28);
            this.unosCijena.TabIndex = 1;
            // 
            // nazivLabela
            // 
            this.nazivLabela.AutoSize = true;
            this.nazivLabela.BackColor = System.Drawing.Color.Transparent;
            this.nazivLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivLabela.Location = new System.Drawing.Point(62, 89);
            this.nazivLabela.Name = "nazivLabela";
            this.nazivLabela.Size = new System.Drawing.Size(61, 24);
            this.nazivLabela.TabIndex = 2;
            this.nazivLabela.Text = "Naziv:";
            // 
            // cijenaLabela
            // 
            this.cijenaLabela.AutoSize = true;
            this.cijenaLabela.BackColor = System.Drawing.Color.Transparent;
            this.cijenaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cijenaLabela.Location = new System.Drawing.Point(62, 132);
            this.cijenaLabela.Name = "cijenaLabela";
            this.cijenaLabela.Size = new System.Drawing.Size(68, 24);
            this.cijenaLabela.TabIndex = 3;
            this.cijenaLabela.Text = "Cijena:";
            // 
            // dodajNoviCjenik
            // 
            this.dodajNoviCjenik.BackColor = System.Drawing.Color.Peru;
            this.dodajNoviCjenik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajNoviCjenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajNoviCjenik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dodajNoviCjenik.Location = new System.Drawing.Point(66, 205);
            this.dodajNoviCjenik.Name = "dodajNoviCjenik";
            this.dodajNoviCjenik.Size = new System.Drawing.Size(322, 46);
            this.dodajNoviCjenik.TabIndex = 4;
            this.dodajNoviCjenik.Text = "Dodaj";
            this.dodajNoviCjenik.UseVisualStyleBackColor = false;
            this.dodajNoviCjenik.Click += new System.EventHandler(this.dodajNoviCjenik_Click);
            // 
            // DodajCjenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 320);
            this.Controls.Add(this.dodajNoviCjenik);
            this.Controls.Add(this.cijenaLabela);
            this.Controls.Add(this.nazivLabela);
            this.Controls.Add(this.unosCijena);
            this.Controls.Add(this.unosNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DodajCjenikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajCjenikForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosNaziv;
        private System.Windows.Forms.TextBox unosCijena;
        private System.Windows.Forms.Label nazivLabela;
        private System.Windows.Forms.Label cijenaLabela;
        private System.Windows.Forms.Button dodajNoviCjenik;
    }
}
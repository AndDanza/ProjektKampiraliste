namespace Kampiraliste
{
    partial class RadSPrijavamaForma
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
            this.listaAktivnihPrijavaBox = new System.Windows.Forms.ListBox();
            this.filtrirajLabela = new System.Windows.Forms.Label();
            this.unosOdlazak = new System.Windows.Forms.RadioButton();
            this.unosDolazak = new System.Windows.Forms.RadioButton();
            this.akcijaFiltriraj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaAktivnihPrijavaBox
            // 
            this.listaAktivnihPrijavaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaAktivnihPrijavaBox.FormattingEnabled = true;
            this.listaAktivnihPrijavaBox.ItemHeight = 18;
            this.listaAktivnihPrijavaBox.Location = new System.Drawing.Point(32, 129);
            this.listaAktivnihPrijavaBox.Name = "listaAktivnihPrijavaBox";
            this.listaAktivnihPrijavaBox.ScrollAlwaysVisible = true;
            this.listaAktivnihPrijavaBox.Size = new System.Drawing.Size(372, 382);
            this.listaAktivnihPrijavaBox.TabIndex = 0;
            // 
            // filtrirajLabela
            // 
            this.filtrirajLabela.AutoSize = true;
            this.filtrirajLabela.BackColor = System.Drawing.Color.Transparent;
            this.filtrirajLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrirajLabela.Location = new System.Drawing.Point(53, 38);
            this.filtrirajLabela.Name = "filtrirajLabela";
            this.filtrirajLabela.Size = new System.Drawing.Size(101, 18);
            this.filtrirajLabela.TabIndex = 1;
            this.filtrirajLabela.Text = "Filtriraj prijave:";
            // 
            // unosOdlazak
            // 
            this.unosOdlazak.AutoSize = true;
            this.unosOdlazak.BackColor = System.Drawing.Color.Transparent;
            this.unosOdlazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosOdlazak.Location = new System.Drawing.Point(257, 36);
            this.unosOdlazak.Name = "unosOdlazak";
            this.unosOdlazak.Size = new System.Drawing.Size(81, 22);
            this.unosOdlazak.TabIndex = 17;
            this.unosOdlazak.TabStop = true;
            this.unosOdlazak.Text = "Odlazak";
            this.unosOdlazak.UseVisualStyleBackColor = false;
            // 
            // unosDolazak
            // 
            this.unosDolazak.AutoSize = true;
            this.unosDolazak.BackColor = System.Drawing.Color.Transparent;
            this.unosDolazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosDolazak.Location = new System.Drawing.Point(160, 36);
            this.unosDolazak.Name = "unosDolazak";
            this.unosDolazak.Size = new System.Drawing.Size(81, 22);
            this.unosDolazak.TabIndex = 16;
            this.unosDolazak.TabStop = true;
            this.unosDolazak.Text = "Dolazak";
            this.unosDolazak.UseVisualStyleBackColor = false;
            // 
            // akcijaFiltriraj
            // 
            this.akcijaFiltriraj.BackColor = System.Drawing.Color.Peru;
            this.akcijaFiltriraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.akcijaFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akcijaFiltriraj.Location = new System.Drawing.Point(83, 74);
            this.akcijaFiltriraj.Name = "akcijaFiltriraj";
            this.akcijaFiltriraj.Size = new System.Drawing.Size(96, 38);
            this.akcijaFiltriraj.TabIndex = 18;
            this.akcijaFiltriraj.Text = "Filtriraj";
            this.akcijaFiltriraj.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Resetiraj";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RadSPrijavamaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.ClientSize = new System.Drawing.Size(946, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.akcijaFiltriraj);
            this.Controls.Add(this.unosOdlazak);
            this.Controls.Add(this.unosDolazak);
            this.Controls.Add(this.filtrirajLabela);
            this.Controls.Add(this.listaAktivnihPrijavaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RadSPrijavamaForma";
            this.Text = "RadSPrijavamaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaAktivnihPrijavaBox;
        private System.Windows.Forms.Label filtrirajLabela;
        private System.Windows.Forms.RadioButton unosOdlazak;
        private System.Windows.Forms.RadioButton unosDolazak;
        private System.Windows.Forms.Button akcijaFiltriraj;
        private System.Windows.Forms.Button button1;
    }
}
namespace Kampiraliste
{
    partial class AzurirajCjenikForma
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
            this.spremiPromjene = new System.Windows.Forms.Button();
            this.nazivLabel = new System.Windows.Forms.Label();
            this.cijenaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unosNaziv
            // 
            this.unosNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosNaziv.Location = new System.Drawing.Point(157, 57);
            this.unosNaziv.Name = "unosNaziv";
            this.unosNaziv.Size = new System.Drawing.Size(218, 28);
            this.unosNaziv.TabIndex = 0;
            // 
            // unosCijena
            // 
            this.unosCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosCijena.Location = new System.Drawing.Point(157, 110);
            this.unosCijena.Name = "unosCijena";
            this.unosCijena.Size = new System.Drawing.Size(218, 28);
            this.unosCijena.TabIndex = 1;
            // 
            // spremiPromjene
            // 
            this.spremiPromjene.BackColor = System.Drawing.Color.Peru;
            this.spremiPromjene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spremiPromjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spremiPromjene.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spremiPromjene.Location = new System.Drawing.Point(48, 171);
            this.spremiPromjene.Name = "spremiPromjene";
            this.spremiPromjene.Size = new System.Drawing.Size(327, 43);
            this.spremiPromjene.TabIndex = 2;
            this.spremiPromjene.Text = "Spremi";
            this.spremiPromjene.UseVisualStyleBackColor = false;
            this.spremiPromjene.Click += new System.EventHandler(this.spremiPromjene_Click);
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.BackColor = System.Drawing.Color.Transparent;
            this.nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivLabel.Location = new System.Drawing.Point(44, 60);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(61, 24);
            this.nazivLabel.TabIndex = 3;
            this.nazivLabel.Text = "Naziv:";
            // 
            // cijenaLabel
            // 
            this.cijenaLabel.AutoSize = true;
            this.cijenaLabel.BackColor = System.Drawing.Color.Transparent;
            this.cijenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cijenaLabel.Location = new System.Drawing.Point(44, 113);
            this.cijenaLabel.Name = "cijenaLabel";
            this.cijenaLabel.Size = new System.Drawing.Size(68, 24);
            this.cijenaLabel.TabIndex = 4;
            this.cijenaLabel.Text = "Cijena:";
            // 
            // AzurirajCjenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 274);
            this.Controls.Add(this.cijenaLabel);
            this.Controls.Add(this.nazivLabel);
            this.Controls.Add(this.spremiPromjene);
            this.Controls.Add(this.unosCijena);
            this.Controls.Add(this.unosNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AzurirajCjenikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AzurirajCjenikForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosNaziv;
        private System.Windows.Forms.TextBox unosCijena;
        private System.Windows.Forms.Button spremiPromjene;
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.Label cijenaLabel;
    }
}
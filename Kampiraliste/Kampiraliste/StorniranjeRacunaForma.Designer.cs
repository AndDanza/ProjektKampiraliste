namespace Kampiraliste
{
    partial class StorniranjeRacunaForma
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
            this.akcijaStornirajRacun = new System.Windows.Forms.Button();
            this.ispisIzdaniRacuni = new System.Windows.Forms.ListBox();
            this.izdaniRacuniLabela = new System.Windows.Forms.Label();
            this.podaciORacunuLabela = new System.Windows.Forms.Label();
            this.ispisPodaciORacunu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // akcijaStornirajRacun
            // 
            this.akcijaStornirajRacun.BackColor = System.Drawing.Color.Peru;
            this.akcijaStornirajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.akcijaStornirajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.akcijaStornirajRacun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.akcijaStornirajRacun.Location = new System.Drawing.Point(367, 292);
            this.akcijaStornirajRacun.Name = "akcijaStornirajRacun";
            this.akcijaStornirajRacun.Size = new System.Drawing.Size(216, 60);
            this.akcijaStornirajRacun.TabIndex = 0;
            this.akcijaStornirajRacun.Text = "Storniraj račun";
            this.akcijaStornirajRacun.UseVisualStyleBackColor = false;
            // 
            // ispisIzdaniRacuni
            // 
            this.ispisIzdaniRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ispisIzdaniRacuni.FormattingEnabled = true;
            this.ispisIzdaniRacuni.ItemHeight = 18;
            this.ispisIzdaniRacuni.Location = new System.Drawing.Point(31, 49);
            this.ispisIzdaniRacuni.Name = "ispisIzdaniRacuni";
            this.ispisIzdaniRacuni.Size = new System.Drawing.Size(235, 292);
            this.ispisIzdaniRacuni.TabIndex = 1;
            // 
            // izdaniRacuniLabela
            // 
            this.izdaniRacuniLabela.AutoSize = true;
            this.izdaniRacuniLabela.BackColor = System.Drawing.Color.Transparent;
            this.izdaniRacuniLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izdaniRacuniLabela.Location = new System.Drawing.Point(28, 29);
            this.izdaniRacuniLabela.Name = "izdaniRacuniLabela";
            this.izdaniRacuniLabela.Size = new System.Drawing.Size(92, 17);
            this.izdaniRacuniLabela.TabIndex = 2;
            this.izdaniRacuniLabela.Text = "Izdani racuni:";
            // 
            // podaciORacunuLabela
            // 
            this.podaciORacunuLabela.AutoSize = true;
            this.podaciORacunuLabela.BackColor = System.Drawing.Color.Transparent;
            this.podaciORacunuLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podaciORacunuLabela.Location = new System.Drawing.Point(303, 29);
            this.podaciORacunuLabela.Name = "podaciORacunuLabela";
            this.podaciORacunuLabela.Size = new System.Drawing.Size(115, 17);
            this.podaciORacunuLabela.TabIndex = 3;
            this.podaciORacunuLabela.Text = "Podaci o računu:";
            // 
            // ispisPodaciORacunu
            // 
            this.ispisPodaciORacunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ispisPodaciORacunu.Location = new System.Drawing.Point(306, 49);
            this.ispisPodaciORacunu.Multiline = true;
            this.ispisPodaciORacunu.Name = "ispisPodaciORacunu";
            this.ispisPodaciORacunu.Size = new System.Drawing.Size(321, 215);
            this.ispisPodaciORacunu.TabIndex = 4;
            // 
            // StorniranjeRacunaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 379);
            this.Controls.Add(this.ispisPodaciORacunu);
            this.Controls.Add(this.podaciORacunuLabela);
            this.Controls.Add(this.izdaniRacuniLabela);
            this.Controls.Add(this.ispisIzdaniRacuni);
            this.Controls.Add(this.akcijaStornirajRacun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StorniranjeRacunaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storniranje računa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button akcijaStornirajRacun;
        private System.Windows.Forms.ListBox ispisIzdaniRacuni;
        private System.Windows.Forms.Label izdaniRacuniLabela;
        private System.Windows.Forms.Label podaciORacunuLabela;
        private System.Windows.Forms.TextBox ispisPodaciORacunu;
    }
}
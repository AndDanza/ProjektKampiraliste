namespace Kampiraliste
{
    partial class VoditeljForma
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
            this.otvoriPopisCjenikaAkcija = new System.Windows.Forms.Button();
            this.otvorPopisZaposlenikaAkcija = new System.Windows.Forms.Button();
            this.otvoriPrijavuGostaAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otvoriPopisCjenikaAkcija
            // 
            this.otvoriPopisCjenikaAkcija.BackColor = System.Drawing.Color.Peru;
            this.otvoriPopisCjenikaAkcija.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otvoriPopisCjenikaAkcija.Location = new System.Drawing.Point(39, 262);
            this.otvoriPopisCjenikaAkcija.Name = "otvoriPopisCjenikaAkcija";
            this.otvoriPopisCjenikaAkcija.Size = new System.Drawing.Size(300, 149);
            this.otvoriPopisCjenikaAkcija.TabIndex = 0;
            this.otvoriPopisCjenikaAkcija.Text = "Cjenik";
            this.otvoriPopisCjenikaAkcija.UseVisualStyleBackColor = false;
            this.otvoriPopisCjenikaAkcija.Click += new System.EventHandler(this.otvoriPopisCjenikaAkcija_Click);
            // 
            // otvorPopisZaposlenikaAkcija
            // 
            this.otvorPopisZaposlenikaAkcija.BackColor = System.Drawing.Color.Peru;
            this.otvorPopisZaposlenikaAkcija.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otvorPopisZaposlenikaAkcija.Location = new System.Drawing.Point(381, 262);
            this.otvorPopisZaposlenikaAkcija.Name = "otvorPopisZaposlenikaAkcija";
            this.otvorPopisZaposlenikaAkcija.Size = new System.Drawing.Size(309, 148);
            this.otvorPopisZaposlenikaAkcija.TabIndex = 1;
            this.otvorPopisZaposlenikaAkcija.Text = "Zaposlenici";
            this.otvorPopisZaposlenikaAkcija.UseVisualStyleBackColor = false;
            this.otvorPopisZaposlenikaAkcija.Click += new System.EventHandler(this.otvorPopisZaposlenikaAkcija_Click);
            // 
            // otvoriPrijavuGostaAction
            // 
            this.otvoriPrijavuGostaAction.BackColor = System.Drawing.Color.Peru;
            this.otvoriPrijavuGostaAction.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otvoriPrijavuGostaAction.ForeColor = System.Drawing.Color.Black;
            this.otvoriPrijavuGostaAction.Location = new System.Drawing.Point(39, 39);
            this.otvoriPrijavuGostaAction.Name = "otvoriPrijavuGostaAction";
            this.otvoriPrijavuGostaAction.Size = new System.Drawing.Size(300, 160);
            this.otvoriPrijavuGostaAction.TabIndex = 2;
            this.otvoriPrijavuGostaAction.Text = "Prijava gosta";
            this.otvoriPrijavuGostaAction.UseVisualStyleBackColor = false;
            this.otvoriPrijavuGostaAction.Click += new System.EventHandler(this.otvoriPrijavuGostaAction_Click);
            // 
            // VoditeljForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 555);
            this.Controls.Add(this.otvoriPrijavuGostaAction);
            this.Controls.Add(this.otvorPopisZaposlenikaAkcija);
            this.Controls.Add(this.otvoriPopisCjenikaAkcija);
            this.Name = "VoditeljForma";
            this.Text = "Voditelj";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button otvoriPopisCjenikaAkcija;
        private System.Windows.Forms.Button otvorPopisZaposlenikaAkcija;
        private System.Windows.Forms.Button otvoriPrijavuGostaAction;
    }
}
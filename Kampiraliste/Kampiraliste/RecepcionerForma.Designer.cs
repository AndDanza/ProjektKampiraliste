namespace Kampiraliste
{
    partial class RecepcionerForma
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
            this.otvoriPrijavuGostaAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otvoriPrijavuGostaAction
            // 
            this.otvoriPrijavuGostaAction.BackColor = System.Drawing.Color.Peru;
            this.otvoriPrijavuGostaAction.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otvoriPrijavuGostaAction.ForeColor = System.Drawing.Color.Black;
            this.otvoriPrijavuGostaAction.Location = new System.Drawing.Point(37, 46);
            this.otvoriPrijavuGostaAction.Name = "otvoriPrijavuGostaAction";
            this.otvoriPrijavuGostaAction.Size = new System.Drawing.Size(257, 160);
            this.otvoriPrijavuGostaAction.TabIndex = 0;
            this.otvoriPrijavuGostaAction.Text = "Prijava gosta";
            this.otvoriPrijavuGostaAction.UseVisualStyleBackColor = false;
            this.otvoriPrijavuGostaAction.Click += new System.EventHandler(this.otvoriPrijavuGostaAction_Click);
            // 
            // RecepcionerForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 558);
            this.Controls.Add(this.otvoriPrijavuGostaAction);
            this.Name = "RecepcionerForma";
            this.Text = "Recepcioner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button otvoriPrijavuGostaAction;
    }
}
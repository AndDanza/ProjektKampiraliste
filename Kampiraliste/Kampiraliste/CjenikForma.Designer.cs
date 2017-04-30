﻿namespace Kampiraliste
{
    partial class CjenikForma
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cjenikBindingSource = new System.Windows.Forms.DataGridView();
            this.vrstadokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstasmjestajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstadokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstasmjestajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj novi cjenik";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(358, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ažuriraj cjenik";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Peru;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(169, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(330, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "Obriši cjenik";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cjenikBindingSource
            // 
            this.cjenikBindingSource.AutoGenerateColumns = false;
            this.cjenikBindingSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cjenikBindingSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.cjenikBindingSource.DataSource = this.vrstasmjestajaBindingSource;
            this.cjenikBindingSource.Location = new System.Drawing.Point(220, 238);
            this.cjenikBindingSource.Name = "cjenikBindingSource";
            this.cjenikBindingSource.RowTemplate.Height = 24;
            this.cjenikBindingSource.Size = new System.Drawing.Size(244, 172);
            this.cjenikBindingSource.TabIndex = 3;
            // 
            // vrstadokumentaBindingSource
            // 
            this.vrstadokumentaBindingSource.DataSource = typeof(Kampiraliste.vrsta_dokumenta);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // vrstasmjestajaBindingSource
            // 
            this.vrstasmjestajaBindingSource.DataSource = typeof(Kampiraliste.vrsta_smjestaja);
            // 
            // CjenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 512);
            this.Controls.Add(this.cjenikBindingSource);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CjenikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CjenikForma";
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstadokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstasmjestajaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView cjenikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vrstasmjestajaBindingSource;
        private System.Windows.Forms.BindingSource vrstadokumentaBindingSource;
    }
}
﻿namespace FinishLine
{
    partial class Nastavenia
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
            this.label2 = new System.Windows.Forms.Label();
            this.numDlzkaKola = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPocetKol = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numPocetMiestVitazov = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDlzkaKola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPocetKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPocetMiestVitazov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nastavenia pretekov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dĺžka kola";
            // 
            // numDlzkaKola
            // 
            this.numDlzkaKola.DecimalPlaces = 3;
            this.numDlzkaKola.Location = new System.Drawing.Point(168, 59);
            this.numDlzkaKola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDlzkaKola.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDlzkaKola.Name = "numDlzkaKola";
            this.numDlzkaKola.Size = new System.Drawing.Size(133, 22);
            this.numDlzkaKola.TabIndex = 2;
            this.numDlzkaKola.ValueChanged += new System.EventHandler(this.numDlzkaKola_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(309, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Počet kôl";
            // 
            // numPocetKol
            // 
            this.numPocetKol.Location = new System.Drawing.Point(168, 100);
            this.numPocetKol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPocetKol.Name = "numPocetKol";
            this.numPocetKol.Size = new System.Drawing.Size(133, 22);
            this.numPocetKol.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(21, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Počet miest víťazov";
            // 
            // numPocetMiestVitazov
            // 
            this.numPocetMiestVitazov.Location = new System.Drawing.Point(168, 145);
            this.numPocetMiestVitazov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPocetMiestVitazov.Name = "numPocetMiestVitazov";
            this.numPocetMiestVitazov.Size = new System.Drawing.Size(133, 22);
            this.numPocetMiestVitazov.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 206);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 28);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Uložiť";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(171, 206);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(131, 28);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "Neuložiť";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Nastavenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 247);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numPocetMiestVitazov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPocetKol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDlzkaKola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nastavenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nastavenia";
            this.Load += new System.EventHandler(this.Nastavenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDlzkaKola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPocetKol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPocetMiestVitazov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDlzkaKola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPocetKol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPocetMiestVitazov;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button BtnClose;
    }
}
﻿namespace FinishLine
{
    partial class CiselnikBezcov
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
            this.Pohlavie = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Krajina = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Vek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenoBezca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwCiselnikBezcov = new System.Windows.Forms.DataGridView();
            this.btnPridajBezca = new System.Windows.Forms.Button();
            this.btnUpravBezca = new System.Windows.Forms.Button();
            this.btnVymazBezca = new System.Windows.Forms.Button();
            this.statBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.statBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.krajinyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.krajinyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.krajinyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.krajinyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCiselnikBezcov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // Pohlavie
            // 
            this.Pohlavie.HeaderText = "Pohlavie";
            this.Pohlavie.Name = "Pohlavie";
            // 
            // Krajina
            // 
            this.Krajina.DataSource = this.statBindingSource2;
            this.Krajina.DisplayMember = "KrajinaNazov";
            this.Krajina.HeaderText = "Krajina";
            this.Krajina.Name = "Krajina";
            this.Krajina.ValueMember = "KrajinaKod";
            // 
            // Vek
            // 
            this.Vek.HeaderText = "Vek";
            this.Vek.Name = "Vek";
            // 
            // MenoBezca
            // 
            this.MenoBezca.HeaderText = "Meno";
            this.MenoBezca.Name = "MenoBezca";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dgwCiselnikBezcov
            // 
            this.dgwCiselnikBezcov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCiselnikBezcov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MenoBezca,
            this.Vek,
            this.Krajina,
            this.Pohlavie});
            this.dgwCiselnikBezcov.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwCiselnikBezcov.Location = new System.Drawing.Point(0, 0);
            this.dgwCiselnikBezcov.Name = "dgwCiselnikBezcov";
            this.dgwCiselnikBezcov.Size = new System.Drawing.Size(594, 405);
            this.dgwCiselnikBezcov.TabIndex = 0;
            this.dgwCiselnikBezcov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCiselnikBezcov_CellContentClick);
            this.dgwCiselnikBezcov.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwCiselnikBezcov_CellFormatting);
            // 
            // btnPridajBezca
            // 
            this.btnPridajBezca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPridajBezca.Location = new System.Drawing.Point(12, 411);
            this.btnPridajBezca.Name = "btnPridajBezca";
            this.btnPridajBezca.Size = new System.Drawing.Size(135, 76);
            this.btnPridajBezca.TabIndex = 1;
            this.btnPridajBezca.Text = "Pridaj bežca";
            this.btnPridajBezca.UseVisualStyleBackColor = true;
            this.btnPridajBezca.Click += new System.EventHandler(this.btnPridajBezca_Click);
            // 
            // btnUpravBezca
            // 
            this.btnUpravBezca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpravBezca.Location = new System.Drawing.Point(153, 411);
            this.btnUpravBezca.Name = "btnUpravBezca";
            this.btnUpravBezca.Size = new System.Drawing.Size(135, 76);
            this.btnUpravBezca.TabIndex = 2;
            this.btnUpravBezca.Text = "Uprav bežca";
            this.btnUpravBezca.UseVisualStyleBackColor = true;
            // 
            // btnVymazBezca
            // 
            this.btnVymazBezca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVymazBezca.Location = new System.Drawing.Point(294, 411);
            this.btnVymazBezca.Name = "btnVymazBezca";
            this.btnVymazBezca.Size = new System.Drawing.Size(135, 76);
            this.btnVymazBezca.TabIndex = 3;
            this.btnVymazBezca.Text = "Vymaž bežca";
            this.btnVymazBezca.UseVisualStyleBackColor = true;
            // 
            // statBindingSource2
            // 
            this.statBindingSource2.DataSource = typeof(FinishLine.Stat);
            // 
            // statBindingSource
            // 
            this.statBindingSource.DataSource = typeof(FinishLine.Stat);
            // 
            // statBindingSource1
            // 
            this.statBindingSource1.DataSource = typeof(FinishLine.Stat);
            // 
            // krajinyBindingSource1
            // 
            this.krajinyBindingSource1.DataSource = typeof(FinishLine.Staty);
            // 
            // krajinyBindingSource
            // 
            this.krajinyBindingSource.DataSource = typeof(FinishLine.Staty);
            // 
            // krajinyBindingSource2
            // 
            this.krajinyBindingSource2.DataSource = typeof(FinishLine.Staty);
            // 
            // krajinyBindingSource3
            // 
            this.krajinyBindingSource3.DataSource = typeof(FinishLine.Staty);
            // 
            // CiselnikBezcov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(594, 499);
            this.Controls.Add(this.btnVymazBezca);
            this.Controls.Add(this.btnUpravBezca);
            this.Controls.Add(this.btnPridajBezca);
            this.Controls.Add(this.dgwCiselnikBezcov);
            this.Name = "CiselnikBezcov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zoznam bežcov";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCiselnikBezcov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource krajinyBindingSource1;
        private System.Windows.Forms.BindingSource krajinyBindingSource;
        private System.Windows.Forms.BindingSource statBindingSource;
        private System.Windows.Forms.BindingSource statBindingSource1;
        private System.Windows.Forms.BindingSource krajinyBindingSource2;
        private System.Windows.Forms.BindingSource statBindingSource2;
        private System.Windows.Forms.BindingSource krajinyBindingSource3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Pohlavie;
        private System.Windows.Forms.DataGridViewComboBoxColumn Krajina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vek;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenoBezca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dgwCiselnikBezcov;
        private System.Windows.Forms.Button btnPridajBezca;
        private System.Windows.Forms.Button btnUpravBezca;
        private System.Windows.Forms.Button btnVymazBezca;
    }
}
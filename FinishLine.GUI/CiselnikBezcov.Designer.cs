namespace FinishLine
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
            this.dgwCiselnikBezcov = new System.Windows.Forms.DataGridView();
            this.bezecZoznamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPridajBezca = new System.Windows.Forms.Button();
            this.btnUpravBezca = new System.Windows.Forms.Button();
            this.btnVymazBezca = new System.Windows.Forms.Button();
            this.statBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.statBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.krajinyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.krajinyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.krajinyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bezecZoznamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bezecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenoBezca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Krajina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pohlavie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCiselnikBezcov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bezecZoznamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bezecZoznamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bezecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCiselnikBezcov
            // 
            this.dgwCiselnikBezcov.AllowUserToAddRows = false;
            this.dgwCiselnikBezcov.AllowUserToDeleteRows = false;
            this.dgwCiselnikBezcov.AutoGenerateColumns = false;
            this.dgwCiselnikBezcov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCiselnikBezcov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MenoBezca,
            this.Vek,
            this.Krajina,
            this.Pohlavie});
            this.dgwCiselnikBezcov.DataSource = this.bezecZoznamBindingSource1;
            this.dgwCiselnikBezcov.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwCiselnikBezcov.Location = new System.Drawing.Point(0, 0);
            this.dgwCiselnikBezcov.Margin = new System.Windows.Forms.Padding(4);
            this.dgwCiselnikBezcov.Name = "dgwCiselnikBezcov";
            this.dgwCiselnikBezcov.ReadOnly = true;
            this.dgwCiselnikBezcov.Size = new System.Drawing.Size(744, 498);
            this.dgwCiselnikBezcov.TabIndex = 0;
            this.dgwCiselnikBezcov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCiselnikBezcov_CellContentClick);
            this.dgwCiselnikBezcov.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwCiselnikBezcov_CellFormatting);
            // 
            // bezecZoznamBindingSource1
            // 
            this.bezecZoznamBindingSource1.DataSource = typeof(FinishLine.Core.BezecZoznam);
            // 
            // btnPridajBezca
            // 
            this.btnPridajBezca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPridajBezca.Location = new System.Drawing.Point(16, 506);
            this.btnPridajBezca.Margin = new System.Windows.Forms.Padding(4);
            this.btnPridajBezca.Name = "btnPridajBezca";
            this.btnPridajBezca.Size = new System.Drawing.Size(180, 94);
            this.btnPridajBezca.TabIndex = 1;
            this.btnPridajBezca.Text = "Pridaj bežca";
            this.btnPridajBezca.UseVisualStyleBackColor = true;
            this.btnPridajBezca.Click += new System.EventHandler(this.btnPridajBezca_Click);
            // 
            // btnUpravBezca
            // 
            this.btnUpravBezca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpravBezca.Location = new System.Drawing.Point(204, 506);
            this.btnUpravBezca.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpravBezca.Name = "btnUpravBezca";
            this.btnUpravBezca.Size = new System.Drawing.Size(180, 94);
            this.btnUpravBezca.TabIndex = 2;
            this.btnUpravBezca.Text = "Uprav bežca";
            this.btnUpravBezca.UseVisualStyleBackColor = true;
            this.btnUpravBezca.Click += new System.EventHandler(this.btnUpravBezca_Click);
            // 
            // btnVymazBezca
            // 
            this.btnVymazBezca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVymazBezca.Location = new System.Drawing.Point(392, 506);
            this.btnVymazBezca.Margin = new System.Windows.Forms.Padding(4);
            this.btnVymazBezca.Name = "btnVymazBezca";
            this.btnVymazBezca.Size = new System.Drawing.Size(180, 94);
            this.btnVymazBezca.TabIndex = 3;
            this.btnVymazBezca.Text = "Vymaž bežca";
            this.btnVymazBezca.UseVisualStyleBackColor = true;
            this.btnVymazBezca.Click += new System.EventHandler(this.btnVymazBezca_Click);
            // 
            // statBindingSource2
            // 
            this.statBindingSource2.DataSource = typeof(FinishLine.Core.Stat);
            // 
            // statBindingSource1
            // 
            this.statBindingSource1.DataSource = typeof(FinishLine.Core.Stat);
            // 
            // krajinyBindingSource1
            // 
            this.krajinyBindingSource1.DataSource = typeof(FinishLine.Core.Staty);
            // 
            // krajinyBindingSource
            // 
            this.krajinyBindingSource.DataSource = typeof(FinishLine.Core.Staty);
            // 
            // krajinyBindingSource3
            // 
            this.krajinyBindingSource3.DataSource = typeof(FinishLine.Core.Staty);
            // 
            // bezecZoznamBindingSource
            // 
            this.bezecZoznamBindingSource.DataSource = typeof(FinishLine.Core.BezecZoznam);
            // 
            // bezecBindingSource
            // 
            this.bezecBindingSource.DataSource = typeof(FinishLine.Core.Bezec);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(580, 506);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(164, 94);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // MenoBezca
            // 
            this.MenoBezca.DataPropertyName = "Meno";
            this.MenoBezca.HeaderText = "Meno";
            this.MenoBezca.Name = "MenoBezca";
            this.MenoBezca.ReadOnly = true;
            // 
            // Vek
            // 
            this.Vek.DataPropertyName = "Vek";
            this.Vek.HeaderText = "Vek";
            this.Vek.Name = "Vek";
            this.Vek.ReadOnly = true;
            // 
            // Krajina
            // 
            this.Krajina.DataPropertyName = "Krajina";
            this.Krajina.HeaderText = "Krajina";
            this.Krajina.Name = "Krajina";
            this.Krajina.ReadOnly = true;
            // 
            // Pohlavie
            // 
            this.Pohlavie.DataPropertyName = "Pohlavie";
            this.Pohlavie.HeaderText = "Pohlavie";
            this.Pohlavie.Name = "Pohlavie";
            this.Pohlavie.ReadOnly = true;
            // 
            // CiselnikBezcov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(744, 609);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnVymazBezca);
            this.Controls.Add(this.btnUpravBezca);
            this.Controls.Add(this.btnPridajBezca);
            this.Controls.Add(this.dgwCiselnikBezcov);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CiselnikBezcov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zoznam bežcov";
            this.Activated += new System.EventHandler(this.CiselnikBezcov_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CiselnikBezcov_FormClosing);
            this.Load += new System.EventHandler(this.CiselnikBezcov_Load);
            this.Shown += new System.EventHandler(this.CiselnikBezcov_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCiselnikBezcov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bezecZoznamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajinyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bezecZoznamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bezecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource krajinyBindingSource1;
        private System.Windows.Forms.BindingSource krajinyBindingSource;
        private System.Windows.Forms.BindingSource statBindingSource1;
        private System.Windows.Forms.BindingSource statBindingSource2;
        private System.Windows.Forms.BindingSource krajinyBindingSource3;
        private System.Windows.Forms.DataGridView dgwCiselnikBezcov;
        private System.Windows.Forms.Button btnPridajBezca;
        private System.Windows.Forms.Button btnUpravBezca;
        private System.Windows.Forms.Button btnVymazBezca;
        private System.Windows.Forms.BindingSource bezecZoznamBindingSource1;
        private System.Windows.Forms.BindingSource bezecZoznamBindingSource;
        private System.Windows.Forms.BindingSource bezecBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenoBezca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Krajina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pohlavie;
    }
}
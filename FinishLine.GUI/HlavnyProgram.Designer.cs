namespace FinishLine
{
    partial class HlavnyProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HlavnyProgram));
            this.btnZavodZahajit = new System.Windows.Forms.Button();
            this.lblZavodZacal = new System.Windows.Forms.Label();
            this.lblZaciatokZavodu = new System.Windows.Forms.Label();
            this.lblTextInfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguráciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretekáriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numCisloBezca = new System.Windows.Forms.NumericUpDown();
            this.lblTextCiExistujeZadaneID = new System.Windows.Forms.Label();
            this.lblNavodNadpis = new System.Windows.Forms.Label();
            this.lblNavodText = new System.Windows.Forms.Label();
            this.dataGridViewGrouper1 = new Subro.Controls.DataGridViewGrouper(this.components);
            this.groupingSource1 = new Subro.Controls.GroupingSource();
            this.dataGridViewGrouper2 = new Subro.Controls.DataGridViewGrouper(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisloBezca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZavodZahajit
            // 
            this.btnZavodZahajit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZavodZahajit.Location = new System.Drawing.Point(16, 55);
            this.btnZavodZahajit.Margin = new System.Windows.Forms.Padding(4);
            this.btnZavodZahajit.Name = "btnZavodZahajit";
            this.btnZavodZahajit.Size = new System.Drawing.Size(163, 40);
            this.btnZavodZahajit.TabIndex = 1;
            this.btnZavodZahajit.Text = "4. Zahájiť beh";
            this.btnZavodZahajit.UseVisualStyleBackColor = true;
            this.btnZavodZahajit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblZavodZacal
            // 
            this.lblZavodZacal.AutoSize = true;
            this.lblZavodZacal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZavodZacal.Location = new System.Drawing.Point(197, 55);
            this.lblZavodZacal.Name = "lblZavodZacal";
            this.lblZavodZacal.Size = new System.Drawing.Size(109, 20);
            this.lblZavodZacal.TabIndex = 5;
            this.lblZavodZacal.Text = "Závod začal";
            this.lblZavodZacal.Visible = false;
            // 
            // lblZaciatokZavodu
            // 
            this.lblZaciatokZavodu.AutoSize = true;
            this.lblZaciatokZavodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaciatokZavodu.Location = new System.Drawing.Point(197, 75);
            this.lblZaciatokZavodu.Name = "lblZaciatokZavodu";
            this.lblZaciatokZavodu.Size = new System.Drawing.Size(0, 20);
            this.lblZaciatokZavodu.TabIndex = 6;
            // 
            // lblTextInfo
            // 
            this.lblTextInfo.AutoSize = true;
            this.lblTextInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTextInfo.Location = new System.Drawing.Point(468, 55);
            this.lblTextInfo.Name = "lblTextInfo";
            this.lblTextInfo.Size = new System.Drawing.Size(292, 17);
            this.lblTextInfo.TabIndex = 7;
            this.lblTextInfo.Text = "5. Zadajte číslo bežca a stlačte ENTER";
            this.lblTextInfo.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 525);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 24);
            this.toolStripMenuItem1.Text = "1. Databáza";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // konfiguráciaToolStripMenuItem
            // 
            this.konfiguráciaToolStripMenuItem.Name = "konfiguráciaToolStripMenuItem";
            this.konfiguráciaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.konfiguráciaToolStripMenuItem.Text = "2. Číselník bežcov";
            this.konfiguráciaToolStripMenuItem.Click += new System.EventHandler(this.konfiguráciaToolStripMenuItem_Click);
            // 
            // pretekáriToolStripMenuItem
            // 
            this.pretekáriToolStripMenuItem.Name = "pretekáriToolStripMenuItem";
            this.pretekáriToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.pretekáriToolStripMenuItem.Text = "3. Nastavenia preteku";
            this.pretekáriToolStripMenuItem.Click += new System.EventHandler(this.pretekáriToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.konfiguráciaToolStripMenuItem,
            this.pretekáriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1496, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(754, 178);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(732, 525);
            this.dataGridView3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Priebežné výsledky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(750, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Poradie víťazov";
            // 
            // numCisloBezca
            // 
            this.numCisloBezca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numCisloBezca.Location = new System.Drawing.Point(469, 75);
            this.numCisloBezca.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numCisloBezca.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCisloBezca.Name = "numCisloBezca";
            this.numCisloBezca.Size = new System.Drawing.Size(120, 36);
            this.numCisloBezca.TabIndex = 2;
            this.numCisloBezca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCisloBezca.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCisloBezca.Visible = false;
            this.numCisloBezca.ValueChanged += new System.EventHandler(this.numCisloBezca_ValueChanged);
            this.numCisloBezca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCisloBezca_KeyPress);
            this.numCisloBezca.Leave += new System.EventHandler(this.button1_Click_1);
            this.numCisloBezca.Validating += new System.ComponentModel.CancelEventHandler(this.numCisloBezca_Validating);
            // 
            // lblTextCiExistujeZadaneID
            // 
            this.lblTextCiExistujeZadaneID.AutoSize = true;
            this.lblTextCiExistujeZadaneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTextCiExistujeZadaneID.ForeColor = System.Drawing.Color.Maroon;
            this.lblTextCiExistujeZadaneID.Location = new System.Drawing.Point(466, 114);
            this.lblTextCiExistujeZadaneID.Name = "lblTextCiExistujeZadaneID";
            this.lblTextCiExistujeZadaneID.Size = new System.Drawing.Size(0, 17);
            this.lblTextCiExistujeZadaneID.TabIndex = 8;
            this.lblTextCiExistujeZadaneID.Visible = false;
            // 
            // lblNavodNadpis
            // 
            this.lblNavodNadpis.AutoSize = true;
            this.lblNavodNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNavodNadpis.Location = new System.Drawing.Point(932, 35);
            this.lblNavodNadpis.Name = "lblNavodNadpis";
            this.lblNavodNadpis.Size = new System.Drawing.Size(267, 20);
            this.lblNavodNadpis.TabIndex = 11;
            this.lblNavodNadpis.Text = "Návod na používanie programu";
            // 
            // lblNavodText
            // 
            this.lblNavodText.AutoSize = true;
            this.lblNavodText.Location = new System.Drawing.Point(933, 55);
            this.lblNavodText.Name = "lblNavodText";
            this.lblNavodText.Size = new System.Drawing.Size(553, 119);
            this.lblNavodText.TabIndex = 12;
            this.lblNavodText.Text = resources.GetString("lblNavodText.Text");
            // 
            // dataGridViewGrouper1
            // 
            this.dataGridViewGrouper1.SortOrder = System.Windows.Forms.SortOrder.Descending;
            // 
            // dataGridViewGrouper2
            // 
            this.dataGridViewGrouper2.DataGridView = this.dataGridView1;
            this.dataGridViewGrouper2.SortOrder = System.Windows.Forms.SortOrder.Descending;
            // 
            // HlavnyProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 715);
            this.Controls.Add(this.lblNavodText);
            this.Controls.Add(this.lblNavodNadpis);
            this.Controls.Add(this.lblTextCiExistujeZadaneID);
            this.Controls.Add(this.numCisloBezca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTextInfo);
            this.Controls.Add(this.lblZaciatokZavodu);
            this.Controls.Add(this.lblZavodZacal);
            this.Controls.Add(this.btnZavodZahajit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HlavnyProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencia bežeckých výkonov";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisloBezca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnZavodZahajit;
        private System.Windows.Forms.Label lblZavodZacal;
        private System.Windows.Forms.Label lblZaciatokZavodu;
        private System.Windows.Forms.Label lblTextInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem konfiguráciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretekáriToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Subro.Controls.GroupingSource groupingSource1;
        private Subro.Controls.DataGridViewGrouper dataGridViewGrouper2;
        public Subro.Controls.DataGridViewGrouper dataGridViewGrouper1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCisloBezca;
        private System.Windows.Forms.Label lblTextCiExistujeZadaneID;
        private System.Windows.Forms.Label lblNavodNadpis;
        private System.Windows.Forms.Label lblNavodText;
    }
}


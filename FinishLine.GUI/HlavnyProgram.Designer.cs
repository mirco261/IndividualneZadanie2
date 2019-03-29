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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novýZávodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.načítajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguráciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretekáriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Poradie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CasDokonceniaKola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DlzkaKola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PoradiePoradie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoradieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoradieMeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoradieCasUkoncenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoradieCelkovyCas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewGrouper1 = new Subro.Controls.DataGridViewGrouper(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnNacitajZoznamStatov = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýZávodToolStripMenuItem,
            this.uložToolStripMenuItem,
            this.načítajToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 24);
            this.toolStripMenuItem1.Text = "MENU";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // novýZávodToolStripMenuItem
            // 
            this.novýZávodToolStripMenuItem.Name = "novýZávodToolStripMenuItem";
            this.novýZávodToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.novýZávodToolStripMenuItem.Text = "Nový závod";
            // 
            // uložToolStripMenuItem
            // 
            this.uložToolStripMenuItem.Name = "uložToolStripMenuItem";
            this.uložToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.uložToolStripMenuItem.Text = "Ulož";
            // 
            // načítajToolStripMenuItem
            // 
            this.načítajToolStripMenuItem.Name = "načítajToolStripMenuItem";
            this.načítajToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.načítajToolStripMenuItem.Text = "Načítaj";
            // 
            // konfiguráciaToolStripMenuItem
            // 
            this.konfiguráciaToolStripMenuItem.Name = "konfiguráciaToolStripMenuItem";
            this.konfiguráciaToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.konfiguráciaToolStripMenuItem.Text = "Číselník bežcov";
            this.konfiguráciaToolStripMenuItem.Click += new System.EventHandler(this.konfiguráciaToolStripMenuItem_Click);
            // 
            // pretekáriToolStripMenuItem
            // 
            this.pretekáriToolStripMenuItem.Name = "pretekáriToolStripMenuItem";
            this.pretekáriToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.pretekáriToolStripMenuItem.Text = "Nastavenia preteku";
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poradie,
            this.ID,
            this.Meno,
            this.CasDokonceniaKola,
            this.DlzkaKola});
            this.dataGridView1.Location = new System.Drawing.Point(16, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // Poradie
            // 
            this.Poradie.HeaderText = "Poradie";
            this.Poradie.Name = "Poradie";
            this.Poradie.Width = 25;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 40;
            // 
            // Meno
            // 
            this.Meno.HeaderText = "Meno";
            this.Meno.Name = "Meno";
            this.Meno.Width = 50;
            // 
            // CasDokonceniaKola
            // 
            this.CasDokonceniaKola.HeaderText = "Čas dokončenia kola";
            this.CasDokonceniaKola.Name = "CasDokonceniaKola";
            // 
            // DlzkaKola
            // 
            this.DlzkaKola.HeaderText = "DlzkaKola";
            this.DlzkaKola.Name = "DlzkaKola";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoradiePoradie,
            this.PoradieID,
            this.PoradieMeno,
            this.PoradieCasUkoncenia,
            this.PoradieCelkovyCas});
            this.dataGridView2.Location = new System.Drawing.Point(533, 153);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(517, 342);
            this.dataGridView2.TabIndex = 2;
            // 
            // PoradiePoradie
            // 
            this.PoradiePoradie.HeaderText = "Poradie";
            this.PoradiePoradie.Name = "PoradiePoradie";
            // 
            // PoradieID
            // 
            this.PoradieID.HeaderText = "ID";
            this.PoradieID.Name = "PoradieID";
            // 
            // PoradieMeno
            // 
            this.PoradieMeno.HeaderText = "Meno";
            this.PoradieMeno.Name = "PoradieMeno";
            // 
            // PoradieCasUkoncenia
            // 
            this.PoradieCasUkoncenia.HeaderText = "Čas ukončenia";
            this.PoradieCasUkoncenia.Name = "PoradieCasUkoncenia";
            // 
            // PoradieCelkovyCas
            // 
            this.PoradieCelkovyCas.HeaderText = "Celkový čas";
            this.PoradieCelkovyCas.Name = "PoradieCelkovyCas";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(17, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zahájiť beh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNacitajZoznamStatov
            // 
            this.btnNacitajZoznamStatov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNacitajZoznamStatov.Location = new System.Drawing.Point(853, 63);
            this.btnNacitajZoznamStatov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNacitajZoznamStatov.Name = "btnNacitajZoznamStatov";
            this.btnNacitajZoznamStatov.Size = new System.Drawing.Size(163, 37);
            this.btnNacitajZoznamStatov.TabIndex = 4;
            this.btnNacitajZoznamStatov.Text = "NacitajZoznamStatov";
            this.btnNacitajZoznamStatov.UseVisualStyleBackColor = true;
            this.btnNacitajZoznamStatov.Click += new System.EventHandler(this.button2_Click);
            // 
            // HlavnyProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNacitajZoznamStatov);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HlavnyProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencia bežeckých výkonov";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novýZávodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem načítajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguráciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretekáriToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poradie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasDokonceniaKola;
        private System.Windows.Forms.DataGridViewTextBoxColumn DlzkaKola;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoradiePoradie;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoradieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoradieMeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoradieCasUkoncenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoradieCelkovyCas;
        private Subro.Controls.DataGridViewGrouper dataGridViewGrouper1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNacitajZoznamStatov;
    }
}


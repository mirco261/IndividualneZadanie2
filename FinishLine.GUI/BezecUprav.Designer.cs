namespace FinishLine.Core
{
    partial class BezecUprav
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
            this.lblID = new System.Windows.Forms.Label();
            this.btnUlozAzatvor = new System.Windows.Forms.Button();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStorno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbZena = new System.Windows.Forms.RadioButton();
            this.rdbMuz = new System.Windows.Forms.RadioButton();
            this.cmbKrajiny = new System.Windows.Forms.ComboBox();
            this.numVek = new System.Windows.Forms.NumericUpDown();
            this.txtMenoBezca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVek)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(92, 32);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 27;
            // 
            // btnUlozAzatvor
            // 
            this.btnUlozAzatvor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUlozAzatvor.Location = new System.Drawing.Point(10, 303);
            this.btnUlozAzatvor.Name = "btnUlozAzatvor";
            this.btnUlozAzatvor.Size = new System.Drawing.Size(147, 30);
            this.btnUlozAzatvor.TabIndex = 26;
            this.btnUlozAzatvor.Text = "Ulož a zatvor";
            this.btnUlozAzatvor.UseVisualStyleBackColor = true;
            this.btnUlozAzatvor.Click += new System.EventHandler(this.btnUlozAzatvor_Click);
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(10, 28);
            this.numID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(77, 20);
            this.numID.TabIndex = 25;
            this.numID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numID.ValueChanged += new System.EventHandler(this.numID_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "ID";
            // 
            // btnStorno
            // 
            this.btnStorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStorno.Location = new System.Drawing.Point(8, 340);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(149, 30);
            this.btnStorno.TabIndex = 23;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbZena);
            this.groupBox1.Controls.Add(this.rdbMuz);
            this.groupBox1.Location = new System.Drawing.Point(13, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 63);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // rdbZena
            // 
            this.rdbZena.AutoSize = true;
            this.rdbZena.Location = new System.Drawing.Point(6, 34);
            this.rdbZena.Name = "rdbZena";
            this.rdbZena.Size = new System.Drawing.Size(50, 17);
            this.rdbZena.TabIndex = 1;
            this.rdbZena.TabStop = true;
            this.rdbZena.Text = "Žena";
            this.rdbZena.UseVisualStyleBackColor = true;
            // 
            // rdbMuz
            // 
            this.rdbMuz.AutoSize = true;
            this.rdbMuz.Location = new System.Drawing.Point(7, 11);
            this.rdbMuz.Name = "rdbMuz";
            this.rdbMuz.Size = new System.Drawing.Size(45, 17);
            this.rdbMuz.TabIndex = 0;
            this.rdbMuz.TabStop = true;
            this.rdbMuz.Text = "Muž";
            this.rdbMuz.UseVisualStyleBackColor = true;
            // 
            // cmbKrajiny
            // 
            this.cmbKrajiny.DisplayMember = "KrajinaKod";
            this.cmbKrajiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKrajiny.FormattingEnabled = true;
            this.cmbKrajiny.Location = new System.Drawing.Point(10, 181);
            this.cmbKrajiny.Name = "cmbKrajiny";
            this.cmbKrajiny.Size = new System.Drawing.Size(152, 21);
            this.cmbKrajiny.TabIndex = 20;
            this.cmbKrajiny.ValueMember = "KrajinaKod";
            this.cmbKrajiny.SelectedIndexChanged += new System.EventHandler(this.cmbKrajiny_SelectedIndexChanged);
            // 
            // numVek
            // 
            this.numVek.Location = new System.Drawing.Point(10, 130);
            this.numVek.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numVek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVek.Name = "numVek";
            this.numVek.Size = new System.Drawing.Size(77, 20);
            this.numVek.TabIndex = 19;
            this.numVek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMenoBezca
            // 
            this.txtMenoBezca.Location = new System.Drawing.Point(10, 78);
            this.txtMenoBezca.Name = "txtMenoBezca";
            this.txtMenoBezca.Size = new System.Drawing.Size(152, 20);
            this.txtMenoBezca.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pohlavie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Krajina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Meno bežca";
            // 
            // BezecUprav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 391);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUlozAzatvor);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbKrajiny);
            this.Controls.Add(this.numVek);
            this.Controls.Add(this.txtMenoBezca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(197, 430);
            this.MinimumSize = new System.Drawing.Size(197, 430);
            this.Name = "BezecUprav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BezecUprav";
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnUlozAzatvor;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbZena;
        private System.Windows.Forms.RadioButton rdbMuz;
        private System.Windows.Forms.ComboBox cmbKrajiny;
        private System.Windows.Forms.NumericUpDown numVek;
        private System.Windows.Forms.TextBox txtMenoBezca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
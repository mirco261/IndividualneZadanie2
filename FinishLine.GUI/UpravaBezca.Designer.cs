namespace FinishLine
{
    partial class UpravaBezca
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMenoBezca = new System.Windows.Forms.TextBox();
            this.numVek = new System.Windows.Forms.NumericUpDown();
            this.cmbKrajiny = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbZena = new System.Windows.Forms.RadioButton();
            this.rdbMuz = new System.Windows.Forms.RadioButton();
            this.btnUloz = new System.Windows.Forms.Button();
            this.btnStorno = new System.Windows.Forms.Button();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVek)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meno bežca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Krajina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pohlavie";
            // 
            // txtMenoBezca
            // 
            this.txtMenoBezca.Location = new System.Drawing.Point(12, 77);
            this.txtMenoBezca.Name = "txtMenoBezca";
            this.txtMenoBezca.Size = new System.Drawing.Size(152, 20);
            this.txtMenoBezca.TabIndex = 4;
            // 
            // numVek
            // 
            this.numVek.Location = new System.Drawing.Point(12, 129);
            this.numVek.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numVek.Name = "numVek";
            this.numVek.Size = new System.Drawing.Size(77, 20);
            this.numVek.TabIndex = 5;
            // 
            // cmbKrajiny
            // 
            this.cmbKrajiny.DisplayMember = "KrajinaKod";
            this.cmbKrajiny.FormattingEnabled = true;
            this.cmbKrajiny.Location = new System.Drawing.Point(12, 180);
            this.cmbKrajiny.Name = "cmbKrajiny";
            this.cmbKrajiny.Size = new System.Drawing.Size(152, 21);
            this.cmbKrajiny.TabIndex = 6;
            this.cmbKrajiny.ValueMember = "KrajinaKod";
            this.cmbKrajiny.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbZena);
            this.groupBox1.Controls.Add(this.rdbMuz);
            this.groupBox1.Location = new System.Drawing.Point(15, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 63);
            this.groupBox1.TabIndex = 7;
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
            this.rdbZena.CheckedChanged += new System.EventHandler(this.rdbZena_CheckedChanged);
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
            // btnUloz
            // 
            this.btnUloz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUloz.Location = new System.Drawing.Point(12, 316);
            this.btnUloz.Name = "btnUloz";
            this.btnUloz.Size = new System.Drawing.Size(70, 30);
            this.btnUloz.TabIndex = 8;
            this.btnUloz.Text = "Ulož";
            this.btnUloz.UseVisualStyleBackColor = true;
            this.btnUloz.Click += new System.EventHandler(this.btnUloz_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStorno.Location = new System.Drawing.Point(91, 316);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(70, 30);
            this.btnStorno.TabIndex = 9;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(12, 28);
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
            this.numID.TabIndex = 11;
            this.numID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // UpravaBezca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 360);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnUloz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbKrajiny);
            this.Controls.Add(this.numVek);
            this.Controls.Add(this.txtMenoBezca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpravaBezca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpravaBezca";
            ((System.ComponentModel.ISupportInitialize)(this.numVek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMenoBezca;
        private System.Windows.Forms.NumericUpDown numVek;
        private System.Windows.Forms.ComboBox cmbKrajiny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbZena;
        private System.Windows.Forms.RadioButton rdbMuz;
        private System.Windows.Forms.Button btnUloz;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Label label5;
    }
}
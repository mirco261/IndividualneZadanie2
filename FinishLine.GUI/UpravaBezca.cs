using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinishLine.Core;

namespace FinishLine
{
    public partial class UpravaBezca : Form
    {
        public UpravaBezca()
        {
            InitializeComponent();
            cmbKrajiny.DataSource = Staty.krajiny;
            cmbKrajiny.DisplayMember = "KrajinaNazov";
            cmbKrajiny.ValueMember = "KrajinaKod";
            cmbKrajiny.SelectedValue = "SK";
            rdbMuz.Checked = true;


        }

        private void btnUloz_Click(object sender, EventArgs e)
        {
            string meno = txtMenoBezca.Text.ToString();
            int ID = decimal.ToInt16(numID.Value);
            string krajina = cmbKrajiny.SelectedValue.ToString();
            int vek = decimal.ToInt16(numVek.Value);
            string pohlavie = "muž";
            if (rdbZena.Checked)
            {
                 pohlavie = "žena";
            }
            Bezec bezec1 = new Bezec(meno, krajina, vek, pohlavie);
            BezecZoznam.zoznamBezcovPridaj(ID, bezec1);
            BezecZoznam.zoznamBezcovVypis();



        }

        private void rdbZena_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

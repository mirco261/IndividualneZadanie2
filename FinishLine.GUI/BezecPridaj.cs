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
    public partial class BezecPridaj : Form
    {
        /// <summary>
        /// default, predvyplní záznamy a stačí dopísať meno a uložiť nového bežca
        /// </summary>
        public BezecPridaj()
        {
            InitializeComponent();
            cmbKrajiny.DataSource = Staty.krajiny;
            cmbKrajiny.DisplayMember = "KrajinaNazov";
            cmbKrajiny.ValueMember = "KrajinaKod";
            cmbKrajiny.SelectedValue = "SK";
            rdbMuz.Checked = true;

            //zistujem a zabranujem užívatelovi aby zadal ID rovnaké aké už bolo
            if (BezecZoznam.ZistiCiIdExistuje(decimal.ToInt16(numID.Value)))
            {
                int a = decimal.ToInt16(numID.Value);
                numID.Value++;
            }
        }


        private void btnUloz_Click(object sender, EventArgs e)
        {
            //načítaj z každého políčka do premenných hodnoty
            string meno = txtMenoBezca.Text.ToString();
            int id = decimal.ToInt16(numID.Value);
            string krajina = cmbKrajiny.SelectedValue.ToString();
            int vek = decimal.ToInt16(numVek.Value);
            string pohlavie = "muž";
            if (rdbZena.Checked)
            {
                 pohlavie = "žena";
            }

            //vytvor nový objekt bežec
            Bezec bezec = new Bezec(id, meno, krajina, vek, pohlavie);

            //Zapíš bežec do zoznamu
            BezecZoznam.zoznamBezcovPridaj(id, bezec);

            //vypíš bežca do konzoly aby si si bol istý že ho pridalo
            BezecZoznam.zoznamBezcovVypis();

            //nastav znovu default hodnoty
            txtMenoBezca.Text = "";
            id = id + 1;
            numID.Value = id;
            numVek.Value = 1;
            cmbKrajiny.SelectedValue = "SK";
            rdbMuz.Checked = true;

        }

        private void rdbZena_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnUlozAzatvor_Click(object sender, EventArgs e)
        {
            // načítaj z každého políčka do premenných hodnoty
            string meno = txtMenoBezca.Text.ToString();
            int id = decimal.ToInt16(numID.Value);
            string krajina = cmbKrajiny.SelectedValue.ToString();
            int vek = decimal.ToInt16(numVek.Value);
            string pohlavie = "muž";
            if (rdbZena.Checked)
            {
                pohlavie = "žena";
            }

            //vytvor nový objekt bežec
            Bezec bezec1 = new Bezec(id, meno, krajina, vek, pohlavie);

            //Zapíš bežec do zoznamu
            BezecZoznam.zoznamBezcovPridaj(id.GetHashCode(), bezec1);

            //vypíš bežca do konzoly aby si si bol istý že ho pridalo
            BezecZoznam.zoznamBezcovVypis();

            //Zatvor frm
            Close();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            //Zatvor frm
            Close();
        }

        private void numID_ValueChanged(object sender, EventArgs e)
        {

            //zistujem a zabranujem užívatelovi aby zadal ID rovnaké aké už bolo
            if (BezecZoznam.ZistiCiIdExistuje(decimal.ToInt16(numID.Value)))
            {
                int a = decimal.ToInt16(numID.Value);
                lblID.Text = $"ID{a} už existuje";
                numID.Value++;
            }
        }
    }
}

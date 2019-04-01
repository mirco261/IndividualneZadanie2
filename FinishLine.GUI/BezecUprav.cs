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

namespace FinishLine.Core
{
    public partial class BezecUprav : Form
    {
        int formId;

        public BezecUprav(int id)
        {
            InitializeComponent();
            formId = id;
            cmbKrajiny.DataSource = Staty.krajiny;
            cmbKrajiny.SelectedValue = BezecZoznam.zoznamBezcov[id].Krajina;
            cmbKrajiny.DisplayMember = "KrajinaNazov";
            if (BezecZoznam.zoznamBezcov[id].Pohlavie == "muž")
            {
                rdbMuz.Checked = true;
            }
            else rdbZena.Checked = true;
            numID.Value = BezecZoznam.zoznamBezcov[id].ID;
            txtMenoBezca.Text = BezecZoznam.zoznamBezcov[id].Meno.ToString();
            numVek.Value = BezecZoznam.zoznamBezcov[id].Vek;
            lblID.Text = $"Pôvodné ID {id}";


            //zistujem a zabranujem užívatelovi aby zadal ID rovnaké aké už bolo
            if (id == numID.Value)
            {

            }
            else
            {
                if (BezecZoznam.ZistiCiIdExistuje(decimal.ToInt16(numID.Value)))
                {
                    int a = decimal.ToInt16(numID.Value);
                    numID.Value++;
                }
            }

            //vymažem pôvodné id bežca v dictionary
            BezecZoznam.zoznamBezcovVymaz(id);
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
            BezecZoznam.zoznamBezcovPridaj(id ,bezec1);

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
            if (formId == numID.Value)
            {

            }
            else
            {
                if (BezecZoznam.ZistiCiIdExistuje(decimal.ToInt16(numID.Value)))
                {
                    int a = decimal.ToInt16(numID.Value);
                    numID.Value++;
                }
            }

        }

        private void cmbKrajiny_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

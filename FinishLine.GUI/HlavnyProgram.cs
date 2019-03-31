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
using System.Diagnostics;

namespace FinishLine
{
    public partial class HlavnyProgram : Form
    {
        public HlavnyProgram()
        {
            InitializeComponent();
            Staty.NacitajZoznamStatov();
            if (FileTxt.SuborExistujeZoznam())
            {
                FileTxt.NacitajZoznamBezcov();
            }
        }

        private void groupingSource1_GroupingChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void konfiguráciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CiselnikBezcov f = new CiselnikBezcov();
            f.ShowDialog(this);
        }

        private void pretekáriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nastavenia f = new Nastavenia();
            f.ShowDialog(this);
        }

        private void dataGridViewGrouper1_DisplayGroup(object sender, Subro.Controls.GroupDisplayEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Tlačidlo zahájiť beh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            lblZaciatokZavodu.Text = DateTime.Now.ToString();
            lblZavodZacal.Visible = true;
            lblZaciatokZavodu.Visible = true;
            numCisloBezca.Visible = true;
            numCisloBezca.Text = "";     
            lblTextInfo.Visible = true;
            
        }

        private void txtBezec_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /// <summary>
        /// Tlačidlo pridaj bežca do vyhodnotenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void numCisloBezca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (numCisloBezca.Text == "")
                {
                    lblTextCiExistujeZadaneID.Text = ("Zadajte ID bežca");
                    lblTextCiExistujeZadaneID.Visible = true;

                }
                else
                {
                    //zisti, či dané ID existuje
                    if (BezecZoznam.ZistiCiIdExistuje((int)numCisloBezca.Value))
                    {
                        lblTextCiExistujeZadaneID.Visible = false;

                        //vytiahnem si ID z numUpDown
                        int id = (int)numCisloBezca.Value;
                        string meno = BezecZoznam.BezecDajMeno(id);
                        DateTime teraz = DateTime.Now;
                        TimeSpan dlzka;

                        //zistím si koľko kôl už má bežec odbehnuté
                        int kolo = BezecVysledkyZoznam.VysledkyHladajKoloBezca(id);

                        //zistím si posledný čas kola
                        DateTime predchadzajuceKolo = BezecVysledkyZoznam.VysledkyCasPredchadzajucehoKola(id,kolo);

                        //ak je toto prvé kolo, dopln čas začiatku závodu
                        if (predchadzajuceKolo == new DateTime())
                        {
                        dlzka = teraz - DateTime.Parse(lblZaciatokZavodu.Text.ToString());

                        }
                        else
                        { 
                        dlzka = teraz - predchadzajuceKolo;
                        }

                        //pridám mu kolo
                        kolo++;

                        //pridám mu 1 kolo a zapíšem výsledky
                        BezecVysledky bezec1 = new BezecVysledky(id, meno, teraz, dlzka, kolo);

                        BezecVysledkyZoznam.VysledkyPridaj(bezec1);

                        //zobraz v outpute vysledky
                        BezecVysledkyZoznam.VysledkyZobraz();

                        dataGridView1.DataSource = BezecVysledkyZoznam.vysledky.ToList<BezecVysledky>();

                        dataGridView3.DataSource = BezecVysledkyZoznam.vysledkyTop(FileTxt.NacitajPocetKol(), FileTxt.NacitajPocetPoradi());

                    }
                    else
                    {
                        lblTextCiExistujeZadaneID.Visible = true;
                        lblTextCiExistujeZadaneID.Text = ($"ID s číslom {(int)numCisloBezca.Value} neexistuje");
                    }

                }
                //vymažem znaky v numUpDown
                numCisloBezca.Text = "";
            }
        }

        private void numCisloBezca_Validating(object sender, CancelEventArgs e)
        {

        }

        private void numCisloBezca_ValueChanged(object sender, EventArgs e)
        {
            if (BezecZoznam.ZistiCiIdExistuje((int)numCisloBezca.Value))
            {
                lblTextCiExistujeZadaneID.Visible = false;

            }
            else
            {
                lblTextCiExistujeZadaneID.Visible = true;
                lblTextCiExistujeZadaneID.Text = ($"ID s číslom {(int)numCisloBezca.Value} neexistuje");
            }
        }
    }
}

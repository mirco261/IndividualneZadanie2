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
            

        }

        private void groupingSource1_GroupingChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void konfiguráciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileTxt.JeZadanaCestaUzivatelom() == true)
            {
                CiselnikBezcov f = new CiselnikBezcov();
                f.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Zadaj cestu k existujúcej databáze alebo si vytvorte novú databázu.");
            }

        }

        private void pretekáriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileTxt.JeZadanaCestaUzivatelom() == true)
            {
                Nastavenia f = new Nastavenia(); f.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Zadaj cestu k existujúcej databáze alebo si vytvorte novú databázu.");
            }
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
            //zmažem listy poradí a vysledkovej tabule a gridy kde sa naplnajú
            BezecVysledkyZoznam.poradie.Clear();
            BezecVysledkyZoznam.vysledky.Clear();
            dataGridView1.DataSource = "";
            dataGridView3.DataSource = "";

            //zakažem mu robiť čokolvek iné
            lblTextInfo.Visible = false;




            //načítam zoznam bežcov
            if (FileTxt.SuborExistujeZoznamBezcov())
            {
                FileTxt.NacitajZoznamBezcov();

                //overím či existuje súbor nastavení behu
                if (FileTxt.SuborExistujeNastaveniaBezcov())
                {
                    //zobrazím všetky podporné lbl a num
                    lblZaciatokZavodu.Text = DateTime.Now.ToString();
                    lblZavodZacal.Visible = true;
                    lblZaciatokZavodu.Visible = true;
                    numCisloBezca.Visible = true;
                    numCisloBezca.Text = "";
                    lblTextInfo.Visible = false;

                    //a zakažem mu všetko nepotrebné
                    menuNastaveniaPreteku.Enabled = false;
                    menuDatabaza.Enabled = false;
                    menuCiselnikBezcov.Enabled = false;
                    menuNacitajExistujuceStatistiky.Enabled = false;
                }
                else
                {
                    lblTextCiExistujeZadaneID.Text = "Nastavte si nastavenia preteku";
                    lblTextCiExistujeZadaneID.Visible = true;
                }

            }
            else
            {
                lblTextCiExistujeZadaneID.Text = "Nie je vytvorená databáza bežcov";
                lblTextCiExistujeZadaneID.Visible = true;
            }


        }

        private void txtBezec_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Tlačidlo pridaj bežca do vyhodnotenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numCisloBezca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ak sa dosiahne počet poradí, tak zdisablujem možnosť zadávať víťazov
            if (FileTxt.NacitajPocetPoradi() != BezecVysledkyZoznam.VratPocetVitazov())
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
                            //zisti, či už náhodu už je bežec víťaz
                            if (BezecVysledkyZoznam.VysledkyJeUzVitaz((int)numCisloBezca.Value))
                            {
                                lblTextCiExistujeZadaneID.Visible = true;
                                lblTextCiExistujeZadaneID.Text = ($"Bežec s číslom {(int)numCisloBezca.Value} je už víťaz");
                            }
                            //inak ide dalej
                            else
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
                                DateTime predchadzajuceKolo = BezecVysledkyZoznam.VysledkyCasPredchadzajucehoKola(id, kolo);

                                //ak je toto prvé kolo, dopln čas začiatku závodu
                                if (predchadzajuceKolo == new DateTime())  //ak je prazdne
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

                                //pridam bežca do výsledkov vlavo
                                BezecVysledkyZoznam.VysledkyPridaj(bezec1);

                                //priradím bežca do výsledkovej tabule (ak vyhovuje počtu kôl a je ešte volné poradie)
                                BezecVysledkyZoznam.PoradiePridaj(bezec1, FileTxt.NacitajPocetKol(), FileTxt.NacitajPocetPoradi());

                                //zobraz v outpute vysledky
                                BezecVysledkyZoznam.VysledkyZobraz();

                                //vypisovanie Priebežných výsledkov v datagride
                                dataGridView1.DataSource = BezecVysledkyZoznam.vysledky;
                                dataGridView1.Columns[2].DefaultCellStyle.Format = "HH:mm:ss:ff";
                                dataGridView1.Columns[0].HeaderText = "Číslo bežca";
                                dataGridView1.Columns[2].HeaderText = "Čas zápisu";
                                dataGridView1.Columns[3].HeaderText = "Dĺžka kola";
                                dataGridView1.Columns[4].HeaderText = "Číslo kola";
                                dataGridView1.Columns[5].Visible = false;

                                //nastavím grupovanie podľa počtu odbehnutých kôl
                                dataGridViewGrouper1.SetGroupOn(this.dataGridView1.Columns["Kolo"]);

                                //vypisovanie Poradia víťazov v datagride
                                dataGridView3.DataSource = BezecVysledkyZoznam.poradie.ToList<BezecVysledky>();
                                dataGridView3.Columns[3].Visible = false;
                                dataGridView3.Columns[2].Visible = false;
                            }
                        }
                        else
                        {
                            lblTextCiExistujeZadaneID.Visible = true;
                            lblTextCiExistujeZadaneID.Text = ($"ID s číslom {(int)numCisloBezca.Value} neexistuje");
                        }
                    }
                }
            }
            else  //tu kontrolujem či už su všetci víťazi vyčerpaní - ak ano tak vypisujem nižšie
            {
                lblTextCiExistujeZadaneID.Text = "Všetky pozície sú už obsadené";
                lblTextCiExistujeZadaneID.Visible = true;
                numCisloBezca.Enabled = false;
                MessageBox.Show("Bežecké preteky už poznajú všetkých víťazov - večná im sláva");

                //skrytie všetkého čo užívateľ nepotrebuje vidieť a ja mu nechcem ukázať
                btnUlozStatistiky.Visible = true;
                btnZavodZahajit.Visible = false;
                menuNastaveniaPreteku.Enabled = false;
                menuDatabaza.Enabled = false;
                menuCiselnikBezcov.Enabled = false;
                menuNacitajExistujuceStatistiky.Enabled = false;
                lblTextCiExistujeZadaneID.Text = "Pre spustenie nového behu reštartnite program";
                lblTextCiExistujeZadaneID.Visible = true;
            }
            //vymažem znaky v numUpDown
            numCisloBezca.Text = "";
        }

        private void numCisloBezca_Validating(object sender, CancelEventArgs e)
        {

        }

        private void numCisloBezca_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// tlačidlo na vytvorenie novej zložky pre databazu - subory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vytvorNovuDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Nastavenia preteku a zoznam bežcov sa budú ukladať do vybranej zložky";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Nastavenia preteku a zoznam bežcov sa budú ukladať do zložky\n{fbd.SelectedPath}");
            }
            string path = fbd.SelectedPath;
            FileTxt.UlozCestu(path);

            //Načítaj zoznam bežcov z novej databazy
            if (FileTxt.SuborExistujeZoznamBezcov())
            {
                FileTxt.NacitajZoznamBezcov();
            }
        }

        private void nacitajExistujucuDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Nastavenia preteku a zoznam bežcov sa načítajú z vybranej zložky";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Nastavenia preteku a zoznam bežcov sa načítali zo zálohy\n{fbd.SelectedPath}");
            }
            string path = fbd.SelectedPath;
            FileTxt.UlozCestu(path);

            //Načítaj zoznam bežcov z novej databazy
            if (FileTxt.SuborExistujeZoznamBezcov())
            {
                FileTxt.NacitajZoznamBezcov();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUlozStatistiky_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Štatistiky preteku sa uložia do vybranej zložky";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Štatistiky preteku sa uložili do\n{fbd.SelectedPath}");
            }
            string path = fbd.SelectedPath;
            FileTxt.UlozCestuStatistik(path);

            FileTxt.ZapisStatistikyOpretekoch();
            FileTxt.ZapisStatistikyOumiestneniach();
        }

        private void načítajExistujúceŠtatistikyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Načítajte si zložku, kde máte uložené štatistiky";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
            }
            string path = fbd.SelectedPath;
            FileTxt.UlozCestuStatistik(path);

            //zistim čí existujú súbory
            if (FileTxt.SuborExistujeStatistikyAleboPoradie() == true)
            {
                MessageBox.Show($"Štatistiky sa načítali zo zložky\n{fbd.SelectedPath}");

                FileTxt.NacitajZoznamStatistik();
                FileTxt.NacitajZoznamUmiestneni();

                //vymažem dáta v dgw
                dataGridView1.DataSource = "";
                dataGridView3.DataSource = "";

                //napojím si nové dáta
                dataGridView1.DataSource = BezecVysledkyZoznam.vysledky;
                dataGridView3.DataSource = BezecVysledkyZoznam.poradie;

                //nastavím grupovanie podľa počtu odbehnutých kôl
                dataGridViewGrouper1.SetGroupOn(this.dataGridView1.Columns["Kolo"]);
                dataGridView1.Columns[2].DefaultCellStyle.Format = "HH:mm:ss:ff";
                dataGridView1.Columns[0].HeaderText = "Číslo bežca";
                dataGridView1.Columns[2].HeaderText = "Čas zápisu";
                dataGridView1.Columns[3].HeaderText = "Dĺžka kola";
                dataGridView1.Columns[4].HeaderText = "Číslo kola";
                dataGridView1.Columns[5].Visible = false;
                dataGridView3.Columns[3].Visible = false;
                dataGridView3.Columns[2].Visible = false;

                //skrytie všetkého čo užívateľ nepotrebuje vidieť a ja mu nechcem ukázať
                btnZavodZahajit.Visible = false;
                menuNastaveniaPreteku.Enabled = false;
                menuDatabaza.Enabled = false;
                menuCiselnikBezcov.Enabled = false;
                lblTextCiExistujeZadaneID.Text = "Pre spustenie nového behu reštartnite program";
                lblTextCiExistujeZadaneID.Visible = true;
            }
            else
            {
                MessageBox.Show("V zadanej zložke sa nenachádzajú potrebné súbory pre zobrazenie štatistík.");
            }
        }

        private void lblNavodNadpis_Click(object sender, EventArgs e)
        {

        }
    }
}

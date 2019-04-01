using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using FinishLine.Core;

namespace FinishLine
{
    public partial class Nastavenia : Form
    {
        public decimal DlzkaKola { get; set; } = 0.736M;
        public int PocetKol { get; set; } = 10;
        public int PocetMiestVitazov { get; set; } = 3;

        public Nastavenia()
        {
            InitializeComponent();

            //zisti či existuje subor
            if (FileTxt.SuborExistujeNastaveniaBezcov())
            {
                string nacitaneNastavenia = FileTxt.NacitajNastavenia();
                string[] nacitaneNastaveniaPoRiadkoch = nacitaneNastavenia.Split('\t');
                numDlzkaKola.Value = decimal.Parse(nacitaneNastaveniaPoRiadkoch[0]);
                numPocetKol.Value = int.Parse(nacitaneNastaveniaPoRiadkoch[1]);
                numPocetMiestVitazov.Value = int.Parse(nacitaneNastaveniaPoRiadkoch[2]);
            }
            else
            {
                numPocetKol.Value = PocetKol;
                numPocetMiestVitazov.Value = PocetMiestVitazov;
                numDlzkaKola.Value = DlzkaKola;
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Nastavenia_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DlzkaKola = numDlzkaKola.Value;
            PocetKol = (int)numPocetKol.Value;
            PocetMiestVitazov = (int)numPocetMiestVitazov.Value;
            FileTxt.ZapisNastavenia(DlzkaKola, PocetKol, PocetMiestVitazov);
            Close();

        }

        private void numDlzkaKola_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

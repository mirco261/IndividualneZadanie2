using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class HlavnyProgram : Form
    {
        public HlavnyProgram()
        {
            InitializeComponent();
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
            Staty.NacitajZoznamStatov();
        }
    }
}

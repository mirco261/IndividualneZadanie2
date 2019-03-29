using FinishLine.Core;
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
    public partial class CiselnikBezcov : Form
    {
        public CiselnikBezcov()
        {
            InitializeComponent();
            Staty.NacitajZoznamStatov();
            dgwCiselnikBezcov.DataSource = BezecZoznam.zoznamBezcov.Values.ToList<Bezec>();
            dataGridView1.DataSource = BezecZoznam.zoznamBezcov.Values.ToList<Bezec>();
        }

        /// <summary>
        /// refreshne datagridview na formulari
        /// </summary>
        public void refreshDataGridView()
        {
            dgwCiselnikBezcov.Refresh();
            dataGridView1.Refresh();
            dgwCiselnikBezcov.Update();
            dataGridView1.Update();
        }

        private void dgwCiselnikBezcov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwCiselnikBezcov_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnPridajBezca_Click(object sender, EventArgs e)
        {
            UpravaBezca f = new UpravaBezca();
            f.ShowDialog(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CiselnikBezcov_Load(object sender, EventArgs e)
        {


        }

        private void CiselnikBezcov_Shown(object sender, EventArgs e)
        {

        }

        private void CiselnikBezcov_Activated(object sender, EventArgs e)
        {
        }
    }
}

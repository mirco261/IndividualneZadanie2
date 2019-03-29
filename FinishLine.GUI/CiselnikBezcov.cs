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
    //public enum Pohlavie
    //{
    //    muž,
    //    žena,
    //}

    public partial class CiselnikBezcov : Form
    {
        public CiselnikBezcov()
        {
            InitializeComponent();
            Staty.NacitajZoznamStatov();
            //načítam do stlpca zdroj mojich krajin
            ((DataGridViewComboBoxColumn)dgwCiselnikBezcov.Columns[3]).DataSource = Staty.krajiny.ToList();
            ((DataGridViewComboBoxColumn)dgwCiselnikBezcov.Columns[4]).DataSource = Enum.GetValues(typeof(Pohlavie));


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
    }
}

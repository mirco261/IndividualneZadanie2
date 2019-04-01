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
            if (FileTxt.SuborExistujeZoznamBezcov())
            {
                FileTxt.NacitajZoznamBezcov();
            }
            dgwCiselnikBezcov.DataSource = BezecZoznam.zoznamBezcov.Values.ToList<Bezec>();
        }

        public void refreshDataGridView()
        {
            
        }

        private void dgwCiselnikBezcov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwCiselnikBezcov_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        /// <summary>
        /// Povolanie frm na vytvorenie bežca, ktorého potom pošlem do dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPridajBezca_Click(object sender, EventArgs e)
        {
            BezecPridaj f = new BezecPridaj();
            f.ShowDialog(this);

            //refreshnem zoznam bežcov
            dgwCiselnikBezcov.DataSource = "";
            dgwCiselnikBezcov.DataSource = BezecZoznam.zoznamBezcov.Values.ToList<Bezec>();
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

        /// <summary>
        /// Zistím si index riadka, vypýtam si následne ID ktoré je v prvom stlpci a povolám vymazanie údaja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVymazBezca_Click(object sender, EventArgs e)
        {
            int id = VratAktualneIdBezca();
            BezecZoznam.zoznamBezcovVymaz(id);

            //refreshnem zoznam bežcov
            dgwCiselnikBezcov.DataSource = "";
            dgwCiselnikBezcov.DataSource = BezecZoznam.zoznamBezcov.Values.ToList<Bezec>();
        }

        /// <summary>
        /// Zistím si index riadka, vypýtam si následne ID ktoré je v prvom stlpci a povolám frm na úpravu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpravBezca_Click(object sender, EventArgs e)
        {
            int id = VratAktualneIdBezca();
            BezecUprav f = new BezecUprav(id);
            f.ShowDialog(this);

            //refreshnem zoznam bežcov
            dgwCiselnikBezcov.DataSource = "";
            dgwCiselnikBezcov.DataSource = BezecZoznam.zoznamBezcov.Values.ToList<Bezec>();
        }

        /// <summary>
        /// Vráti mi id bežca - prvú bunku na riadku, kde sa nachádza ID bežca
        /// </summary>
        /// <returns></returns>
        private int VratAktualneIdBezca()
        {
            int x = dgwCiselnikBezcov.CurrentCell.RowIndex;
            int id = (int)(dgwCiselnikBezcov.Rows[x].Cells[0].Value);
            return id;
        }

        private void CiselnikBezcov_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileTxt.ZapisZoznamBezcov();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Zatvor frm
            Close();
        }
    }
}

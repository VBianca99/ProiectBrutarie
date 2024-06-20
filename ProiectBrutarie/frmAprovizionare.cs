using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProiectBrutarie
{
    public partial class frmAprovizionare : Form
    {

        FrmMeniu f1 = new FrmMeniu();

        public frmAprovizionare()
        {
            InitializeComponent();
        }

        private void furnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAprovizionare_Load(object sender, EventArgs e)
        {

        }

        private void comenziFurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comenzi_furnizori f = new Comenzi_furnizori();
            this.Hide();
            f.Show();
        }

        private void produseFurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produsefz f = new produsefz();
            this.Hide();
            f.Show();
        }

        private void adăugareFurnizorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adaugarefz f = new Adaugarefz();
            f.Show();
        }

        private void ștergereModificareFurnizorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modiffz f = new modiffz();
            f.Show();
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMeniu f = new FrmMeniu();
            this.Hide();
            f.Show();
        }

        private void raportComenziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaportCmzAproviz f = new RaportCmzAproviz();
            this.Hide();
            f.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBrutarie
{
    public partial class produsefz : Form
    {
        public produsefz()
        {
            InitializeComponent();
        }

        private void produsefz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_brutarie1DataSet.Produse_furnizori' table. You can move, or remove it, as needed.
            this.produse_furnizoriTableAdapter.Fill(this.baza_brutarie1DataSet.Produse_furnizori);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAprovizionare f = new frmAprovizionare();
            this.Hide();
            f.Show();
        }
    }
}

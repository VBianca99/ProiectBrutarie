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
    public partial class RaportFacturiClienti : Form
    {
        public RaportFacturiClienti()
        {
            InitializeComponent();
        }

        private void RaportFacturiClienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_brutarie1DataSet.Facturi_clienti' table. You can move, or remove it, as needed.
            this.Facturi_clientiTableAdapter.Fill(this.baza_brutarie1DataSet.Facturi_clienti);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMeniu f = new FrmMeniu();
            this.Hide();
            f.Show();
        }
    }
}

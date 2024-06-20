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
    public partial class frmClienti : Form
    {
        public frmClienti()
        {
            InitializeComponent();
        }

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza_brutarie1DataSet);

        }

        private void frmClienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_brutarie1DataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.baza_brutarie1DataSet.Clienti);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facturi_clienti f = new Facturi_clienti();
            this.Hide();
            f.Show();
        }
    }
}

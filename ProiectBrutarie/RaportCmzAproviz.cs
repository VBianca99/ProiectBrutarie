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
    public partial class RaportCmzAproviz : Form
    {

        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

        public RaportCmzAproviz()
        {
            InitializeComponent();
        }

        private void RaportCmzAproviz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_brutarie1DataSet.Comenzi_furnizori' table. You can move, or remove it, as needed.
            this.Comenzi_furnizoriTableAdapter.Fill(this.baza_brutarie1DataSet.Comenzi_furnizori);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAprovizionare f = new frmAprovizionare();
            this.Hide();
            f.Show();
        }
    }
    }


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
    public partial class Adaugarefz : Form
    {


        
        


        DataSet ds;
        OleDbDataAdapter da;
        


        public Adaugarefz()
        {
            InitializeComponent();
        }

        private void telfz_TextChanged(object sender, EventArgs e)
        {

        }

        private void idfz_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adaugarefz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_brutarie1DataSet.Furnizori' table. You can move, or remove it, as needed.
            this.furnizoriTableAdapter.Fill(this.baza_brutarie1DataSet.Furnizori);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

            string sql = "SELECT * FROM Furnizori";
            ds = new DataSet();
            da = new OleDbDataAdapter(sql, con);
            da.Fill(ds, "Furnizori");
            if (codfz.TextLength > 0)
                if (denfz.TextLength > 0)

                {
                    OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                    DataRow dRow = ds.Tables["Furnizori"].NewRow();
                    dRow[0] = codfz.Text;
                    dRow[1] = denfz.Text;
                    dRow[2] = prodfz.Text;
                    dRow[3] = locfz.Text;
                    dRow[4] = adresafz.Text;
                    dRow[5] = telfz.Text;
                    ds.Tables["Furnizori"].Rows.Add(dRow);
                    da.Update(ds, "Furnizori");
                    codfz.Text = "";
                    denfz.Text = "";
                    prodfz.Text = "";
                    locfz.Text = "";
                    adresafz.Text = "";
                    telfz.Text = "";

                    MessageBox.Show("Furnizorul a fost adăugat!");
                }

                else
                    MessageBox.Show("Toate câmpurile trebuie completate!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class modiffz : Form
    {

        DataSet dsfz;
        OleDbDataAdapter dafz;
        string sirSQL1;
        int pozitiefz;
        int nrRandurifz;


        public modiffz()
        {
            InitializeComponent();
        }

        private void modiffz_Load(object sender, EventArgs e)
        {
            if (FrmMeniu.con.State == ConnectionState.Closed)
                FrmMeniu.con.Open();
            dsfz = new DataSet();
            sirSQL1 = "SELECT * FROM Furnizori";
            dafz = new OleDbDataAdapter(sirSQL1, FrmMeniu.con);
            dafz.Fill(dsfz, "Furnizori");
            nrRandurifz = dsfz.Tables["Furnizori"].Rows.Count;
            pozitiefz = 0;
            Navigare();
        }


        void Navigare()
        {
            DataRow dRow = dsfz.Tables["Furnizori"].Rows[pozitiefz];
            codfz.Text = dRow.ItemArray.GetValue(0).ToString();
            denfz.Text = dRow.ItemArray.GetValue(1).ToString();
            prodfz.Text = dRow.ItemArray.GetValue(2).ToString();
            locfz.Text = dRow.ItemArray.GetValue(3).ToString();
            adresafz.Text = dRow.ItemArray.GetValue(4).ToString();
            telfz.Text = dRow.ItemArray.GetValue(5).ToString();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dR = dsfz.Tables["Furnizori"].Rows[pozitiefz];
            dR[0] = codfz.Text;
            dR[1] = denfz.Text;
            dR[2] = prodfz.Text;
            dR[3] = locfz.Text;
            dR[4] = adresafz.Text;
            dR[5] = telfz.Text;

            try
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(dafz);
                dafz.Update(dsfz, "Furnizori");
                MessageBox.Show("S-au actualizat datele!");
            }
            catch
            {
                MessageBox.Show("Nu s-a putut actualiza datele!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur doriti sa stergeti?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dsfz.Tables["Furnizori"].Rows[pozitiefz].Delete();
                OleDbCommandBuilder cb = new OleDbCommandBuilder(dafz);
                dafz.Update(dsfz, "Furnizori");
                nrRandurifz--;
                if (pozitiefz == nrRandurifz) pozitiefz = nrRandurifz - 1;
                Navigare();
                MessageBox.Show("Furnizorul a fost șters!");
            }
            else
                MessageBox.Show("Furnizorul nu a fost șters!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pozitiefz != 0)
            {
                pozitiefz = 0;
                Navigare();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pozitiefz > 0)
            {
                pozitiefz--;
                Navigare();
            }
            else
                MessageBox.Show("Este prima inregistrare!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pozitiefz != nrRandurifz - 1)
            {
                pozitiefz++;
                Navigare();
            }
            else
                MessageBox.Show("Nu mai sunt inregistrari!");
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (pozitiefz != nrRandurifz - 1)
            {
                pozitiefz = nrRandurifz - 1;
                Navigare();
            }
        }
    }
}

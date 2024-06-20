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
    public partial class Comenzi_furnizori : Form
    {


        DataSet ds;
        OleDbDataAdapter da;
        string sirSQL;
        int pozitie;
        int nrRanduri;


        public Comenzi_furnizori()
        {
            InitializeComponent();
        }

        private void Comenzi_furnizori_Load(object sender, EventArgs e)
        {

             OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

            if (con.State == ConnectionState.Closed)
                con.Open();
            ds = new DataSet();
            sirSQL = "SELECT * FROM Comenzi_furnizori";
            da = new OleDbDataAdapter(sirSQL, con);
            da.Fill(ds, "Comenzi_Furnizori");
            pozitie = 0;
            nrRanduri = ds.Tables["Comenzi_furnizori"].Rows.Count;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            navigare();
        }



        void navigare()
        {
            DataRow dRow = ds.Tables["Comenzi_furnizori"].Rows[pozitie];
            textBox1.Text = dRow.ItemArray.GetValue(0).ToString();
            textBox2.Text = dRow.ItemArray.GetValue(1).ToString();
            textBox3.Text = dRow.ItemArray.GetValue(2).ToString();
            textBox4.Text = dRow.ItemArray.GetValue(3).ToString();
            textBox5.Text = dRow.ItemArray.GetValue(4).ToString();


        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pozitie != 0)
            {
                pozitie = 0;
                navigare();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pozitie > 0)
            {
                pozitie--;
                navigare();
            }
            else
            {
                MessageBox.Show("Sunteti pe prima inregistrare!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pozitie != nrRanduri - 1)
            {
                pozitie++;
                navigare();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pozitie != nrRanduri - 1)
            {
                pozitie = nrRanduri - 1;
                navigare();
            }
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            btnAddNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            pozitie = 0;
            navigare();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

            DataRow dR = ds.Tables["Comenzi_furnizori"].Rows[pozitie];
            dR[0] = textBox1.Text;
            dR[1] = textBox2.Text;
            dR[2] = textBox3.Text;
            dR[3] = textBox4.Text;
            dR[4] = textBox5.Text;


            try
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                da.Update(ds, "Comenzi_furnizori");
                MessageBox.Show("S-au actualizat datele!");
            }
            catch
            {
                MessageBox.Show("Datele nu s-au putut actualiza!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur doriti sa stergeti inregistrarea?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ds.Tables["Comenzi_furnizori"].Rows[pozitie].Delete();
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                da.Update(ds, "Comenzi_furnizori");
                nrRanduri--;
                if (pozitie == nrRanduri)
                    pozitie = nrRanduri - 1;
                navigare();
                MessageBox.Show("S-a sters inregistrarea!");

            }
            else
                MessageBox.Show("Nu s-a sters inregistrarea");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");


            DataRow dRow;
            dRow = ds.Tables["Comenzi_furnizori"].NewRow();
            dRow["Nr_comanda"] = textBox1.Text;
            dRow["Cod_furnizor"] = textBox2.Text;
            dRow["Unitate_de_masura"] = textBox3.Text;
            dRow["Cantitate"] = textBox4.Text;
            dRow["Pret_unitar"] = textBox5.Text;
            ds.Tables["Comenzi_furnizori"].Rows.Add(dRow);

            try
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                da.Update(ds, "Comenzi_furnizori");
                MessageBox.Show("S-a salvat noua comandă!");
                nrRanduri++;
                pozitie = nrRanduri - 1;
                btnAddNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Nu s-a putut realiza salvarea");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAprovizionare f = new frmAprovizionare();
            this.Hide();
            f.Show();
        }
    }
}

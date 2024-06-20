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
    public partial class prodfz : Form
    {

        DataSet ds;
        OleDbDataAdapter da;
        string sirSQL;
        int pozitie;
        int nrRanduri;
         FrmMeniu f1 = new FrmMeniu(); //avem nevoie de form 1 la iesire si pt conexiunea noastra care e definita in form 1 de tip publica
        int nr_randuri;

        public prodfz()
        {
            InitializeComponent();
        }
        /*
        private void btnAddNew_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            btnAddNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        */
        private void prodfz_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");


            /*
            // TODO: This line of code loads data into the 'baza_brutarie1DataSet.Produse_furnizori' table. You can move, or remove it, as needed.
            this.produse_furnizoriTableAdapter.Fill(this.baza_brutarie1DataSet.Produse_furnizori);
            if (con.State == ConnectionState.Closed)
                con.Open();
            ds = new DataSet();
            sirSQL = "SELECT * FROM Produse_furnizori";
            da = new OleDbDataAdapter(sirSQL, con);
            da.Fill(ds, "Produse_furnizori");

            dataGridView1.DataSource = ds.Tables["Produse_furnizori"];

            pozitie = 0;
            nrRanduri = ds.Tables["Produse_furnizori"].Rows.Count;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            navigare();




            //aducem din baza de adte tab categorie
            string sql = "select*from Produse_furnizori";
            da = new OleDbDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds, "Produse_furnizori");
            //afisam ce ne returneaza selectul in datagridview
            dataGridView1.DataSource = ds.Tables["Produse_furnizori"];
            //trebuie sa vedem care randuri avem
            nr_randuri = ds.Tables["Produse_furnizori"].Rows.Count;

            */

            string sql = @"select Produse.Cod_podus, Produse_furnizori.Nume_produs, Produse_furnizori.UM, Produse_furnizori.Cod_produs from Produse, Produse_furnizori where Produse.Cod_podus=Produse_furnizori.Cod_produs";
            da = new OleDbDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds, "Produse_furnizori");
            dataGridView1.DataSource = ds.Tables["Produse_furnizori"];


        }


        private void cauta()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

            OleDbCommand query = new OleDbCommand(@"SELECT Produse.Cod_podus, Produse_furnizori.Nume_produs, Produse_furnizori.UM, Produse_furnizori.Cod_produs from Produse, Produse_furnizori where Produse.Cod_podus=Produse_furnizori.Cod_produs And Produse_furnizori.Nume_produs Like @denpr", con);
            query.Parameters.AddWithValue("@denpr", "%" + textBox4.Text + "%");
      
            da = new OleDbDataAdapter(query);
            ds = new DataSet();
            da.Fill(ds, "Produse_furnizori");
            dataGridView1.DataSource = ds.Tables["Produse_furnizori"];
        }
        /*

        void navigare()
        {
            DataRow dRow = ds.Tables["Produse_furnizori"].Rows[pozitie];
            textBox1.Text = dRow.ItemArray.GetValue(0).ToString();
            textBox2.Text = dRow.ItemArray.GetValue(1).ToString();
            textBox3.Text = dRow.ItemArray.GetValue(2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pozitie != 0)
            {
                pozitie = 0;
                navigare();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
        */
        /*
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
          /*
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

            DataRow dR = ds.Tables["Produse_furnizori"].Rows[pozitie];
            dR[0] = textBox1.Text;
            dR[1] = textBox2.Text;
            dR[2] = textBox3.Text;

            try
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                da.Update(ds, "Produse_furnizori");
                MessageBox.Show("S-au actualizat datele!");
            }
            catch
            {
                MessageBox.Show("Datele nu s-au putut actualiza!");
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*  if (MessageBox.Show("Sigur doriti sa stergeti inregistrarea?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ds.Tables["Produse_furnizori"].Rows[pozitie].Delete();
                    OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                    da.Update(ds, "Produse_furnizori");
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
            /*
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

            DataRow dRow;
            dRow = ds.Tables["Produse_furnizori"].NewRow();
            dRow["Cod_produs"] = textBox1.Text;
            dRow["Nume_produs"] = textBox2.Text;
            dRow["UM"] = textBox3.Text;
            ds.Tables["Produse_furnizori"].Rows.Add(dRow);

            try
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                da.Update(ds, "Produse_furnizori");
                MessageBox.Show("S-a salvat noul produs!");
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
        */
        private void button5_Click(object sender, EventArgs e)
        {
            frmAprovizionare f = new frmAprovizionare();
            this.Hide();
            f1.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            /*
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

            OleDbCommand sql = new OleDbCommand("select*from Produse_furnizori", con);
            if (textBox1.Text != "")
            {
                sql.CommandText += " where Nume_produs Like @Nume_produs";
                sql.Parameters.AddWithValue("@Nume_produs", "%" + textBox4.Text + "%");
            }
            da = new OleDbDataAdapter(sql);
            ds = new DataSet();
            da.Fill(ds, "Produse_furnizori");
            dataGridView1.DataSource = ds.Tables["Produse_furnizori"];
            */
            cauta();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

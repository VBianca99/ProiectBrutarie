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
    public partial class Facturi_clienti : Form
    {

        DataSet ds;
        OleDbDataAdapter da;
        FrmMeniu conn = new FrmMeniu(); //var de tipul formei 1

        public Facturi_clienti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FrmMeniu.con != null && FrmMeniu.con.State == ConnectionState.Closed)
                FrmMeniu.con.Open();
            try
            {
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = FrmMeniu.con;
                cmd2.CommandText = @"Insert into Facturi_clienti (Nr_factura, Data_factura, Cod_client, Mijloc_transport, Delegat, Cota_TVA) values (@Nr_factura, @Data_factura, @Cod_client, @Mijloc_transport, @Delegat, @Cota_TVA)";
                cmd2.Parameters.AddWithValue("@Nr_factura", txt_codcomanda.Text);
                cmd2.Parameters.AddWithValue("@Data_factura", dateTimePicker1.Text);

                cmd2.Parameters.AddWithValue("@Cod_client", txt_cantitate.Text);
                cmd2.Parameters.AddWithValue("@Mijloc_transport", txt_codprodus.Text);
                
                cmd2.Parameters.AddWithValue("@Delegat", txt_codfurnizor.Text);
                cmd2.Parameters.AddWithValue("@Cota_TVA", txtCota.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Comanda inregistrata");
                //facem try pt ca codcom e pk si daca introducem de 2 ori aceeasi valoare=>eroare
            }
            catch
            {
                MessageBox.Show("EROARE: Comanda deja existenta");
            }
        }

        private void txt_codfurnizor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantitate_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMeniu f = new FrmMeniu();
            this.Hide();
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Facturi_clienti_Load(object sender, EventArgs e)
        {
            string sql = @"select Facturi_clienti.Nr_factura, Facturi_clienti.Data_factura, Clienti.Cod_client, Facturi_clienti.Mijloc_transport, Delegat, Cota_TVA from Facturi_clienti, Clienti where Facturi_clienti.Cod_client=Clienti.Cod_client";
            da = new OleDbDataAdapter(sql, FrmMeniu.con); //var noastra si con pt ca se afla in f1
            ds = new DataSet();
            da.Fill(ds, "Facturi_clienti");
            dataGridView1.DataSource = ds.Tables["Facturi_clienti"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RaportFacturiClienti f = new RaportFacturiClienti();
            this.Hide();
            f.Show();
        }
    }
    }


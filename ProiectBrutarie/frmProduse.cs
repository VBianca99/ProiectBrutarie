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
    public partial class frmProduse : Form
    {

        DataSet ds;
        OleDbDataAdapter da;
        FrmMeniu f = new FrmMeniu();


        public frmProduse()
        {
            InitializeComponent();
        }

        private void frmProduse_Load(object sender, EventArgs e)
        {
             OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\baza_brutarie1.accdb");

        string sql = @"select Produse.Cod_podus, Produse.Nume_produs, UM, Retete.Cod_produs_vizat from Produse, Retete where Produse.Cod_podus=Retete.Cod_produs_vizat";
            da = new OleDbDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds, "Produse");
            dataGridView1.DataSource = ds.Tables["Produse"];

        }


        private void cauta()
        {

            OleDbCommand query = new OleDbCommand(@"SELECT Produse.Cod_podus, Produse.Nume_produs, UM, Retete.Cod_produs_vizat from Produse, Retete where Produse.Cod_podus=Retete.Cod_produs_vizat And Produse.Nume_produs Like @denpr And Retete.Cod_produs_vizat LIKE @denfz And Produse.UM LIKE @um", FrmMeniu.con);
            query.Parameters.AddWithValue("@denpr", "%" + txtdenprod.Text + "%");
            query.Parameters.AddWithValue("@denfz", "%" + txtdenfz.Text + "%");
            query.Parameters.AddWithValue("@um", "%" + um.Text + "%");
            da = new OleDbDataAdapter(query);
            ds = new DataSet();
            da.Fill(ds, "Produse");
            dataGridView1.DataSource = ds.Tables["Produse"];
        }

        private void txtdenprod_TextChanged(object sender, EventArgs e)
        {
            cauta();
        }

        private void txtdenfz_TextChanged(object sender, EventArgs e)
        {
            cauta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMeniu f = new FrmMeniu();
            this.Hide();
            f.Show();

        }

        private void um_TextChanged(object sender, EventArgs e)
        {
            cauta();
        }
    }
}

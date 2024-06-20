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

    public partial class frmVanzari : Form
    {

        DataSet ds;
        OleDbDataAdapter da;
        FrmMeniu f1 = new FrmMeniu();

        public frmVanzari()
        {
            InitializeComponent();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            OleDbCommand sql = new OleDbCommand("SELECT * FROM Vânzări", FrmMeniu.con);
            if (textBox1.Text != "")
            {
                sql.CommandText += " WHERE Cod_produs LIKE @Cod_produs ";
                sql.Parameters.AddWithValue("@Cod_produs", "%" + textBox1.Text + "%");
            }
            da = new OleDbDataAdapter(sql);
            // cod comun in cazul ambelor variante
            ds = new DataSet();
            da.Fill(ds, "Vânzări");
            dataGridView1.DataSource = ds.Tables["Vânzări"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

            FrmMeniu f = new FrmMeniu();
            this.Hide();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnCauta_Click(sender, e);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            string sirSqlUpdate = "UPDATE Vânzări SET Cod_produs = @Cod_produs WHERE Nr_factura = @Nr_factura";
            OleDbCommand comandaUpdate = new OleDbCommand(sirSqlUpdate, FrmMeniu.con);
            // Comenzile Parameters.Add de mai jos adauga un parametru specificand
            // numele parametrului (de ex. @den_categ), tipul de data, lung. campului si numele campului

            comandaUpdate.Parameters.Add("@Cod_produs", OleDbType.VarChar, 50, "Cod_produs");
            comandaUpdate.Parameters.Add("@Nr_factura", OleDbType.Integer, 4, "Nr_factura");

            string sirSqlInsert = "INSERT INTO Vânzări (Cod_produs) VALUES (@Cod_produs)";
            OleDbCommand comandaInsert = new OleDbCommand(sirSqlInsert, FrmMeniu.con);
            comandaInsert.Parameters.Add("@Cod_produs", OleDbType.VarChar, 50, "Cod_produs");

            string sirSqlDelete = "DELETE FROM Vânzări WHERE Nr_factura = @Nr_factura";
            OleDbCommand comandaDelete = new OleDbCommand(sirSqlDelete, FrmMeniu.con);
            comandaDelete.Parameters.Add("@Nr_factura", OleDbType.Integer, 4, "Nr_factura");

            da.InsertCommand = comandaInsert;
            da.UpdateCommand = comandaUpdate;
            da.DeleteCommand = comandaDelete;
            da.Update(ds, "Vânzări");

            MessageBox.Show("Tabela a fost actualizată");
        }
    }
}

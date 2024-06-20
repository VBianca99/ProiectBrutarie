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
    public partial class frmLogin : Form
    {

       


        public frmLogin()
        {
            InitializeComponent();
        }

 

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private int j = 0;  //pentru a numara cate incercari de parola s-au efectuat
        private void cmdOK_Click(object sender, EventArgs e)
        {
            j = j + 1;
            if (txtUsername.Text == "user")
            {
                if (txtPassword.Text == "password")
                {
                    FrmMeniu f = new FrmMeniu();
                    f.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Parola e incorectă!") ;
            }
            else
                MessageBox.Show("Username-ul e incorect!");
            if (j == 5)   //pentru maxim 5 incercari
            {
                MessageBox.Show("Ati avut deja 5 încercări!") ;
                Application.Exit();
            }
        }

        private void cmdIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdOK_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

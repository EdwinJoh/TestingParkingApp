using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingParkingApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtUserPassword.Text == "")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Login Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

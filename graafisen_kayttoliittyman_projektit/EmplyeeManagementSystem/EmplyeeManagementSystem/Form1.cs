using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmplyeeManagementSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }


        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void signin_btn_Click(object sender, EventArgs e)
        {
            string myconnectionString = @"server=localhost;database=ems_system;userid=root;password=;";
            MySqlConnection con = null;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                con = new MySqlConnection(myconnectionString);
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Command.Text = "SELECT * FROM login_tb WHERE Username='"+ textBoxUsername.Text+"' AND Password='"+textBoxPassword.Text+"' ";
                dr = cmd.ExecuteReader();
                if (dr.Reade())
                {
                    MessageBox.Show("Succes");
                }
                else
                {
                    MessageBox.Show("Please enter the correct usernnme and password");
                }
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}

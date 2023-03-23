using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellivarausjarjestelma
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // if the username and the password exists
            if (table.Rows.Count > 0)
            {
                // show the main form
                this.Hide();
                Main_Form mform = new Main_Form();
                mform.Show();
            }
            else
            {
                if (textBoxUsername.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username Or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void signIn_Load(object sender, EventArgs e)
        {

        }
    }
}

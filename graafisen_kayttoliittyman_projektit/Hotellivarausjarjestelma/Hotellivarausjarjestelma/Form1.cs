using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellivarausjarjestelma
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageClients_Click(object sender, EventArgs e)
        {
            ManageClients manageCF = new ManageClients();

            manageCF.ShowDialog();

        }

        private void manageReservations_Click(object sender, EventArgs e)
        {
            ManageRooms manageRF = new ManageRooms();

            manageRF.ShowDialog();
        }

        private void manageRooms_Click(object sender, EventArgs e)
        {

            ManageReservations manageRSVF = new ManageReservations();

            manageRSVF.ShowDialog();
        }
    }
}

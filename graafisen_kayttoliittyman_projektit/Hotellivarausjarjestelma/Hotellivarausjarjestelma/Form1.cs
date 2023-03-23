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
    public partial class Main_Form_FormClosing : Form
    {
        public Main_Form_FormClosing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageClients_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageCF = new ManageClientsForm();

            manageCF.ShowDialog();

        }

        private void manageReservations_Click(object sender, EventArgs e)
        {
            ManageRoomsForm manageRF = new ManageRoomsForm();

            manageRF.ShowDialog();
        }

        private void manageRooms_Click(object sender, EventArgs e)
        {

            ManageReservationsForm manageRSVF = new ManageReservationsForm();

            manageRSVF.ShowDialog();
        }
    }
}

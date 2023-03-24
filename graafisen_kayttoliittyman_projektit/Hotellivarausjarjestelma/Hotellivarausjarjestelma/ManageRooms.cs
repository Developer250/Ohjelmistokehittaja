using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hotellivarausjarjestelma
{
    public partial class ManageRooms : Form
    {
        public ManageRooms()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        private void ManageRooms_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {

            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            string phone = textBoxPhone.Text;
            string free = "";

            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                if (radioButtonYES.Checked)
                {
                    free = "Yes";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "No";
                }

                if (room.addRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {

            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            String phone = textBoxPhone.Text;
            String free = "";

            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                if (radioButtonYES.Checked)
                {
                    free = "Yes";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "No";
                }

                if (room.editRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);

                if (room.removeRoom(number))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1dataGridView1.DataSource = room.getRooms();
        }
    }
}

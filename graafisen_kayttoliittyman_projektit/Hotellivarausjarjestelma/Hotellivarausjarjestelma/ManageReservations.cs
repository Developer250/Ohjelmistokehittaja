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
    public partial class ManageReservations : Form
    {
        public ManageReservations()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        private void dateTimePickerIN_FormatChanged(object sender, EventArgs e)
        {

        }

        private void ManageReservations_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            int type = Convert.ToInt32(comboBoxRoomNumber.SelectedValue.ToString());
            comboBoxRoomNumber.DataSource = room.roomByType();
        }

        private void buttonAddReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                // date in must be = or > today date
                // date out must be = or > date in
                if (DateTime.Compare(dateIn.Date, DateTime.Now.Date) < 0)
                {
                    MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DateTime.Compare(dateOut.Date, dateIn.Date) < 0)
                {
                    MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.addReservation(roomNumber, clientID, dateIn, dateOut))
                    {
                        // set the room free column to NO
                        // you can add a message if the room is edited
                        room.setRoomFree(roomNumber, "No");
                        dataGridView1.DataSource = reservation.getAllReserv();
                        MessageBox.Show("New Reservation Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation NOT Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonEditReserv_Click(object sender, EventArgs e)
        {

            try
            {
                int rservID = Convert.ToInt32(textBoxReservId.Text);
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                // date in must be = or > today date
                // date out must be = or > date in
                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOut < dateIn)
                {
                    MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //rservId
                    if (reservation.editReserv(rservID, roomNumber, clientID, dateIn, dateOut))
                    {
                        // set the room free column to NO
                        // you can add a message if the room is edited
                        room.setRoomFree(roomNumber, "No");
                        dataGridView1.DataSource = reservation.getAllReserv();
                        MessageBox.Show("Reservation Data Updated", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation NOT Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonRemoveReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBoxReservId.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                if (reservation.removeReserv(reservId))
                {
                    dataGridView1.DataSource = reservation.getAllReserv();
                    // after deleting a reservation we need to set free column to 'Yes'

                    room.setRoomFree(roomNumber, "Yes");
                    MessageBox.Show("Reservation Deleted", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearReserv_Click(object sender, EventArgs e)
        {
            textBoxClientID.Text = "";
            textBoxReservID.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;

        }
    }
}

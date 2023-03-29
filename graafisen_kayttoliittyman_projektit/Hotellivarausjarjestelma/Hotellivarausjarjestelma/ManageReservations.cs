using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotellivarausjarjestelma
{
    public partial class ManageReservations : Form
    {
        public ManageReservations()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        RESERVATION reservation = new RESERVATION();

        private void ManageReservations_Load(object sender, EventArgs e)
        {
            //display room's type
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            //display free room's number depending on selected type
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            comboBoxRoomNumber.DataSource = room.roomByType(type);
            comboBoxRoomNumber.DisplayMember = "number";
            comboBoxRoomNumber.ValueMember = "number";

            dataGridView1Reservations.DataSource = reservation.GetAllReservations();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxReservID.Text = "";
            textBoxClientID.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;
        }

        private void buttonAddReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date must be Greater Or Equal than Current Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOut < dateIn)
                {
                    MessageBox.Show("The DateOut must be Greater Or Equal than DateIn", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.addReservation(roomNumber, clientID, dateIn, dateOut))
                    {
                        room.SetRoomFree(roomNumber, "NO");
                        dataGridView1Reservations.DataSource = reservation.GetAllReservations();
                        MessageBox.Show("Reservation made successfully!", "Make Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonClearReserv.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Reservation not added!", "Make Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Make Reservation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationID = Convert.ToInt32(textBoxClientID.Text);
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(dataGridView1Reservations.CurrentRow.Cells[1].Value.ToString());
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date must be Greater Or Equal than Current Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOut < dateIn)
                {
                    MessageBox.Show("The DateOut must be Greater Or Equal than DateIn", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.editReserv(reservationID, roomNumber, clientID, dateIn, dateOut))
                    {
                        room.SetRoomFree(roomNumber, "NO");
                        dataGridView1Reservations.DataSource = reservation.GetAllReservations();
                        MessageBox.Show("Reservation data updated!", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Reservation not updated!", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Reservation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveReserv_Click(object sender, EventArgs e)
        {

            try
            {
                int reservationID = Convert.ToInt32(textBoxReservID.Text);
                int roomNumber = Convert.ToInt32(dataGridView1Reservations.CurrentRow.Cells[1].Value.ToString());

                if (reservation.removeReserv(reservationID))
                {
                    room.SetRoomFree(roomNumber, "YES");
                    dataGridView1Reservations.DataSource = reservation.GetAllReservations();
                    MessageBox.Show("Reservation deleted successfully!", "Reservation Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonClearReserv.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR - Reservation not deleted!", "Reservation Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete reservation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //display room's number depending on selected type
                int type = Convert.ToInt32(comboBoxRoomNumber.SelectedValue.ToString());
                comboBoxRoomNumber.DataSource = room.roomByType(type);
                comboBoxRoomNumber.DisplayMember = "number";
                comboBoxRoomNumber.ValueMember = "number";
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Room number error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1Reservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxReservID.Text = dataGridView1Reservations.CurrentRow.Cells[0].Value.ToString();

            //room ID
            int roomID = Convert.ToInt32(dataGridView1Reservations.CurrentRow.Cells[1].Value.ToString());

            //room type from ddl
            comboBoxRoomType.SelectedValue = room.GetRoomType(roomID);

            //room number from ddl
            comboBoxRoomNumber.SelectedValue = roomID;
            textBoxClientID.Text = dataGridView1Reservations.CurrentRow.Cells[2].Value.ToString();

            dateTimePickerIN.Value = Convert.ToDateTime(dataGridView1Reservations.CurrentRow.Cells[3].Value.ToString());
            dateTimePickerOUT.Value = Convert.ToDateTime(dataGridView1Reservations.CurrentRow.Cells[4].Value.ToString());


        }
    }
}

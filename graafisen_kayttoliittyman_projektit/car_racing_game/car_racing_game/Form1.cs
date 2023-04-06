using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Hotel_System;

namespace Hotel_Management_System
{
    public partial class ReservationForm : Form
    {
        roomClass room = new roomClass();
        public ReservationForm()
        {
            initializeComponent();
        }

        private void ReservationForm_Load(object sender, System.EventArgs e)
        {
            //To show a room type in combobox
            comboBox_roomType.DataSource = room.getRoomType();
            comboBox_roomType.DisplayMember = "Label";
            comboBox_roomType.ValueMember = "CategoryId";

            //Display room's number depending on the room type
            //Display the room's status is free

            int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());
            comboBox_roomNo.DataSource = reservation.roomByType(type);
            comboBox_roomNo.DisplayMember = "RoomId";
            comboBox_roomNo.ValueMember = "RoomId";

            dataGridView_reserv.DefaultCellStyle.ForeColor = Color.Black;
            //To show reservationlist in datagridview
            dataGridView_reserv.DataSource = reservation.getReserv();
        }

        private void comboBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display room's number depending on the room type
            //Display the room's status is free
            try
            {
                int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());
                comboBox_roomNo.DataSource = reservation.roomByType(type);
                comboBox_roomNo.DisplayMember = "RoomId";
                comboBox_roomNo.ValueMember = "RoomId";
            }
            catch(Exception)
            {
                //Nothing
            }
        }

        //Save button
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string guestId = textBox_guestId.Text;
                string roomNo = comboBox_roomNo.SelectedValue.ToString();
                DateTime dIn = dateTimePicker_dateIn.Value;
                DateTime dOUT = dateTimePicker_dateOUT.Value;

                if (reservation.addReserv(guestId, roomNo, dIn, dOUT))
                {
                    MessageBox.Show("New Reservation add succesfully", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reservation not add!", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reservation Add Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

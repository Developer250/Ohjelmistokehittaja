using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System
    {
        class Reservation
        {
            DBConnect connect = new DBConnect();
            //get all reservations
            public DataTable roomByType(int type)
            {
                string selectQuery = "SELECT * FROM ´room´ WHERE ´RoomType´=@type AND ´RoomStatus´='Free'";
                MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
                command.parameters.Add("@type", MySqlDbType.Int32).Value = type;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }

           //To get reservation table
             public DataTable getReserv()
             {
                string selectQuerry = "SELECT * FROM ´reservation´";
                MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                 return table;
             }

        //make new reservation
        public bool addReserv(string guestId, string roomNo, DateTime dateIn, DateTime dateOut)
            {
                string insertQuerry = "INSERT INTO `reservation`(`GuestId`,`RoomNo`, `DateIN`, `DateOUT`) VALUES (@Gid, @Din, @Dout)";
                 MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
                // @Gid, @Rno, @Din, @Dout
                command.Parameters.Add("@number", MySqlDbType.varChar).Value = guestId;
                command.Parameters.Add("@client", MySqlDbType.varChar).Value = roomNo;
                command.Parameters.Add("@dateIn", MySqlDbType.Date).Value = dateIn;
                command.Parameters.Add("@dateOut", MySqlDbType.Date).Value = dateOut;

                connect.OpenCon();
                if (command.ExecuteNonQuery() == 1)
                {
                connect.CloseCon();
                    return true;
                }
                else
                {
                connect.CloseCon();
                    return false;
                }
            }

            //edit reservation
            public bool EditReservation(int id, int number, int client, DateTime dateIn, DateTime dateOut)
            {
                MySqlCommand command = new MySqlCommand();
                String queryUpdate = "UPDATE `reservations` SET `roomNumber`=@number,`clientid`=@client,`dateIn`=@dateIn,`dateOut`=@dateOut WHERE id=@id";
                command.CommandText = queryUpdate;
                command.Connection = conn.GetConnection();

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@number", MySqlDbType.Int32).Value = number;
                command.Parameters.Add("@client", MySqlDbType.Int32).Value = client;
                command.Parameters.Add("@dateIn", MySqlDbType.Date).Value = dateIn;
                command.Parameters.Add("@dateOut", MySqlDbType.Date).Value = dateOut;

                 connect.OpenCon();
                if (command.ExecuteNonQuery() == 1)
                {
                connect.CloseCon();
                    return true;
                }
                else
                {
                connect.CloseCon();
                    return false;
                }
            }

            //remove room
            public bool RemoveReservation(int id)
            {
                MySqlCommand command = new MySqlCommand();
                String queryDelete = "DELETE FROM reservations WHERE id=@id";
                command.CommandText = queryDelete;
                command.Connection = conn.GetConnection();

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                 connect.OpenCon();
                if (command.ExecuteNonQuery() == 1)
                {
                connect.CloseCon();
                    return true;
                }
                else
                {
                connect.CloseCon();
                    return false;
                }
            }

        }
    }
}

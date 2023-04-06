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

        //add a new reservation
        public bool addReserv(string guestId, string roomNo, DateTime dateIn, DateTime dateOut)
            {
                string insertQuerry = "INSERT INTO `reservation`(`GuestId`,`RoomNo`, `DateIN`, `DateOUT`) VALUES (@Gid, @Din, @Dout)";
                 MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
                // @Gid, @Rno, @Din, @Dout
                command.Parameters.Add("@Gid", MySqlDbType.varChar).Value = guestId;
                command.Parameters.Add("@Rno", MySqlDbType.varChar).Value = roomNo;
                command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
                command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

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

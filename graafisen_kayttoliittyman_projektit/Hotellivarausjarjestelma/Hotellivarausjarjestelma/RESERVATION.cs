using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotellivarausjarjestelma
{
    class RESERVATION
    {
        CONNECT conn = new CONNECT();
        RESERVATION reservation = new RESERVATION();
        public DataTable GetAllReservations()
        {
            MySqlCommand command = new MySqlCommand("SELECT *  FROM `reservations`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }


        public bool addReservation(int roomNumber, int clientId, DateTime dateIN, DateTime dateOUT)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservations`(`roomNumber`, `clientid`, `DateIn`, `DateOut`) VALUES (@rnm, @cid, @din, @dout)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            //(@rnm, @cid, @din, @dout
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIN;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOUT;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        public bool editReserv(int roomNumber, int clientId,int reservId, DateTime dateIN, DateTime dateOUT)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `reservations` SET `roomNumber`=@rnm ,`clientid`=@cid ,`DateIn`=@din ,`DateOut`= @dout WHERE  `reservid`=@rvid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            //(@rnm, @cid, @din, @dout,@rvid
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservId;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIN;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOUT;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        public bool removeReserv(int rsv_id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `reservations` WHERE `reservid`=@rvid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            //@number
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = rsv_id;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }
}

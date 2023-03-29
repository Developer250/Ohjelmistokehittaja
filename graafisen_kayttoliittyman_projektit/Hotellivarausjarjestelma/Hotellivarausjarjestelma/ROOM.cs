using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Hotellivarausjarjestelma
{
    internal class ROOM
    {

        CONNECT conn = new CONNECT();

        public DataTable roomTypeList()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_category`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable roomByType(int number)
        {

            MySqlCommand command = new MySqlCommand("UPDATE `rooms` SET =`free`= 'NO'`WHERE `number`=@um", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            //@typ
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool addRoom(int number,int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES (@num,  @tp, @phn, @fr)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            //@num, @tp,@phn, @fr
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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

        //set free to NO/YES
        public bool SetRoomFree(int number, String isFree)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `rooms` SET `free`=@isFree' WHERE `number`=@number", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@number", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@isFree", MySqlDbType.VarChar).Value = isFree;

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


        public DataTable getRooms()
        {

            MySqlCommand command = new MySqlCommand("SELECT *  FROM ´rooms´", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //get room type id
        public int GetRoomType(int number)
        {
            MySqlCommand command = new MySqlCommand("SELECT type FROM rooms WHERE number=@number", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            command.Parameters.Add("@number", MySqlDbType.Int32).Value = number;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        public bool editRoom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `rooms` SET `type`=@tp, `phone`=@phn,`free`= @fr WHERE `number`=@num";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            //@num, @tp,@phn, @fr
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;
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

        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELECT *  FROM clients", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool removeRoom(int number)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `rooms` WHERE `number`= @num";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            //@number
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            
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

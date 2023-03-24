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

            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_category`", conn.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

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
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.VarChar).Value = type;
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

        public DataTable getRooms()
        {

            MySqlCommand command = new MySqlCommand("SELCET *  FROM `rooms`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool editRoom(int number, int type, String lname, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `clients` SET `first_name` =@fnm, `last_name` =@lnm, `phone` =@phn, `country` =@cnt";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            //@num, @tp,@phn, @fr
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.VarChar).Value = type;
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

        public bool editClient(int id, String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `clients` SET `first_name` =@fnm, `last_name` =@lnm, `phone` =@phn, `country` =@cnt";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            //@num, @tp,@phn, @fr
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@tp", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = country;

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
            MySqlCommand command = new MySqlCommand("SELCET *  FROM `clients`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }

    
}

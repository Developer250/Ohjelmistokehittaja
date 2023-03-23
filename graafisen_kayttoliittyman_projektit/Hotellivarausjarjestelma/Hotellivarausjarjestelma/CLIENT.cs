using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Hotellivarausjarjestelma
{
    internal class CLIENT
    {
        CONNECT conn = new CONNECT();

        public bool insertClient(String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES(@fnm, @lnm, @phn, @cnt)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();
            //`first_name`, `lasdt_name`, `phone`, `country`
           command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
           command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
           command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = phone;
           command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = country;

            conn.openConnection();

            if(command.ExecuteNonQuery() == 1)
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

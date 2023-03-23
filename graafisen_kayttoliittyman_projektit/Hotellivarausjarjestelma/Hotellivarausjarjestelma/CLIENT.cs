using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Hotellivarausjarjestelma
{
    internal class CLIENT
    {
        CONNECT conn = new CONNECT();

        public bool INSERTclient(String fnm, String lnm, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES(@fnm, @lnm, @phn, @cnt)
            command.commandText = insertQuery;
            command.Connection = conn.getConnection();
            //`first_name`, `lasdt_name`, `phone`, `country`
           command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fnm;
           command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lnm;
           command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = phone;
           command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = country;

            conn.openConnection();

            if(command.executeNonQuery() == 1)
            {
                conn.closeConnecrion();
                return true;
            }
            else
            {
                conn.closeConnecrion();
                return false;
            }
        }
        public DataTable getClients()
        {
            MysqlCommand command = new MysqlCommand("SELCET *  FROM `clients`", conn.GetConnection());
            MysqlDataAdapter adapter = new MysqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}

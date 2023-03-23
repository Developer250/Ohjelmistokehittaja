using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotellivarausjarjestelma
{
     class CONNECT
    {
        private MysqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=;database=hotelli");
        //Luodaan funktio yhteyttä varten
        public MySqlConnection getConnection()
        {
            return connection;
        }

        //Luodaan funktio yhteyden avaamista varten (System.Data -kirjasto)
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //Luodaan funktio yhteyden sulkemista varten
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}


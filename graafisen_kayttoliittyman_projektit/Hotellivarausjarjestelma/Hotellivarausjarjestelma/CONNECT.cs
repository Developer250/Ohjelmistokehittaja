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
        private MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=;database=hotellivarausjarjestelma");
        //Luodaan funktio yhteyttä varten
        public MySqlConnection getConnection()
        {
            return conn;
        }

        //Luodaan funktio yhteyden avaamista varten (System.Data -kirjasto)
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        //Luodaan funktio yhteyden sulkemista varten
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Oppilashallintajärjestelmä
{
    internal class Yhdista
    {
        public string yhteyslause()
        {
            return "datasource=localhost; port=3306; username=root; password=;database-hotelli";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=root; password=;database-opiskelijat");
        //Luodaan funktio yhteyttä varten
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }


    }
}

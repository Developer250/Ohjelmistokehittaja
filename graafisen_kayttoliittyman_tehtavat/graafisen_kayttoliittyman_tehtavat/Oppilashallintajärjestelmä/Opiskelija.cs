using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Oppilashallintajärjestelmä
{
    internal class Opiskelija
    {
        Yhdista yhteys = new Yhdista();
        //Luodaan funktio, jonka avulla lisätään uusi asiakas

        public bool lisaaOpiskelija(string enimi, string snimi, string puh, string email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            string lisakysely = "INSERT INTO yhteystiedot " +
                "(etunimi, sukunimi, puhelin, sähköposti, opiskelijanumero) " +
                "VALUES (@enm,, @snm, @puh, @eml, @ono) ";
            komento.CommandText = lisakysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.VarChar).Value = onro;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        //Luoadan funktio kaikkien asiakastietojen hakemiseksi
        public DataTable haeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, sähköposti, opiskelijanumero FROM yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }
    }
}

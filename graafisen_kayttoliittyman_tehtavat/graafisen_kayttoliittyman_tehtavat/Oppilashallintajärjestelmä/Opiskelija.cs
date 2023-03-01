using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Oppilashallintajärjestelmä
{
    internal class Opiskelija
    {
        Yhdista yhteys = new Yhdista();
        //Luodaan funktio, jonka avulla lisätään uusi asiakas

        public bool lisaaOpiskelija(String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisakysely = "INSERT INTO yhteystiedot " +
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
    
    //Luodaan funktio asiakkaan tietojen muokkaamiseksi
    public bool muokkaaOpiskelijaa(int oid, String enimi, String snimi, String puh, string email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivitakysely = "UPDATE `yhteystiedot`  SET `etunimi` = @enm," +
                "(etunimi, sukunimi, puhelin, sähköposti, opiskelijanumero) " +
                "`sukunimi = @snm, `Puhelin` = @puh, `sähköposti` = @eml, `opiskelijanumero` = @ono " +
                 " WHERE oid = @oid";
            komento.CommandText = paivitakysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu, @enm, @snm,@oso,  @pno, @ptp, @ssa
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

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

        public bool poistaOpiskelija(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM yhteystiedot WHERE oid = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu
            komento.Parameters.Add("@ktu", MySqlDbType.UInt32).Value = ktunnus;
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
    }
}

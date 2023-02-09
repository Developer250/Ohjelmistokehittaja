using System;
using System.IO;
namespace Paivakirja
{
    public partial class paivakirjaForm : Form
    {

        public paivakirjaForm()
        {
            InitializeComponent();
            try
            {
                string teksti = File.ReadAllText("C:\\temp\\paivakirja.txt");//Luodaan polku teksti-muuttujaan
                SyottoTB.Text = teksti;//Haetaan tekstiboksiin polku
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Tiedostoa ei löytynyt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Virhe viesti
            }
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = ""; //Luetaan teksti, jotta ei mene kirjoitus tekstin päälle, vaan perään
            teksti += SyottoTB.Text;//Haetaan teksti-muuttujaan tekstiboksin teksti, jonka käyttäjä syöttää
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";//Lisätään välilyönti tekstin ja päivämäärän välille sekä enter painallus ("/n")
            try
            {
                TextWriter text = new StreamWriter("C:\\temp\\paivakirja.txt");//Luodaan polku
                text.Write(teksti);//Pystytään kirjoittamaan tällä metodilla tekstiä päiväkirjaan
                text.Close();//Suljetaan päiväkirja
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error kirjoittaessa tiedostoa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Virhe viesti
            }
            Application.Exit();//Poistutaans ovelluksesta
        }
    }
}
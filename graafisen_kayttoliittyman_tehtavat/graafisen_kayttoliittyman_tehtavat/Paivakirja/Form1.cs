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
                MessageBox.Show("Tiedostoa ei lˆytynyt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui error lukiessa tiedostoa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = ""; //Luetaan teksti, jotta ei mene kirjoitus tekstin p‰‰lle, vaan per‰‰n
            teksti += SyottoTB.Text;//Haetaan teksti-muuttujaan tekstiboksin teksti, jonka k‰ytt‰j‰ syˆtt‰‰
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";//Lis‰t‰‰n v‰lilyˆnti tekstin ja p‰iv‰m‰‰r‰n v‰lille sek‰ enter painallus ("/n")
            try
            {
                TextWriter text = new StreamWriter("C:\\temp\\paivakirja.txt");//Luodaan polku
                text.Write(teksti + "\r");//Pystyt‰‰n kirjoittamaan t‰ll‰ metodilla teksti‰ p‰iv‰kirjaan ja tehd‰‰n rivinvaihto
                text.Close();//Suljetaan p‰iv‰kirja
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error kirjoittaessa tiedostoa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();//Poistutaans ovelluksesta
        }
    }
}
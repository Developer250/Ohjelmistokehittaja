using System.IO;

namespace Paivakirja
{
    public partial class paivakirjaForm : Form
    {
        public paivakirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\temp\\paivakirja.txt");//Luodaan polku teksti-muuttujaan
            SyottoTB.Text = teksti;//Haetaan tekstiboksiin polku

        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = ""; //Luetaan teksti, jotta ei mene kirjoitus tekstin p‰‰lle, vaan per‰‰n
            teksti += SyottoTB.Text;//Haetaan teksti-muuttujaan tekstiboksin teksti, jonka k‰ytt‰j‰ syˆtt‰‰
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";//Lis‰t‰‰n v‰lilyˆnti tekstin ja p‰iv‰m‰‰r‰n v‰lille sek‰ enter painallus ("/n")
            TextWriter text = new StreamWriter("C:\\temp\\paivakirja.txt");//Luodaan polku
            text.Write(teksti);//Pystyt‰‰n kirjoittamaan t‰ll‰ metodilla teksti‰ p‰iv‰kirjaan
            text.Close();//Suljetaan p‰iv‰kirja
            Application.Exit();//Poistutaans ovelluksesta
        }
    }
}
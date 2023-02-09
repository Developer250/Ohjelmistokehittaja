using System.IO;

namespace Paivakirja
{
    public partial class paivakirjaForm : Form
    {
        public paivakirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\temp\\paivakirja.txt");
            SyottoTB.Text = teksti;

        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = ""; //Luetaan teksti, jotta ei mene kirjoitus tekstin p‰‰lle, vaan per‰‰n
            teksti += SyottoTB.Text;//Haetaan teksti
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";//Lis‰t‰‰n v‰lilyˆnti tekstin ja p‰iv‰m‰‰r‰n v‰lille
            TextWriter text = new StreamWriter("C:\\temp\\paivakirja.txt");
            text.Write(teksti);//Pystyt‰‰n kirjoittamaan t‰ll‰ metodilla
            text.Close();//uljetaan p‰iv‰kirja
            Application.Exit();
        }
    }
}
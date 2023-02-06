using System.IO;

namespace Paivakirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\janikekalainen\\source\\repos\\Ohjelmistokehittaja2\\graafisen_kayttoliittyman_tehtavat\\graafisen_kayttoliittyman_tehtavat\\Paivakirja\\paivakirja.txt");
            SyottoTB.Text = teksti;

        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = ""; //Luetaan teksti, jotta ei mene kirjoitus tekstin p‰‰lle, vaan per‰‰n
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\janikekalainen\\source\\repos\\Ohjelmistokehittaja2\\graafisen_kayttoliittyman_tehtavat\\graafisen_kayttoliittyman_tehtavat\\Paivakirja\\paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
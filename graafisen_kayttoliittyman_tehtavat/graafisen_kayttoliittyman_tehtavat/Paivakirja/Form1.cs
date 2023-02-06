using System.IO;

namespace Paivakirja
{
    public partial class paivakirjaForm : Form
    {
        public paivakirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\users\\janikekalainen\\source\\repos\\ohjelmistokehittaja2\\graafisen_kayttoliittyman_tehtavat\\graafisen_kayttoliittyman_tehtavat\\paivakirja\\paivakirja.txt");
            SyottoTB.Text = teksti;

        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = ""; //Luetaan teksti, jotta ei mene kirjoitus tekstin p‰‰lle, vaan per‰‰n
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\users\\janikekalainen\\source\\repos\\ohjelmistokehittaja2\\graafisen_kayttoliittyman_tehtavat\\graafisen_kayttoliittyman_tehtavat\\paivakirja\\paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
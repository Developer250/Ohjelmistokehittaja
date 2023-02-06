using System.IO;

namespace Paivakirja
{
    public partial class paivakirjaForm : Form
    {
        public paivakirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\janikekalainen\\source\\repos\\Ohjelmistokehittaja2\\graafisen_kayttoliittyman_tehtavat\\graafisen_kayttoliittyman_tehtavat\\Paivakirja\\paivakirja.txt"); 
            syottoTB.Text = teksti;
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText("C:\\Users\\janikekalainen\\source\\repos\\Ohjelmistokehittaja2\\graafisen_kayttoliittyman_tehtavat\\graafisen_kayttoliittyman_tehtavat\\Paivakirja\\paivakirja.txt");  //Luetaan teksti, jotta ei mene kirjoitus tekstin p‰‰lle, vaan per‰‰n
            teksti += syottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\janikekalainen\\source\\repos\\Ohjelmistokehittaja2\\graafisen_kayttoliittyman_tehtavat\\graafisen_kayttoliittyman_tehtavat\\Paivakirja\\paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
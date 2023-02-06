using System.IO;

namespace pojat_tytot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tarkastaBT_Click(object sender, EventArgs e)
        {
            vastausLB.Text = "";//Tyhjennetään vastaus joka kerta
            vastausLB.Visible = false;
            string [] pojat = File.ReadAllLines("C:\\Users\\janikekalainen\\source\\repos\\Ohjelmistokehittaja2\\graafisen_kayttoliittyman_tehtavat\\graafisen_kayttoliittyman_tehtavat\\pojat_tytot\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\janikekalainen\\source\\repos\\Ohjelmistokehittaja2\\graafisen_kayttoliittyman_tehtavat\\graafisen_kayttoliittyman_tehtavat\\pojat_tytot\tytot.txt");
            string nimi = nimiTB.Text;
            int laskurip = 1; int laskurit = 1;

            foreach(string poju in pojat)
            {
                if(nimi == poju)
                {
                    vastausLB.Text = "Nimesi on " + laskurip + ".suosituin poikien nimi vuonna 2023 ";
                    vastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    vastausLB.Text = "Nimesi on " + laskurit + ".suosituin tyttöjen nimi vuonna 2023 ";
                    vastausLB.Visible = true;
                }
                laskurit++;
            }
            if (vastausLB.Visible == false)
                vastausLB.Text = "Nimeäsi ei löytynyt suosituimpien nimien joukosta!";
                 vastausLB.Visible = true;
        }
    }
}
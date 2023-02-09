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

            string[] pojat = File.ReadAllLines("C:\\temp\\pojat.txt");//Luetaan teksti taulukkoon, jotta voidaan verrata
            string[] tytot = File.ReadAllLines("C:\\temp\\tytot.txt");//Luetaan teksti taulukkoon, jotta voidaan verrata
            string nimi = nimiTB.Text;//Haetaan tekstiboksi nimi-muuttujaan
            int laskurip = 1; int laskurit = 1;//Tehdään molemmille sukupuolillle laskurit

            foreach(string poju in pojat)
            {
                if(nimi == poju)//Tarkistetaan, jos käyttäjän antama nimi on poju-nimestä 
                {
                    vastausLB.Text = "Nimesi on " + laskurip + ".suosituin poikien nimi vuonna 2023 ";//Haetaan teksti ja laskuri etsii monnenesko nimi on 
                    vastausLB.Visible = true;//Tulostetaan vastaus esille
                }
                laskurip++;
            }
            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    vastausLB.Text = "Nimesi on " + laskurit + ".suosituin tyttöjen nimi vuonna 2023 ";//Haetaan teksti ja laskuri etsii monnenesko nimi on 
                    vastausLB.Visible = true;//Tulostetaan vastaus esille
                }
                laskurit++;
            }
            if (vastausLB.Visible == false)
                vastausLB.Text = "Nimeäsi ei löytynyt suosituimpien nimien joukosta!";//Haetaan teksti, jos nimi ei ole listassas
                 vastausLB.Visible = true;//Tulostetaan vastaus esille
        }
    }
}
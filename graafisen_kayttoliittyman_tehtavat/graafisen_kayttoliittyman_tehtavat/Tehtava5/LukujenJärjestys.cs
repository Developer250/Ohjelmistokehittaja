namespace Tehtava5
{
    public partial class Form1 : Form
    {
        List<int> jono = new List<int>(); //M‰‰ritet‰‰n ulkopuolelle, jotta texbox ei m‰‰rity joka kerta

        public Form1()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_TextChanged(object sender, KeyPressEventArgs e)
        {
            
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //M‰‰ritet‰‰n, ett‰ mit‰ tapahtuu, kun painetaan enter-n‰pp‰int‰
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();//Muutetaan lista-muuttuja taulukko-muuttujaksi
                    Array.Sort(taulukko);//J‰rjestet‰‰n taulukko
                    foreach (var jasen in taulukko)//K‰yd‰‰n l‰pi jokainen j‰sen taulukosta
                    {
                        VastausLB.Text += jasen + " ";//Lis‰t‰‰n vastaukseen uusi j‰sen ja tehd‰‰n v‰lit niiden v‰lille
                    }
                    VastausLB.Visible = true;//N‰ytet‰‰n vastaus
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));//Jonoon lis‰t‰‰n uusiluku.text ja muutetaan integeriksi
                    uusiLukuTB.Text = "";
                }
            }
            //Tyh‰t‰‰n lomake ja tarkastetaan mit‰ tapahtuu, kun escapea painetaan
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void uusiLukuTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
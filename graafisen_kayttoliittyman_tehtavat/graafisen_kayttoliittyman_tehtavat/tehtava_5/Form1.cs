using System.Text.Encodings.Web;

namespace tehtava_5
{
    public partial class LukuJ‰rjestys : Form
    {
        List<int> jono = new List<int>();

        public LukuJ‰rjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //M‰‰ritet‰‰n, ett‰ mit‰ tapahtuu, kun painetaan enter-n‰pp‰int‰
            if (e.KeyChar == (char)Keys.Enter) ;

            //Tarkistetaan mit‰ sitten tapahtuu //Tyhjennet‰‰n
            if (uusiLukuTB.Text == "-999")
            {
                VastausLB.Text = "";
                int[] taulukko = jono.ToArray();//Muutetaan lista-muuttuja taulukko-muuttujaksi
                Array.Sort(taulukko); //T‰ll‰ voidaan j‰rjest‰‰m‰‰n taulukoksi
                foreach (var jasen in taulukko) ;//K‰yd‰‰n l‰pi jokainen j‰sen taulukosta
                {
                    VastausLB.Text += jasen + " "; //Lis‰t‰‰n vastaukseen j‰sen ja luodaan v‰li 
                }
                VastausLB.Visible = true;
            }
            else
            {
                jono.Add(Int32.Parse(uusiLukuTB.Text));
                uusiLukuTB.Text = "";
            }
        }
            if (e.KeyChar == (char) Keys.Escape)
            {

             TyhjaaLomake();

            ) 
            
             
    }

        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }
    }
}
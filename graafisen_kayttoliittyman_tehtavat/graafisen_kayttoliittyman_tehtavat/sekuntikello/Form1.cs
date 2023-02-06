using System.Diagnostics;

namespace sekuntikello
{
    
    public partial class sekkariForm : Form
    {
        private Stopwatch sekkari;//Tehd‰‰n private-olio, jotta se toimii vain t‰m‰n sis‰ll‰
        public sekkariForm()
        {
            InitializeComponent();
        }

        private void kaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();//K‰ynnist‰‰ ajan "k‰ynnist‰" -napista
        }

        private void lopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();//Pys‰ytt‰‰ ajan "lopeta" -napista
        }

        private void tyhjaaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();//Tyhj‰‰ "tyhjenn‰" napista
        }

        private void sekkariForm_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();//Tehd‰‰n uusi olio formin lataamista varten
        }

        private void ajanottoTM_Tick(object sender, EventArgs e)
        {
           AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);//Saadaan tunnit, minuutit ja sekunnit kahdella arvolla ja tuhannes-osat kolmella arvolla
        }
    }
}
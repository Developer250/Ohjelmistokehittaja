namespace tehtava_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LaskeIkaBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosissaLB.Text = Math.Ceiling(erotus / 365.25) + "vuotta";
            KuukausissaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + "kuukautta";
            PaivissaLB.Text = erotus + "p‰iv‰‰";
            TunneissaLB.Text = (erotus * 24) + "tuntia";
            MinuuteissaB.Text = (erotus * 24 * 60) + "minuuttia";
            SekunneissaB.Text = (erotus * 24 * 60 * 60) + "sekuntia";

            VuosissaLB.Visible = true;
            KuukausissaLB.Visible = true;
            PaivissaLB.Visible = true;
            VuosissaLB.Visible = true;
        }
    }
}
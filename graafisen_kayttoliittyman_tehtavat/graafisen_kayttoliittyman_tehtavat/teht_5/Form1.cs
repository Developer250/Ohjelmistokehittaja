namespace tehtava_5
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusilukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusilukuTB.Text));
                    uusilukuTB.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            uusilukuTB.Text = "";
        }

       
    }
}
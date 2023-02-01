namespace salasana_tarkastus
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

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Jani" && SalasanaTB.Text == "Klassikko!")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana on virheellinen";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
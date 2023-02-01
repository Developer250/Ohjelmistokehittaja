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
            //Tarkistetaan vastaako käyttäjän syöttämä sana "Jani" käyttäjätunnus.text kohdassa
            //Tarkistetaan myös SalasanaTB.Text kohdassa sanalla "Klassikko!"
            if (KayttajaTB.Text == "Jani" && SalasanaTB.Text == "Klassikko!")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;//Jos salsana ja käyttätunnus ovat oikein, siirtyy tarkistamisen jälkeen suoraan "tervetuloa sivuilleni" paneeliin
            }
            else
            {
                //Muutoin tulosteaan virheviesti esille
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana on virheellinen";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
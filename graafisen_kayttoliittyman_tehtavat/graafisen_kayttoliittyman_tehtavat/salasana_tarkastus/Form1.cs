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
            //Tarkistetaan vastaako k�ytt�j�n sy�tt�m� sana "Jani" k�ytt�j�tunnus.text kohdassa
            //Tarkistetaan my�s SalasanaTB.Text kohdassa sanalla "Klassikko!"
            if (KayttajaTB.Text == "Jani" && SalasanaTB.Text == "Klassikko!")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;//Jos salsana ja k�ytt�tunnus ovat oikein, siirtyy tarkistamisen j�lkeen suoraan "tervetuloa sivuilleni" paneeliin
            }
            else
            {
                //Muutoin tulosteaan virheviesti esille
                VirheviestiLB.Text = "K�ytt�j�tunnus tai salasana on virheellinen";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
namespace Autokululaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            double laina, nesteet, vakuutusmaksut, pesut, huollot, muut, renkaat, kilometrit, energia, kustannukset;//Tehd‰‰n muuttujat
            
            //Haetaan lomakkeelta
            laina = Convert.ToDouble(lainaTB.Text);
            nesteet = Convert.ToDouble(nesteetTB.Text);
            vakuutusmaksut = Convert.ToDouble(vakuutusmaksutTB.Text);
            pesut = Convert.ToDouble(pesutTB.Text);
            huollot = Convert.ToDouble(huollotTB.Text);
            renkaat = Convert.ToDouble(renkaatTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            energia = Convert.ToDouble(polttonesteTB.Text);
            muut = Convert.ToDouble(muutKulutTB.Text);

            //Lasketaan kustannukset ja tulostetaan lomakkeelle esille
            kustannukset = (laina + nesteet + vakuutusmaksut + pesut + huollot + renkaat + kilometrit + energia + muut) / (kilometrit / 12);//Lasketaan vuosikustannukset
            vastausLB.Text = "Kustannukset kilometri‰ kohden ovat: " + kustannukset;
            vastausLB.Visible = true;

        }
    }
}
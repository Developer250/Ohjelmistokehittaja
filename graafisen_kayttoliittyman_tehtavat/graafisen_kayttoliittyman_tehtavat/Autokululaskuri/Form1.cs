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
            //Tehd‰‰n muuttujat
            double laina, nesteet, vakuutusmaksut, pesut, huollot, muut, renkaat, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(lainaTB.Text);
            nesteet = Convert.ToDouble(nesteetTB.Text);
            vakuutusmaksut = Convert.ToDouble(vakuutusmaksutTB.Text);
            pesut = Convert.ToDouble(pesutTB.Text);
            huollot = Convert.ToDouble(huollotTB.Text);
            muut = Convert.ToDouble(muutKulutTB.Text);
            renkaat = Convert.ToDouble(renkaatTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            energia = Convert.ToDouble(polttonesteTB.Text);
            kustannukset = Convert.ToDouble(laina + nesteet + vakuutusmaksut + pesut + huollot + muut + renkaat + kilometrit + energia) / (kilometrit/12);
            vastausLB.Text = "Kustannukset kilometri‰ kohden ovat:" + kustannukset;
            vastausLB.Visible = true;

        }
    }
}
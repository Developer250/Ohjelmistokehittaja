namespace Celcius__to_Fahrenheit
{
    public partial class AsteMuunninForm : Form
    {
        public AsteMuunninForm()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;//Alustetaan vastaus
            double asteet = Convert.ToDouble(asteetTB.Text);//Haetaan asteet tekstiboksista ja muunnetaan ne
            if(celsiusRB.Checked)//Tarkistetaan celsius radiobuttoni
            {
                vastaus = asteet * 1.8 + 32;
                vastausLB.Text = asteet + " Farenheita on: " + vastaus + " Celsius astetta";
                vastausLB.Visible = true;
            }
            else if (farenheitRB.Checked)//Tarkistetaan farenheit radiobuttoni
            {
                vastaus =( asteet - 32) / 1.8;
                vastausLB.Text = asteet + " Celsiusta on: " + vastaus + " Farenheit astetta";
                vastausLB.Visible = true;
            }
            else
            {
                //Jos ei ole valittu kumpaakaan radiobuttonia ei ole valittu, tulostteaan vastaukseen viesti
                vastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut oikeaa lukua";
                vastausLB.Visible = true;
            }
        }

        private void asteetTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
namespace BMI_laskuri
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double BMI = Math.Round(paino / (pituus * pituus), 2);//Py�ristet��n 2-desimaalin arvoon painoinkdeksi

            if(BMI < 18.5)//Tarkistetaan painoindeksi
            {
                vastausLB.Text = "Painoindeksisi on " + BMI;//Vastaukseen sijoitetaan teksti ja itse painoindeksi
                vastausLB.ForeColor = Color.MediumSlateBlue;//Vastaus tekstin v�ri vesi
                kuvainnollinenLB.Text = "Alipaino";//Kuvaus labeliin teksti
                kuvainnollinenLB.ForeColor = Color.MediumSlateBlue;//Kuvaus labelin tekstin v�ri
                kuvainnollinenLB.Visible = true;//Tulostetaan n�kyviin
            }
            else if(BMI < 25)
            {
                vastausLB.Text = "Painoindeksisi on: " + BMI;//Vastaukseen sijoitetaan teksti ja itse painoindeksi
                vastausLB.ForeColor = Color.MediumSpringGreen;//Vastaus tekstin v�ri vesi
                kuvainnollinenLB.Text = "Normaalipaino";//Kuvaus labeliin teksti
                kuvainnollinenLB.ForeColor = Color.MediumSpringGreen;//Kuvaus labelin tekstin v�ri
                vastausLB.Visible = true;
                kuvainnollinenLB.Visible = true;//Tulostetaan n�kyviin
            }
             else if(BMI < 40)
            {
                vastausLB.Text = "Painoindeksisi on: " + BMI;//Vastaukseen sijoitetaan teksti ja itse painoindeksi
                vastausLB.ForeColor = Color.Gold;//Vastaus tekstin v�ri vesi
                kuvainnollinenLB.Text = "Ylipaino";//Kuvaus labeliin teksti
                kuvainnollinenLB.ForeColor = Color.Gold;//Kuvaus labelin tekstin v�ri
                vastausLB.Visible = true;
                kuvainnollinenLB.Visible = true;//Tulostetaan n�kyviin
            }
            else
            {
                vastausLB.Text = "Painoindeksisi on: " + BMI;//Vastaukseen sijoitetaan teksti ja itse painoindeksi
                vastausLB.ForeColor = Color.MediumVioletRed;//Vastaus tekstin v�ri vesi
                kuvainnollinenLB.Text = "Huomattavasti ylipaino";//Kuvaus labeliin teksti
                kuvainnollinenLB.ForeColor = Color.MediumVioletRed;//Kuvaus labelin tekstin v�ri
                vastausLB.Visible = true;
                kuvainnollinenLB.Visible = true;//Tulostetaan n�kyviin
            }
        }
    }
}
namespace tehtava_3
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
            //Tehd‰‰n alustukset
        {
            double luku1 = double.Parse(luku1TB.Text); // t‰ss‰ joudumme tekem‰‰n lukumuunnoksen tekstist‰ liukuluvuksi komennolla float.Parse(luku)
            double luku2 = double.Parse(luku2TB.Text);
            double vastaus = 0;
            string merkki = LaskutoimitusCB.Text;


            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                vastaus = luku1/luku2; // t‰ss‰ double, koska voi tulla murtoluku 
                    break;
                default:
                    Console.WriteLine("Tapahtui virhe!");
                    break;
            }
            //Tulostetaan lasku
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;
        }
    }
}

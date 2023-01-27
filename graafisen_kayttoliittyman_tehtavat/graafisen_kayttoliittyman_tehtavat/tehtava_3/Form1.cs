namespace tehtava_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(LukuYksiTB.Text); // t‰ss‰ joudumme tekem‰‰n lukumuunnoksen tekstist‰ liukuluvuksi komennolla float.Parse(luku)
            float luku2 = float.Parse(LukuKaksiTB.Text); 
            float vastaus = 0; string merkki = LaskutoimitusCB.Text;


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
                    double vastaus2 = luku1 / luku2;
                    break;

                default:
                    Console.WriteLine("Tapahtui virhe!");
                    break;
            }
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

namespace Harjoitus3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double luku1 = double.Parse(luku1TB.Text);
            double luku2 = double.Parse(luk);
            string merkki = laskuCB.Text;
            double vastaus = 0;

            switch(merkki)
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
                  double  vastaus2 = luku1 / luku2;
                    break;

                default:
                    Console.WriteLine("Tapahtui virhe!");
                    break;
            }
            vastausLB.Text = Convert.ToString(vastaus);
            vastausLB.Visible = true;
        }
    }
}
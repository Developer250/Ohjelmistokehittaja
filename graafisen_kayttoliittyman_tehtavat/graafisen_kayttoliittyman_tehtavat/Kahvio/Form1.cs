namespace Kahvio
{
    public partial class kahvioForm : Form
    {
        public kahvioForm()
        {
            InitializeComponent();
            meistaPL.Visible = true;
        }

        private void kahvioForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            meistaLB.Text += "9:00 - 14:30 maanantaista torstaisin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12:30 \n\n Keudan oppilaskunnan kahvilasta saa lämpimien\n";
            meistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia";
            meistaLB.Text += "tervetuloa tutustumaan!";
            meistaLB.Text += new Font("Arial", 12);
        }

        private void kahvioForm_Load_1(object sender, EventArgs e)
        {

        }

        private void meistaBT_Click(object sender, EventArgs e)
        {
            //Meistä-nappia klikatessa toimii ja vaihtaa tähän osioon 
            meistaPL.Visible = true;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void ruoatBT_Click(object sender, EventArgs e)
        {
            //Ruoat-nappia klikatessa toimii ja vaihtaa tähän osioon 
            meistaPL.Visible = false;
            ruoatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            //Juomat-nappia klikatessa toimii ja vaihtaa tähän osioon 
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void herkutBT_Click(object sender, EventArgs e)
        {
            //Herkut-nappia klikatessa toimii ja vaihtaa tähän osioon 
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;
        }

        private void koriBT_Click(object sender, EventArgs e)
        {
            //Kori-nappia klikatessa toimii ja vaihtaa tähän osioon 
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();//Suljetaan sovellus punaisesta kuvakkeesta (pyöreä nappi)
        }
    }
}
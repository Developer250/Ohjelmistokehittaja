namespace Harjoitus2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostusLB.Text = teksti;
            TulostusLB.Visible = true;

        }

        private void tulostBT_Click(object sender, EventArgs e)
        {

            string teksti = viestiTB.Text;
            tulostusLB.Text = teksti;
            tulostusLB.Visible = true;
        }

    }
}
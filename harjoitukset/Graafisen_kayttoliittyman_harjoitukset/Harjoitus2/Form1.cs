namespace Harjoitus2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OtsikkoLB_Click(object sender, EventArgs e)
        {

        }

        private void TulostaTB_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostusLB.Text = teksti;
            TulostusLB.Visible = true;

        }
    }
}
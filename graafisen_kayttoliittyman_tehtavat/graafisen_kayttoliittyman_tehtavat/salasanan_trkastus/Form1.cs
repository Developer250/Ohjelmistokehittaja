namespace salasanan_trkastus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KayttajaTB_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TarkistaTB_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Jani" && SalasanaTB.Text == "Klassikko9!")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana on virheellinen";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
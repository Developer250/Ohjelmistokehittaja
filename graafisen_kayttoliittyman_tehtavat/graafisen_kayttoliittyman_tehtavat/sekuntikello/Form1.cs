using System.Diagnostics;

namespace sekuntikello
{
    
    public partial class sekkariForm : Form
    {
        private Stopwatch sekkari;
        public sekkariForm()
        {
            InitializeComponent();
        }

        private void kaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void lopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void tyhjaaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void sekkariForm_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();
        }

        private void ajanottoTM_Tick(object sender, EventArgs e)
        {
           AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}
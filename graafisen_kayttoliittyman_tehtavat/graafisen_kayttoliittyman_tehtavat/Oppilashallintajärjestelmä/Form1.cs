using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oppilashallintajärjestelmä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();

        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            enimiTB.Text = "";
            snimiTB.Text = "";
            puhTB.Text = "";
            spostiTB.Text = "";
            opiskelijanroTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            
           String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puh = puhTB.Text;
            String sposti = spostiTB.Text;
            int opiskelijanro = Int32.Parse(opiskelijanroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || sposti.Trim().Equals("") || opiskelijanro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja Sukunimi, puhelin, sähköposti ja opiskelijanumero ", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {

        }
    }
}

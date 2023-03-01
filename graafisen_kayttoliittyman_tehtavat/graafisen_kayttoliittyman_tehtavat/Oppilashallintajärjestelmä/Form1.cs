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
            tietotauluDG.DataSource = Opiskelija.haeOpiskelijat();

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
            else
            {
                Boolean lisaaAsiakas = Opiskelija.lisaaOpiskelija(enimi, snimi, puh, sposti, opiskelijanro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            tietotauluDG.DataSource = Opiskelija.haeOpiskelijat();
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puh = puhTB.Text;
            String sposti = spostiTB.Text;
            int opiskelijanro = Int32.Parse(opiskelijanroTB.Text);
            int oid = Int32.Parse(IdTB.Text);
            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || sposti.Trim().Equals("") || opiskelijanro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät -  ID, Etu- ja Sukunimi, puhelin, sähköposti ja opiskelijanumero ", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Boolean lisaaAsiakas = Opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puh, sposti, opiskelijanro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            tietotauluDG.DataSource = Opiskelija.haeOpiskelijat();
        }
    }
}

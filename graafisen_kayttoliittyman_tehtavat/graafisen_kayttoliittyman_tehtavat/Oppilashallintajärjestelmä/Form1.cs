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
        opiskelija opiskelija = new opiskelija();
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
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puh, sposti, opiskelijanro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
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
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puh, sposti, opiskelijanro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            enimiTB.Text = tietotauluDG.CurrentRow.Cells[1].Value.ToString();
            snimiTB.Text = tietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhTB.Text = tietotauluDG.CurrentRow.Cells[3].Value.ToString();
            spostiTB.Text = tietotauluDG.CurrentRow.Cells[4].Value.ToString();
            opiskelijanroTB.Text = tietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = IdTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Uusi opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Uutta opiskelijaa ei pystytty poistamaan", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tyhjennaBT.PerformClick();

            }
        }
    }
}

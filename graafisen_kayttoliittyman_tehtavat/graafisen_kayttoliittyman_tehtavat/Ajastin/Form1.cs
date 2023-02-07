using System.Diagnostics;
namespace Ajastin
{
    public partial class Form1 : Form
    {
        private int kokonaisaika;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopBT.Enabled = false;//Poistetaan aluksi stop-button käytöstä

            for(int i = 0; i < 60; i++)
            {
                minuutitCB.Items.Add(i.ToString());//Lisätään minuutteihin 0-59
                sekunnitCB.Items.Add(i.ToString());//Lisätään sekunteihin 0-59
            }
            minuutitCB.SelectedIndex = 0;//Oletus arvot dropdownsissa (0 minuuttia)
            sekunnitCB.SelectedIndex = 30;//Oletus arvot dropdownsissa (30 sekuntia)
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;//Poistetaan star-button käytöstä
            stopBT.Enabled = true;//Otetaan stop-button käyttöön
            //Laskketaan kokonaisaika sekunteina
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString());//Haetaan valitut minuutit
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());//Haetaan valitut sekunnit
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;//Otetaan start-button jälleen käyttöön
            stopBT.Enabled = false;//Poistetaan jälleen stop-button käytöstä
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;//Lasketaan uudelleen minuutit
                int sekunnit = kokonaisaika - (minuutit * 60);//Lasketaan uudelleen sekunnit
                aikaLB.Text = minuutit.ToString() + ":"  + sekunnit.ToString();//Näytetään ajastin-labelissa minuutit ja sekunnit
            }
            else
            {
                AjastinTM.Stop();//Pysäytetään ajastin
                MessageBox.Show("Aikasi loppui!");//Tulostetaan esille teksti
            }
        }
    }
}
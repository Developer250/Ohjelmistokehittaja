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
            stopBT.Enabled = false;//Poistetaan aluksi stop-button k�yt�st�

            for(int i = 0; i < 60; i++)
            {
                minuutitCB.Items.Add(i.ToString());//Lis�t��n minuutteihin 0-59
                sekunnitCB.Items.Add(i.ToString());//Lis�t��n sekunteihin 0-59
            }
            minuutitCB.SelectedIndex = 0;//Oletus arvot dropdownsissa (0 minuuttia)
            sekunnitCB.SelectedIndex = 30;//Oletus arvot dropdownsissa (30 sekuntia)
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;//Poistetaan star-button k�yt�st�
            stopBT.Enabled = true;//Otetaan stop-button k�ytt��n
            //Laskketaan kokonaisaika sekunteina
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString());//Haetaan valitut minuutit
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());//Haetaan valitut sekunnit
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;//Otetaan start-button j�lleen k�ytt��n
            stopBT.Enabled = false;//Poistetaan j�lleen stop-button k�yt�st�
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
                aikaLB.Text = minuutit.ToString() + ":"  + sekunnit.ToString();//N�ytet��n ajastin-labelissa minuutit ja sekunnit
            }
            else
            {
                AjastinTM.Stop();//Pys�ytet��n ajastin
                MessageBox.Show("Aikasi loppui!");//Tulostetaan esille teksti
            }
        }
    }
}
namespace Roomalaiset_nrot
{
    public partial class RoomalaisiksiFOrm : Form
    {
        public RoomalaisiksiFOrm()
        {
            InitializeComponent();
        }

        private void muutaBT_Click(object sender, EventArgs e)
        {
            
            int luku1, luku2, luku3, luku4;//Yehdään alustukset ykkös, kymmen, sata ja tuhat luvuille
            string vastaus = "";
            if(tekstiTB.Text.Length > 3)//Kyseessä on tuhat luku
            {
                luku1 = Convert.ToInt32(tekstiTB.Text.Substring(0, 1));//Tuhat
                luku2 = Convert.ToInt32(tekstiTB.Text.Substring(1, 1));//Sadat
                luku3 = Convert.ToInt32(tekstiTB.Text.Substring(2, 1));//Kympit
                luku4 = Convert.ToInt32(tekstiTB.Text.Substring(3, 1));//Ykköset
                if(luku1 % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if(luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if(luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus += "";
                }
                vastaus += sataset(luku2, vastaus); //Lähetetään mitä tuhansista tuli vastaus (M) ja lisätään vastaukseen mitä satasesta tuli (C)
            }
        }
          private string sataset (int luku2, string vastaus)
          { 
             if(luku2 % 9 == 0 && luku2 != 0)
             {
                return "CM";//900
             }
             else if(luku2 % 8 == 0 && luku2 != 0)
             {
                return "DCCC";//800
             }
            else if (luku2 % 7 == 0 && luku2 != 0)
            {
                return "DCC";//700
            }
            else if (luku2 % 6 == 0 && luku2 != 0)
            {
                return "DC";//600
            }
            else if (luku2 % 5 == 0 && luku2 != 0)
            {
                return "D";//500
            }
            else if (luku2 % 4 == 0 && luku2 != 0)
            {
                return "CD";//400
            }
            else if (luku2 % 3 == 0 && luku2 != 0)
            {
                return "CCC";//300
            }
            else if (luku2 % 2 == 0 && luku2 != 0)
            {
                return "CC";//200
            }
            else if (luku2 % 1 == 0 && luku2 != 0)
            {
                return "C";//100
            }
            else 
            {
                return "";//Muutoin tyhjä
            }
        }
    }        
}
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
            if(tekstiTB.Text.Length > 3)//Kyseessä on tuhatluku
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
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            if(tekstiTB.Text.Length > 2)//Kyseessä on sataluku
            {
                luku2 = Convert.ToInt32(tekstiTB.Text.Substring(0, 1));//Tuhat
                luku3 = Convert.ToInt32(tekstiTB.Text.Substring(1, 1));//Sadat
                luku4 = Convert.ToInt32(tekstiTB.Text.Substring(2, 1));//Kympit
                vastaus += sataset(luku2, vastaus); //Lähetetään mitä tuhansista tuli vastaus (M) ja lisätään vastaukseen mitä satasesta tuli (C)
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            if (tekstiTB.Text.Length > 1)//Kyseessä on kymmenluku
            {
                luku3 = Convert.ToInt32(tekstiTB.Text.Substring(0, 1));//Tuhat
                luku4 = Convert.ToInt32(tekstiTB.Text.Substring(2, 1));//Kympit
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            if (tekstiTB.Text.Length > 0)//Kyseessä on ykkösluvut
            {
                luku4 = Convert.ToInt32(tekstiTB.Text.Substring(0, 1));//ykkoset  
                vastaus += ykkoset(luku4, vastaus);
            }
            vastausLB.Text = vastaus;
            vastausLB.Visible = true;
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
        private string kympit(int luku3, string vastaus)
        {
            if (luku3 % 9 == 0 && luku3 != 0)
            {
                return "XC";//900
            }
            else if (luku3 % 8 == 0 && luku3 != 0)
            {
                return "LXXX";//80
            }
            else if (luku3 % 7 == 0 && luku3 != 0)
            {
                return "LXX";//70
            }
            else if (luku3 % 6 == 0 && luku3 != 0)
            {
                return "LX";//60
            }
            else if (luku3 % 5 == 0 && luku3 != 0)
            {
                return "L";//50
            }
            else if (luku3 % 4 == 0 && luku3 != 0)
            {
                return "XL";//40
            }
            else if (luku3 % 3 == 0 && luku3 != 0)
            {
                return "XXX";//30
            }
            else if (luku3 % 2 == 0 && luku3 != 0)
            {
                return "XX";//20
            }
            else if (luku3 % 1 == 0 && luku3 != 0)
            {
                return "X";//10
            }
            else
            {
                return "";//Muutoin tyhjä
            }
        }
        private string ykkoset(int luku4, string vastaus)
        {
            if (luku4 % 9 == 0 && luku4 != 0)
            {
                return "IX";//9
            }
            else if (luku4 % 8 == 0 && luku4 != 0)
            {
                return "VIII";//8
            }
            else if (luku4 % 7 == 0 && luku4 != 0)
            {
                return "VII";//7
            }
            else if (luku4 % 6 == 0 && luku4 != 0)
            {
                return "VI";//6
            }
            else if (luku4 % 5 == 0 && luku4 != 0)
            {
                return "V";//5
            }
            else if (luku4 % 4 == 0 && luku4 != 0)
            {
                return "IV";//4
            }
            else if (luku4 % 3 == 0 && luku4 != 0)
            {
                return "III";//3
            }
            else if (luku4 % 2 == 0 && luku4 != 0)
            {
                return "II";//2
            }
            else if (luku4 % 1 == 0 && luku4 != 0)
            {
                return "I";//1
            }
            else
            {
                return "";//Muutoin tyhjä
            }
        }
    }
}
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
            }
        }
    }
}
namespace NopanHeitto
{
    public partial class nopanHeittoForm : Form
    {
        public nopanHeittoForm()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(noppa01PB);//Tehd‰‰n kutsu, jossa muutetan noppa01
            piirraNoppa(noppa02PB);//Tehd‰‰n uudelleen kutsu, jossa muutetan noppa02
        }

        //Hyˆdynnet‰‰n funktiota, jottei meid‰n tarvitse tehd‰ asiaa moneen kertaan,
        ///Eli koska noppia heitet‰‰n kaksi, tehd‰‰n íheitotí funktion avulla ja l‰hetet‰‰n funktiolle tarvittava tieto, eli PictureBoxin nimi, johon haluamme kohdistaa toiminnon
        private void piirraNoppa (PictureBox NoppaBox)
        {
            Random satunnainen = new Random();//T‰ss‰ luotiin satunnainen-olio
            int noppa = satunnainen.Next(1, 7);//Saadaan luvut 1-6 v‰lilt‰
            switch(noppa)
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01;//Jos nopan arvo on 1, tulostuu noppakuva, jossa on numero 1
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice02;//Jos nopan arvo on 2, tulostuu noppakuva, jossa on numero 2
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice03;//Jos nopan arvo on 3, tulostuu noppakuva, jossa on numero 3
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice04;//Jos nopan arvo on 4, tulostuu noppakuva, jossa on numero 4
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice05;//Jos nopan arvo on 5, tulostuu noppakuva, jossa on numero 5
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice06;//Jos nopan arvo on 6, tulostuu noppakuva, jossa on numero 6
                    break;
            }
        }
    }
}
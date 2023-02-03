using System.Drawing.Text;

namespace _10_Kysymysta
{
    public partial class Form1 : Form
    {
        //Alustukset
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new[] {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D"};//Vastaukset
        string[] vastaukset = new string[10];//Taulukon pituus on 10:sti
        public Form1()
        {
            InitializeComponent();
            vastausARB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            vastausBRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            vastausCRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            vastausDRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }

        private void vastauslomakeForm_Load(object sender, EventArgs e)
        {

        }
        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10) //Laskurilla luetaan kuinka monta j�sent�  luetaan eli 10-j�sent�
            {
                RadioButton radbutton = (RadioButton)sender;//Senderist� l�hetetty tieto (A, B; C tai D vastaus) l�hetet��n Radiobuttoniin
                vastaukset[laskuri] = radbutton.Text;//Tallennetaan laskuriin senderist� tullut tieto
                laskuri++;//Kasvatetaan laskuria ja vaihdetaan teksti
                kysymysLB.Text = "Vastaus" + (laskuri) + ".kysymykseen";
            }
            else
            {
                
                vastausLB.Text = "";//Tyhjennet��n vastaukset
                //Muussa tapauksessa poistetaan radiobuttonit pois k�yt�st� ja tyhjennet��n vastauslabel
                vastausARB.Visible = false;
                vastausBRB.Visible = false;
                vastausCRB.Visible = false;
                vastausDRB.Visible = false;

                //Verrataan, kuinka moni annettu vastaus vastaa oikeaa vastausta
                for (int j = 0; j < 10; j++)
                {

                    if (vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                vastausLB.Text = "Oikeita vastauksia oli:" + oikein;
                vastausLB.Visible = true;
            }
            tyhjaaVastaus();//Kutsutaan TyhjaaVastaus() �funktiota 
        }
        private void tyhjaaVastaus()
        {
            //Tyhjennet��n edellinen vastaus
            //Ja koska tyhjennys on my�s radiobutton tapahtuma, joudutaan laskuria pienent�m��n, koska tyhjennys kutsui Radiobutton_CheckedChanged -funktiota

            if (vastausARB.Checked == true)
            {
                vastausARB.Checked = false;
                laskuri--;
            }
            if (vastausBRB.Checked == true)
            {
                vastausBRB.Checked = false;
                laskuri--;
            }
            if (vastausCRB.Checked == true)
            {
                vastausCRB.Checked = false;
                laskuri--;
            }
            if (vastausDRB.Checked == true)
            {
                vastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}
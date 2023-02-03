using System.Drawing.Text;

namespace _10_Kysymysta
{
    public partial class vastauslomakeForm : Form
    {
        //Alustukset
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new[] { "B", "D", "A", "A", "C", "A", "B", "A", "CD", };//Vastaukset
        string[] vastaukset = new string[10];//Taulukon pituus on 10:sti
        public vastauslomakeForm()
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
            if(sender is RadioButton && laskuri < 10) //Laskurilla luetaan kuinka monta jäsentä  luetaan eli 10-jäsentä
            {
                RadioButton radbutton = (RadioButton)sender;//Senderistä lähetetty tieto (A, B; C tai D vastaus) lähetetään Radiobuttoniin
                vastaukset[laskuri] = radbutton.Text;//Tallennetaan laskuriin senderistä tullut tieto
                laskuri++;
                kysymysLB.Text = "Vastaus" + laskuri + ".kysymykseen";
            }
            else
            {
                vastausLB.Text = "";//Tyhjennetään vastaukset
                vastausARB.Visible = false;//Ei anneta vastata uudelleen, jotta taulukko ei ylikuormitu, jotta taulukkoon ei ole mahdollista enään laittaa vastaus
                vastausBRB.Visible = false;
                vastausCRB.Visible = false;
                vastausDRB.Visible = false;
                for(int j = 0; j <= 10; j++)
                {

                    if (vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                vastausLB.Text = "Oikeita vastauksia oli:" + oikein;
                vastausLB.Visible = true;
            }
            tyhjaaVastaus();
        }
        private void tyhjaaVastaus()
        {
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
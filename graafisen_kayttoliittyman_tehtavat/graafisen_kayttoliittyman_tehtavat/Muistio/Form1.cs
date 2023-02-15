using System.IO;
using System.Reflection.Metadata;
using static System.Net.WebRequestMethods;
using System.Windows.Forms;

namespace Muistio
{
    public partial class muistioForm : Form
    {
        public muistioForm()
        {
            InitializeComponent();
        }
        string tiedostopolku = "";

      

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Koodi teksti-tiedoston avaamiseen
            using (OpenFileDialog atk = new OpenFileDialog())
            { Filter = "Rikastekstiformaatti |*.rtf", ValidateNames = true, Multiselect = false },
            {
                if(atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader v1 = new StreamReader(CustomAttributeNamedArgumentKind.FileName))

                    {
                        tiedostopolku = atk.fileName;
                        Task<string> teksti = v1.ReadToEndAsync();
                        rikasTB.Rtf = teksti.Result;

                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(tiedostopolku))
                {
                    using (SaveFileDialog ttk = new SaveFileDialog()
                    { Filter = "Rikastekstiformaatti |*.rtf", ValidateNames = true })
                    {

                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.rikasTB.Rtf);
                        tiedosto.Close();
                    }
                }
        }
               else
               {
               using (StreamWriter vk = new StreamWriter(tiedostopolku))

                  {
                    vk.WriteLineAsync(rikasTB.Rtf);
                  }
               }
}

        private void tallennaNimell‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Text = "";
        }
    }
}
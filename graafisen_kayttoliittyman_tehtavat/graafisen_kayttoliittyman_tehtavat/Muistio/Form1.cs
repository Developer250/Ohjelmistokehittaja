using System.IO;
using System.Reflection.Metadata;
using static System.Net.WebRequestMethods;
using System.Windows.Forms;
using System.Drawing.Printing;
using static System.Net.Mime.MediaTypeNames;

namespace Muistio
{
    public partial class muistioForm : Form
    {
        public muistioForm()
        {
            InitializeComponent();
        }
        string tiedostoPolku = "";



        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Koodi teksti-tiedoston avaamiseen
            using (OpenFileDialog atk = new OpenFileDialog()
            
            {Filter = "TextDocument|*.txt|Rich text Format|*.rtf", ValidateNames = true, Multiselect = false })
            {

                if (atk.ShowDialog() == DialogResult.OK)
                {
                    tiedostoPolku = atk.FileName;
                    Task<string> teksti = v1.ReadToEndAsync();
                    rikasTB.Rtf = teksti.Result;
                    TekstilaatikkoRTB.Rtf = Text.Result;
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstilaatikkoRTB.Text, TekstilaatikkoRTB.Font, Brushes.Black, 12, 10);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TekstilaatikkoRTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Cut();
        }

        private void liit‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectAll();
        }

        private void TekstilaatikkoRTB_TextChanged(object sender, EventArgs e)
        {
            if(TekstilaatikkoRTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }

     

    private void tallennaNimell‰ToolStripMenuItem_Click(object sender, EventArgs e)
    {
            //Voimme k‰ytt‰‰ talenna komentoa t‰ss‰
            using SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*.txt|Rich text Format|*.rtf", ValidateNames = true };
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                      {
                        jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Text);
                      }

                }

            }
    }


        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             printPreviewDialog1.Document = printDocument1;
             if(printDialog1.ShowDialog() == DialogResult.OK)
             {
                printDocument1.Print();
             }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TekstilaatikkoRTB.Text != "")
            {
            uusiToolStripMenuItem_Click(sender, e);
            TekstilaatikkoRTB.Text = "";
            }
           else
           {
            TekstilaatikkoRTB.Text = "";
           }
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                TekstilaatikkoRTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                TekstilaatikkoRTB.WordWrap = true;
            }
        }

        private void kIrjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstilaatikkoRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tiedostoPolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog())
                { Filter = "TextDocument|*.txt|Rich text Format|*.rtf", ValidateNames = true, Multiselect = false })
                {
                    if(ttk.ShowDialog() == DialogResult.OK)

                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.rikasTB.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
              using StreamWriter vk = new StreamWriter(tiedostoPolku))
               {
                    vk.WriteLineAsync(rikasTB.Rtf);
               }
            }
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectionBackColor = Color.Yellow;
        }
    }
}
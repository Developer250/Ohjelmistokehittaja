﻿namespace Muistio
{
    partial class muistioForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(muistioForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rikasTB = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaNimelläToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostuksenEsikatseluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.muokkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.kopioiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leikkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liitäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valitseKaikkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muotoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kIrjasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinKorostusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinRivitysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TekstilaatikkoRTB = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.muokkaaToolStripMenuItem,
            this.muotoileToolStripMenuItem,
            this.tietoaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem,
            this.avaaToolStripMenuItem,
            this.rikasTB,
            this.tallennaNimelläToolStripMenuItem,
            this.tulostuksenEsikatseluToolStripMenuItem,
            this.tulostaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.poistuToolStripMenuItem,
            this.toolStripMenuItem3});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.tiedostoToolStripMenuItem.Text = "&Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            this.uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            this.uusiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uusiToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.uusiToolStripMenuItem.Text = "Uusi";
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.avaaToolStripMenuItem.Text = "Avaa";
            this.avaaToolStripMenuItem.Click += new System.EventHandler(this.avaaToolStripMenuItem_Click);
            // 
            // rikasTB
            // 
            this.rikasTB.Name = "rikasTB";
            this.rikasTB.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.rikasTB.Size = new System.Drawing.Size(237, 26);
            this.rikasTB.Text = "Tallenna";
            this.rikasTB.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            this.tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            this.tallennaNimelläToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä";
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            this.tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            this.tulostuksenEsikatseluToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            // 
            // tulostaToolStripMenuItem
            // 
            this.tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            this.tulostaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tulostaToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.tulostaToolStripMenuItem.Text = "Tulosta";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(234, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(234, 6);
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.poistuToolStripMenuItem.Text = "Poistu";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(234, 6);
            // 
            // muokkaaToolStripMenuItem
            // 
            this.muokkaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.kopioiToolStripMenuItem,
            this.leikkaaToolStripMenuItem,
            this.liitäToolStripMenuItem,
            this.poistaToolStripMenuItem,
            this.valitseKaikkiToolStripMenuItem});
            this.muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            this.muokkaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.muokkaaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.muokkaaToolStripMenuItem.Text = "&Muokkaa";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(225, 6);
            // 
            // kopioiToolStripMenuItem
            // 
            this.kopioiToolStripMenuItem.Enabled = false;
            this.kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            this.kopioiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopioiToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.kopioiToolStripMenuItem.Text = "Kopioi";
            this.kopioiToolStripMenuItem.Click += new System.EventHandler(this.kopioiToolStripMenuItem_Click);
            // 
            // leikkaaToolStripMenuItem
            // 
            this.leikkaaToolStripMenuItem.Enabled = false;
            this.leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            this.leikkaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.leikkaaToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.leikkaaToolStripMenuItem.Text = "Leikkaa";
            this.leikkaaToolStripMenuItem.Click += new System.EventHandler(this.leikkaaToolStripMenuItem_Click);
            // 
            // liitäToolStripMenuItem
            // 
            this.liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            this.liitäToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.liitäToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.liitäToolStripMenuItem.Text = "Liitä";
            this.liitäToolStripMenuItem.Click += new System.EventHandler(this.liitäToolStripMenuItem_Click);
            // 
            // poistaToolStripMenuItem
            // 
            this.poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            this.poistaToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.poistaToolStripMenuItem.Text = "Poista";
            this.poistaToolStripMenuItem.Click += new System.EventHandler(this.poistaToolStripMenuItem_Click);
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            this.valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            this.valitseKaikkiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.valitseKaikkiToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            this.valitseKaikkiToolStripMenuItem.Click += new System.EventHandler(this.valitseKaikkiToolStripMenuItem_Click);
            // 
            // muotoileToolStripMenuItem
            // 
            this.muotoileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kIrjasinToolStripMenuItem,
            this.tekstinKorostusToolStripMenuItem,
            this.tekstinRivitysToolStripMenuItem});
            this.muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            this.muotoileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.muotoileToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.muotoileToolStripMenuItem.Text = "&Muotoile";
            // 
            // kIrjasinToolStripMenuItem
            // 
            this.kIrjasinToolStripMenuItem.Name = "kIrjasinToolStripMenuItem";
            this.kIrjasinToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.kIrjasinToolStripMenuItem.Text = "KIrjasin";
            this.kIrjasinToolStripMenuItem.Click += new System.EventHandler(this.kIrjasinToolStripMenuItem_Click);
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            this.tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            this.tekstinKorostusToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            this.tekstinKorostusToolStripMenuItem.Click += new System.EventHandler(this.tekstinKorostusToolStripMenuItem_Click);
            // 
            // tekstinRivitysToolStripMenuItem
            // 
            this.tekstinRivitysToolStripMenuItem.Name = "tekstinRivitysToolStripMenuItem";
            this.tekstinRivitysToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.tekstinRivitysToolStripMenuItem.Text = "Tekstin rivitys";
            this.tekstinRivitysToolStripMenuItem.Click += new System.EventHandler(this.tekstinRivitysToolStripMenuItem_Click);
            // 
            // tietoaToolStripMenuItem
            // 
            this.tietoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietoaToolStripMenuItem1});
            this.tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            this.tietoaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.tietoaToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.tietoaToolStripMenuItem.Text = "&Apua";
            // 
            // tietoaToolStripMenuItem1
            // 
            this.tietoaToolStripMenuItem1.Name = "tietoaToolStripMenuItem1";
            this.tietoaToolStripMenuItem1.Size = new System.Drawing.Size(126, 26);
            this.tietoaToolStripMenuItem1.Text = "Tieto";
            this.tietoaToolStripMenuItem1.Click += new System.EventHandler(this.tietoaToolStripMenuItem1_Click);
            // 
            // TekstilaatikkoRTB
            // 
            this.TekstilaatikkoRTB.AcceptsTab = true;
            this.TekstilaatikkoRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TekstilaatikkoRTB.Location = new System.Drawing.Point(0, 28);
            this.TekstilaatikkoRTB.Name = "TekstilaatikkoRTB";
            this.TekstilaatikkoRTB.Size = new System.Drawing.Size(800, 422);
            this.TekstilaatikkoRTB.TabIndex = 1;
            this.TekstilaatikkoRTB.Text = "";
            this.TekstilaatikkoRTB.WordWrap = false;
            this.TekstilaatikkoRTB.TextChanged += new System.EventHandler(this.TekstilaatikkoRTB_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // muistioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TekstilaatikkoRTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "muistioForm";
            this.Text = "Muistio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private ToolStripMenuItem rikasTB;
        private ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem;
        private ToolStripMenuItem tulostaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem muokkaaToolStripMenuItem;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem tietoaToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem kopioiToolStripMenuItem;
        private ToolStripMenuItem leikkaaToolStripMenuItem;
        private ToolStripMenuItem liitäToolStripMenuItem;
        private ToolStripMenuItem poistaToolStripMenuItem;
        private ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private ToolStripMenuItem kIrjasinToolStripMenuItem;
        private ToolStripMenuItem tekstinKorostusToolStripMenuItem;
        private ToolStripMenuItem tekstinRivitysToolStripMenuItem;
        private ToolStripMenuItem tietoaToolStripMenuItem1;
        private RichTextBox TekstilaatikkoRTB;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private FontDialog fontDialog1;
    }
}
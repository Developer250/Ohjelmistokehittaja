namespace salasanan_trkastus
{
    partial class Form1
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
            this.SsalasanaPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Label();
            this.TarkistaTB = new System.Windows.Forms.Button();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.lablel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SsalasanaPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SsalasanaPanel
            // 
            this.SsalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SsalasanaPanel.Controls.Add(this.panel1);
            this.SsalasanaPanel.Controls.Add(this.TarkistaTB);
            this.SsalasanaPanel.Controls.Add(this.VirheviestiLB);
            this.SsalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SsalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SsalasanaPanel.Controls.Add(this.lablel1);
            this.SsalasanaPanel.Controls.Add(this.label2);
            this.SsalasanaPanel.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SsalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SsalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SsalasanaPanel.Name = "SsalasanaPanel";
            this.SsalasanaPanel.Size = new System.Drawing.Size(800, 450);
            this.SsalasanaPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.SalasanaOikeinPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.AutoSize = true;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 41);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(721, 99);
            this.SalasanaOikeinPanel.TabIndex = 0;
            this.SalasanaOikeinPanel.Text = "Tervetuloa sivuilleni";
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // TarkistaTB
            // 
            this.TarkistaTB.ForeColor = System.Drawing.Color.Black;
            this.TarkistaTB.Location = new System.Drawing.Point(19, 93);
            this.TarkistaTB.Name = "TarkistaTB";
            this.TarkistaTB.Size = new System.Drawing.Size(154, 47);
            this.TarkistaTB.TabIndex = 5;
            this.TarkistaTB.Text = "Tarkista";
            this.TarkistaTB.UseVisualStyleBackColor = true;
            this.TarkistaTB.Click += new System.EventHandler(this.TarkistaTB_Click);
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.Location = new System.Drawing.Point(19, 190);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(100, 46);
            this.VirheviestiLB.TabIndex = 4;
            this.VirheviestiLB.Text = "Virhe";
            this.VirheviestiLB.Visible = false;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(396, 103);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(286, 51);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(396, 46);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(286, 51);
            this.KayttajaTB.TabIndex = 2;
            // 
            // lablel1
            // 
            this.lablel1.AutoSize = true;
            this.lablel1.Location = new System.Drawing.Point(106, 28);
            this.lablel1.Name = "lablel1";
            this.lablel1.Size = new System.Drawing.Size(256, 46);
            this.lablel1.TabIndex = 1;
            this.lablel1.Text = "Käyttäjätunnus:";
            this.lablel1.Click += new System.EventHandler(this.KayttajaTB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salasana:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 181);
            this.Controls.Add(this.SsalasanaPanel);
            this.Name = "Form1";
            this.Text = "Salasanan tarkastus";
            this.SsalasanaPanel.ResumeLayout(false);
            this.SsalasanaPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SsalasanaPanel;
        private Label lablel1;
        private Label label2;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label VirheviestiLB;
        private Button TarkistaTB;
        private Panel panel1;
        private Label SalasanaOikeinPanel;
    }
}
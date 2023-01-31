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
            this.lablel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.TarkistaTB = new System.Windows.Forms.Button();
            this.SsalasanaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SsalasanaPanel
            // 
            this.SsalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SsalasanaPanel.Controls.Add(this.TarkistaTB);
            this.SsalasanaPanel.Controls.Add(this.VirheviestiLB);
            this.SsalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SsalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SsalasanaPanel.Controls.Add(this.lablel1);
            this.SsalasanaPanel.Controls.Add(this.label2);
            this.SsalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SsalasanaPanel.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SsalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SsalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SsalasanaPanel.Name = "SsalasanaPanel";
            this.SsalasanaPanel.Size = new System.Drawing.Size(800, 450);
            this.SsalasanaPanel.TabIndex = 0;
            // 
            // lablel1
            // 
            this.lablel1.AutoSize = true;
            this.lablel1.Location = new System.Drawing.Point(167, 161);
            this.lablel1.Name = "lablel1";
            this.lablel1.Size = new System.Drawing.Size(256, 46);
            this.lablel1.TabIndex = 1;
            this.lablel1.Text = "Käyttäjätunnus:";
            this.lablel1.Click += new System.EventHandler(this.KayttajaTB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(457, 179);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(286, 51);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(457, 236);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(286, 51);
            this.SalasanaTB.TabIndex = 3;
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.Location = new System.Drawing.Point(80, 323);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(100, 46);
            this.VirheviestiLB.TabIndex = 4;
            this.VirheviestiLB.Text = "Virhe";
            this.VirheviestiLB.Visible = false;
            // 
            // TarkistaTB
            // 
            this.TarkistaTB.ForeColor = System.Drawing.Color.Black;
            this.TarkistaTB.Location = new System.Drawing.Point(80, 226);
            this.TarkistaTB.Name = "TarkistaTB";
            this.TarkistaTB.Size = new System.Drawing.Size(154, 47);
            this.TarkistaTB.TabIndex = 5;
            this.TarkistaTB.Text = "Tarkista";
            this.TarkistaTB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SsalasanaPanel);
            this.Name = "Form1";
            this.Text = "Salasanan tarkastus";
            this.SsalasanaPanel.ResumeLayout(false);
            this.SsalasanaPanel.PerformLayout();
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
    }
}
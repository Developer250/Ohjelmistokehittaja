namespace SalasananTarkastus
{
    partial class SalasanaForm
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TarkistaTB = new System.Windows.Forms.Button();
            this.VirheViestiLB = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.VirheViestiLB);
            this.SalasanaPanel.Controls.Add(this.TarkistaTB);
            this.SalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SalasanaPanel.Controls.Add(this.label2);
            this.SalasanaPanel.Controls.Add(this.label1);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(1800, 990);
            this.SalasanaPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(161, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(259, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(423, 80);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(315, 51);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(423, 151);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(315, 51);
            this.SalasanaTB.TabIndex = 3;
            // 
            // TarkistaTB
            // 
            this.TarkistaTB.ForeColor = System.Drawing.Color.Black;
            this.TarkistaTB.Location = new System.Drawing.Point(91, 129);
            this.TarkistaTB.Name = "TarkistaTB";
            this.TarkistaTB.Size = new System.Drawing.Size(162, 46);
            this.TarkistaTB.TabIndex = 4;
            this.TarkistaTB.Text = "Tarkista";
            this.TarkistaTB.UseVisualStyleBackColor = true;
            // 
            // VirheViestiLB
            // 
            this.VirheViestiLB.AutoSize = true;
            this.VirheViestiLB.BackColor = System.Drawing.Color.Transparent;
            this.VirheViestiLB.ForeColor = System.Drawing.Color.Gold;
            this.VirheViestiLB.Location = new System.Drawing.Point(91, 225);
            this.VirheViestiLB.Name = "VirheViestiLB";
            this.VirheViestiLB.Size = new System.Drawing.Size(100, 46);
            this.VirheViestiLB.TabIndex = 5;
            this.VirheViestiLB.Text = "Virhe";
            this.VirheViestiLB.Visible = false;
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 990);
            this.Controls.Add(this.SalasanaPanel);
            this.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SalasanaPanel;
        private Label label2;
        private Label label1;
        private TextBox KayttajaTB;
        private TextBox SalasanaTB;
        private Button TarkistaTB;
        private Label VirheViestiLB;
    }
}
namespace pojat_tytot
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
            this.label1 = new System.Windows.Forms.Label();
            this.nimiTB = new System.Windows.Forms.TextBox();
            this.tarkastaBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna nimesi, niin tarkastan, onko  se 50 suosituimman joukossa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nimiTB
            // 
            this.nimiTB.Location = new System.Drawing.Point(811, 29);
            this.nimiTB.Name = "nimiTB";
            this.nimiTB.Size = new System.Drawing.Size(163, 43);
            this.nimiTB.TabIndex = 2;
            // 
            // tarkastaBT
            // 
            this.tarkastaBT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tarkastaBT.Location = new System.Drawing.Point(811, 92);
            this.tarkastaBT.Name = "tarkastaBT";
            this.tarkastaBT.Size = new System.Drawing.Size(163, 51);
            this.tarkastaBT.TabIndex = 3;
            this.tarkastaBT.Text = "Tarkasta";
            this.tarkastaBT.UseVisualStyleBackColor = false;
            this.tarkastaBT.Click += new System.EventHandler(this.tarkastaBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(-4, 99);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(109, 38);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(996, 324);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.tarkastaBT);
            this.Controls.Add(this.nimiTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Onko nimesi suosittujen joukossa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nimiTB;
        private Button tarkastaBT;
        private Label vastausLB;
    }
}
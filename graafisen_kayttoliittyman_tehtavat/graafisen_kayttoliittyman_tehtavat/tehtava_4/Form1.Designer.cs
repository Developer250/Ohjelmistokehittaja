namespace tehtava_4
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
            this.LaskeIkaBT = new System.Windows.Forms.Button();
            this.SyntymaAikaDT = new System.Windows.Forms.DateTimePicker();
            this.VuosissaLB = new System.Windows.Forms.Label();
            this.KuukausissaLB = new System.Windows.Forms.Label();
            this.PaivissaLB = new System.Windows.Forms.Label();
            this.TunneissaLB = new System.Windows.Forms.Label();
            this.MinuuteissaB = new System.Windows.Forms.Label();
            this.SekunneissaB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LaskeIkaBT
            // 
            this.LaskeIkaBT.Location = new System.Drawing.Point(501, 44);
            this.LaskeIkaBT.Name = "LaskeIkaBT";
            this.LaskeIkaBT.Size = new System.Drawing.Size(94, 29);
            this.LaskeIkaBT.TabIndex = 0;
            this.LaskeIkaBT.Text = "Laske ikä";
            this.LaskeIkaBT.UseVisualStyleBackColor = true;
            this.LaskeIkaBT.Click += new System.EventHandler(this.LaskeIkaBT_Click);
            // 
            // SyntymaAikaDT
            // 
            this.SyntymaAikaDT.Location = new System.Drawing.Point(86, 43);
            this.SyntymaAikaDT.Name = "SyntymaAikaDT";
            this.SyntymaAikaDT.Size = new System.Drawing.Size(250, 27);
            this.SyntymaAikaDT.TabIndex = 1;
            // 
            // VuosissaLB
            // 
            this.VuosissaLB.AutoSize = true;
            this.VuosissaLB.Location = new System.Drawing.Point(99, 100);
            this.VuosissaLB.Name = "VuosissaLB";
            this.VuosissaLB.Size = new System.Drawing.Size(61, 20);
            this.VuosissaLB.TabIndex = 2;
            this.VuosissaLB.Text = "Vuosina";
            this.VuosissaLB.Visible = false;
            // 
            // KuukausissaLB
            // 
            this.KuukausissaLB.AutoSize = true;
            this.KuukausissaLB.Location = new System.Drawing.Point(99, 139);
            this.KuukausissaLB.Name = "KuukausissaLB";
            this.KuukausissaLB.Size = new System.Drawing.Size(87, 20);
            this.KuukausissaLB.TabIndex = 3;
            this.KuukausissaLB.Text = "Kuukausissa";
            this.KuukausissaLB.Visible = false;
            // 
            // PaivissaLB
            // 
            this.PaivissaLB.AutoSize = true;
            this.PaivissaLB.Location = new System.Drawing.Point(99, 178);
            this.PaivissaLB.Name = "PaivissaLB";
            this.PaivissaLB.Size = new System.Drawing.Size(59, 20);
            this.PaivissaLB.TabIndex = 4;
            this.PaivissaLB.Text = "Päivissä";
            this.PaivissaLB.Visible = false;
            // 
            // TunneissaLB
            // 
            this.TunneissaLB.AutoSize = true;
            this.TunneissaLB.Location = new System.Drawing.Point(99, 218);
            this.TunneissaLB.Name = "TunneissaLB";
            this.TunneissaLB.Size = new System.Drawing.Size(73, 20);
            this.TunneissaLB.TabIndex = 5;
            this.TunneissaLB.Text = "Tunneissa";
            this.TunneissaLB.Visible = false;
            // 
            // MinuuteissaB
            // 
            this.MinuuteissaB.AutoSize = true;
            this.MinuuteissaB.Location = new System.Drawing.Point(99, 253);
            this.MinuuteissaB.Name = "MinuuteissaB";
            this.MinuuteissaB.Size = new System.Drawing.Size(87, 20);
            this.MinuuteissaB.TabIndex = 6;
            this.MinuuteissaB.Text = "Minuuteissa";
            this.MinuuteissaB.Visible = false;
            // 
            // SekunneissaB
            // 
            this.SekunneissaB.AutoSize = true;
            this.SekunneissaB.Location = new System.Drawing.Point(99, 290);
            this.SekunneissaB.Name = "SekunneissaB";
            this.SekunneissaB.Size = new System.Drawing.Size(88, 20);
            this.SekunneissaB.TabIndex = 7;
            this.SekunneissaB.Text = "Sekunneissa";
            this.SekunneissaB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SekunneissaB);
            this.Controls.Add(this.MinuuteissaB);
            this.Controls.Add(this.TunneissaLB);
            this.Controls.Add(this.PaivissaLB);
            this.Controls.Add(this.KuukausissaLB);
            this.Controls.Add(this.VuosissaLB);
            this.Controls.Add(this.SyntymaAikaDT);
            this.Controls.Add(this.LaskeIkaBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LaskeIkaBT;
        private DateTimePicker SyntymaAikaDT;
        private Label VuosissaLB;
        private Label KuukausissaLB;
        private Label PaivissaLB;
        private Label TunneissaLB;
        private Label MinuuteissaB;
        private Label SekunneissaB;
    }
}
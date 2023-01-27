namespace tehtava_3
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
            this.laskeBT = new System.Windows.Forms.Button();
            this.LaskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.LukuYksiTB = new System.Windows.Forms.Label();
            this.LukuKaksiTB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LukuKaksiB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(601, 73);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(94, 29);
            this.laskeBT.TabIndex = 0;
            this.laskeBT.Text = "laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(260, 74);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(54, 28);
            this.LaskutoimitusCB.TabIndex = 1;
            // 
            // LukuYksiTB
            // 
            this.LukuYksiTB.AutoSize = true;
            this.LukuYksiTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukuYksiTB.Location = new System.Drawing.Point(97, 59);
            this.LukuYksiTB.Name = "LukuYksiTB";
            this.LukuYksiTB.Size = new System.Drawing.Size(0, 38);
            this.LukuYksiTB.TabIndex = 2;
            // 
            // LukuKaksiTB
            // 
            this.LukuKaksiTB.AutoSize = true;
            this.LukuKaksiTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukuKaksiTB.Location = new System.Drawing.Point(351, 64);
            this.LukuKaksiTB.Name = "LukuKaksiTB";
            this.LukuKaksiTB.Size = new System.Drawing.Size(0, 38);
            this.LukuKaksiTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(525, 78);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(58, 20);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // LukuKaksiB
            // 
            this.LukuKaksiB.AutoSize = true;
            this.LukuKaksiB.Location = new System.Drawing.Point(367, 80);
            this.LukuKaksiB.Name = "LukuKaksiB";
            this.LukuKaksiB.Size = new System.Drawing.Size(50, 20);
            this.LukuKaksiB.TabIndex = 7;
            this.LukuKaksiB.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LukuKaksiB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LukuKaksiTB);
            this.Controls.Add(this.LukuYksiTB);
            this.Controls.Add(this.LaskutoimitusCB);
            this.Controls.Add(this.laskeBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button laskeBT;
        private ComboBox LaskutoimitusCB;
        private Label LukuYksiTB;
        private Label LukuKaksiTB;
        private Label label1;
        private Label VastausLB;
        private Label label2;
        private Label LukuKaksiB;
    }
}
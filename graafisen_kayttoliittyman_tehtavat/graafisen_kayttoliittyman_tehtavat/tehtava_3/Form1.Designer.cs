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
            this.luku1TB = new System.Windows.Forms.TextBox();
            this.luku2TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // laskeBT
            // 
            this.laskeBT.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskeBT.Location = new System.Drawing.Point(622, 74);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(95, 49);
            this.laskeBT.TabIndex = 0;
            this.laskeBT.Text = "laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(260, 74);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(54, 45);
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
            this.label1.Location = new System.Drawing.Point(464, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(489, 77);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(109, 38);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            // 
            // luku1TB
            // 
            this.luku1TB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luku1TB.Location = new System.Drawing.Point(97, 75);
            this.luku1TB.Name = "luku1TB";
            this.luku1TB.Size = new System.Drawing.Size(125, 43);
            this.luku1TB.TabIndex = 6;
            // 
            // luku2TB
            // 
            this.luku2TB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luku2TB.Location = new System.Drawing.Point(333, 78);
            this.luku2TB.Name = "luku2TB";
            this.luku2TB.Size = new System.Drawing.Size(125, 43);
            this.luku2TB.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.luku2TB);
            this.Controls.Add(this.luku1TB);
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
        private TextBox luku1TB;
        private TextBox luku2TB;
    }
}
namespace BMI_laskuri
{
    partial class BMIForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.kuvausLB = new System.Windows.Forms.Label();
            this.kuvainnollinenLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna paino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna pituus:";
            // 
            // painoTB
            // 
            this.painoTB.Location = new System.Drawing.Point(240, 40);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(125, 38);
            this.painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            this.pituusTB.Location = new System.Drawing.Point(240, 100);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(125, 38);
            this.pituusTB.TabIndex = 3;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(62, 161);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(303, 44);
            this.laskeBT.TabIndex = 4;
            this.laskeBT.Text = "Laske painoindeksi";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(62, 234);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(91, 31);
            this.vastausLB.TabIndex = 5;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // kuvausLB
            // 
            this.kuvausLB.AutoSize = true;
            this.kuvausLB.Location = new System.Drawing.Point(66, 292);
            this.kuvausLB.Name = "kuvausLB";
            this.kuvausLB.Size = new System.Drawing.Size(0, 31);
            this.kuvausLB.TabIndex = 6;
            // 
            // kuvainnollinenLB
            // 
            this.kuvainnollinenLB.AutoSize = true;
            this.kuvainnollinenLB.Location = new System.Drawing.Point(65, 293);
            this.kuvainnollinenLB.Name = "kuvainnollinenLB";
            this.kuvainnollinenLB.Size = new System.Drawing.Size(86, 31);
            this.kuvainnollinenLB.TabIndex = 7;
            this.kuvainnollinenLB.Text = "Kuvaus";
            this.kuvainnollinenLB.Visible = false;
            // 
            // BMIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 419);
            this.Controls.Add(this.kuvainnollinenLB);
            this.Controls.Add(this.kuvausLB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BMIForm";
            this.Text = "Painoindeksilaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button laskeBT;
        private Label vastausLB;
        private Label kuvausLB;
        private Label kuvainnollinenLB;
    }
}
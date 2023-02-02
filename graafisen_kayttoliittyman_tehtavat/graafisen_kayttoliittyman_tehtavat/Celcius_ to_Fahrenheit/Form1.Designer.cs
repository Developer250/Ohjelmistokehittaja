namespace Celcius__to_Fahrenheit
{
    partial class AsteMuunninForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.farenheitRB = new System.Windows.Forms.RadioButton();
            this.celsiusRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.asteetTB = new System.Windows.Forms.TextBox();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.farenheitRB);
            this.groupBox1.Controls.Add(this.celsiusRB);
            this.groupBox1.Location = new System.Drawing.Point(425, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mihin muunnat?";
            // 
            // farenheitRB
            // 
            this.farenheitRB.AutoSize = true;
            this.farenheitRB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.farenheitRB.Location = new System.Drawing.Point(31, 95);
            this.farenheitRB.Name = "farenheitRB";
            this.farenheitRB.Size = new System.Drawing.Size(135, 35);
            this.farenheitRB.TabIndex = 1;
            this.farenheitRB.TabStop = true;
            this.farenheitRB.Text = "Farenheit";
            this.farenheitRB.UseVisualStyleBackColor = true;
            // 
            // celsiusRB
            // 
            this.celsiusRB.AutoSize = true;
            this.celsiusRB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.celsiusRB.Location = new System.Drawing.Point(29, 50);
            this.celsiusRB.Name = "celsiusRB";
            this.celsiusRB.Size = new System.Drawing.Size(109, 35);
            this.celsiusRB.TabIndex = 0;
            this.celsiusRB.TabStop = true;
            this.celsiusRB.Text = "Celsius";
            this.celsiusRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anna asteet:";
            // 
            // asteetTB
            // 
            this.asteetTB.Location = new System.Drawing.Point(255, 138);
            this.asteetTB.Name = "asteetTB";
            this.asteetTB.Size = new System.Drawing.Size(130, 38);
            this.asteetTB.TabIndex = 2;
            // 
            // muunnaBT
            // 
            this.muunnaBT.Location = new System.Drawing.Point(738, 149);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(115, 46);
            this.muunnaBT.TabIndex = 3;
            this.muunnaBT.Text = "Muunna";
            this.muunnaBT.UseVisualStyleBackColor = true;
            this.muunnaBT.Click += new System.EventHandler(this.muunnaBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(109, 259);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(91, 31);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // AsteMuunninForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 698);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.asteetTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AsteMuunninForm";
            this.Text = "Aste muunnin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton farenheitRB;
        private RadioButton celsiusRB;
        private Label label1;
        private TextBox asteetTB;
        private Button muunnaBT;
        private Label vastausLB;
    }
}
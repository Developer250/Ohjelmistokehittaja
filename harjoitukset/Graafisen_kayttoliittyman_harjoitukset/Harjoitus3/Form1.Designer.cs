namespace Harjoitus3
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
            this.luku1TB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.laskuCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // luku1TB
            // 
            this.luku1TB.Location = new System.Drawing.Point(97, 42);
            this.luku1TB.Name = "luku1TB";
            this.luku1TB.Size = new System.Drawing.Size(125, 27);
            this.luku1TB.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 27);
            this.textBox1.TabIndex = 1;
            // 
            // laskuCB
            // 
            this.laskuCB.FormattingEnabled = true;
            this.laskuCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.laskuCB.Location = new System.Drawing.Point(261, 41);
            this.laskuCB.Name = "laskuCB";
            this.laskuCB.Size = new System.Drawing.Size(36, 28);
            this.laskuCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vastaus";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Laske";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laskuCB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.luku1TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox luku1TB;
        private TextBox textBox1;
        private ComboBox laskuCB;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
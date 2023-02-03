namespace _10_Kysymysta
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
            this.kysymysLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vastausDRB = new System.Windows.Forms.RadioButton();
            this.vastausCRB = new System.Windows.Forms.RadioButton();
            this.vastausBRB = new System.Windows.Forms.RadioButton();
            this.vastausARB = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.vastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kysymysLB
            // 
            this.kysymysLB.AutoSize = true;
            this.kysymysLB.Location = new System.Drawing.Point(79, 50);
            this.kysymysLB.Name = "kysymysLB";
            this.kysymysLB.Size = new System.Drawing.Size(220, 28);
            this.kysymysLB.TabIndex = 0;
            this.kysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vastausDRB);
            this.groupBox1.Controls.Add(this.vastausCRB);
            this.groupBox1.Controls.Add(this.vastausBRB);
            this.groupBox1.Controls.Add(this.vastausARB);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(354, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vastaus";
            // 
            // vastausDRB
            // 
            this.vastausDRB.AutoSize = true;
            this.vastausDRB.Location = new System.Drawing.Point(6, 164);
            this.vastausDRB.Name = "vastausDRB";
            this.vastausDRB.Size = new System.Drawing.Size(47, 32);
            this.vastausDRB.TabIndex = 4;
            this.vastausDRB.TabStop = true;
            this.vastausDRB.Text = "D";
            this.vastausDRB.UseVisualStyleBackColor = true;
            // 
            // vastausCRB
            // 
            this.vastausCRB.AutoSize = true;
            this.vastausCRB.Location = new System.Drawing.Point(6, 126);
            this.vastausCRB.Name = "vastausCRB";
            this.vastausCRB.Size = new System.Drawing.Size(45, 32);
            this.vastausCRB.TabIndex = 3;
            this.vastausCRB.TabStop = true;
            this.vastausCRB.Text = "C";
            this.vastausCRB.UseVisualStyleBackColor = true;
            // 
            // vastausBRB
            // 
            this.vastausBRB.AutoSize = true;
            this.vastausBRB.Location = new System.Drawing.Point(6, 88);
            this.vastausBRB.Name = "vastausBRB";
            this.vastausBRB.Size = new System.Drawing.Size(44, 32);
            this.vastausBRB.TabIndex = 2;
            this.vastausBRB.TabStop = true;
            this.vastausBRB.Text = "B";
            this.vastausBRB.UseVisualStyleBackColor = true;
            // 
            // vastausARB
            // 
            this.vastausARB.AutoSize = true;
            this.vastausARB.Location = new System.Drawing.Point(6, 50);
            this.vastausARB.Name = "vastausARB";
            this.vastausARB.Size = new System.Drawing.Size(46, 32);
            this.vastausARB.TabIndex = 1;
            this.vastausARB.TabStop = true;
            this.vastausARB.Text = "A";
            this.vastausARB.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 32);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "E";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(92, 232);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(77, 28);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 304);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kysymysLB);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Vastauslomake";
            this.Load += new System.EventHandler(this.vastauslomakeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kysymysLB;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton vastausARB;
        private RadioButton vastausDRB;
        private RadioButton vastausCRB;
        private RadioButton vastausBRB;
        private Label vastausLB;
    }
}
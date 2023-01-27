namespace Harjoitus2
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.tulostusLB = new System.Windows.Forms.Label();
            this.tulostBT = new System.Windows.Forms.Button();
            this.viestiTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(336, 35);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(280, 44);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "tulostettava teksti";
            // 
            // tulostusLB
            // 
            this.tulostusLB.AutoSize = true;
            this.tulostusLB.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tulostusLB.Location = new System.Drawing.Point(107, 150);
            this.tulostusLB.Name = "tulostusLB";
            this.tulostusLB.Size = new System.Drawing.Size(96, 44);
            this.tulostusLB.TabIndex = 1;
            this.tulostusLB.Text = "xxxx";
            this.tulostusLB.Visible = false;
            // 
            // tulostBT
            // 
            this.tulostBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tulostBT.Location = new System.Drawing.Point(636, 279);
            this.tulostBT.Name = "tulostBT";
            this.tulostBT.Size = new System.Drawing.Size(94, 29);
            this.tulostBT.TabIndex = 3;
            this.tulostBT.Text = "tulosta teksti";
            this.tulostBT.UseVisualStyleBackColor = true;
            this.tulostBT.Click += new System.EventHandler(this.tulostBT_Click);
            // 
            // viestiTB
            // 
            this.viestiTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viestiTB.Location = new System.Drawing.Point(138, 246);
            this.viestiTB.Name = "viestiTB";
            this.viestiTB.Size = new System.Drawing.Size(313, 43);
            this.viestiTB.TabIndex = 4;
            this.viestiTB.TextChanged += new System.EventHandler(this.viestiTB_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viestiTB);
            this.Controls.Add(this.tulostBT);
            this.Controls.Add(this.tulostusLB);
            this.Controls.Add(this.OtsikkoLB);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private Label tulostusLB;
        private Button tulostBT;
        private TextBox viestiTB;
    }
}
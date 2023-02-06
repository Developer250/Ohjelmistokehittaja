namespace sekuntikello
{
    partial class sekkariForm
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.kaynnistaBT = new System.Windows.Forms.Button();
            this.lopetaBT = new System.Windows.Forms.Button();
            this.tyhjaaBT = new System.Windows.Forms.Button();
            this.ajanottoTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.Location = new System.Drawing.Point(99, 74);
            this.AikaLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(500, 106);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00:00:00:000.";
            // 
            // kaynnistaBT
            // 
            this.kaynnistaBT.Location = new System.Drawing.Point(136, 229);
            this.kaynnistaBT.Name = "kaynnistaBT";
            this.kaynnistaBT.Size = new System.Drawing.Size(152, 48);
            this.kaynnistaBT.TabIndex = 1;
            this.kaynnistaBT.Text = "Käynnistä";
            this.kaynnistaBT.UseVisualStyleBackColor = true;
            this.kaynnistaBT.Click += new System.EventHandler(this.kaynnistaBT_Click);
            // 
            // lopetaBT
            // 
            this.lopetaBT.Location = new System.Drawing.Point(408, 229);
            this.lopetaBT.Name = "lopetaBT";
            this.lopetaBT.Size = new System.Drawing.Size(187, 48);
            this.lopetaBT.TabIndex = 2;
            this.lopetaBT.Text = "Lopeta";
            this.lopetaBT.UseVisualStyleBackColor = true;
            this.lopetaBT.Click += new System.EventHandler(this.lopetaBT_Click);
            // 
            // tyhjaaBT
            // 
            this.tyhjaaBT.Location = new System.Drawing.Point(715, 229);
            this.tyhjaaBT.Name = "tyhjaaBT";
            this.tyhjaaBT.Size = new System.Drawing.Size(164, 48);
            this.tyhjaaBT.TabIndex = 3;
            this.tyhjaaBT.Text = "Tyhjennä";
            this.tyhjaaBT.UseVisualStyleBackColor = true;
            this.tyhjaaBT.Click += new System.EventHandler(this.tyhjaaBT_Click);
            // 
            // ajanottoTM
            // 
            this.ajanottoTM.Enabled = true;
            this.ajanottoTM.Tick += new System.EventHandler(this.ajanottoTM_Tick);
            // 
            // sekkariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.tyhjaaBT);
            this.Controls.Add(this.lopetaBT);
            this.Controls.Add(this.kaynnistaBT);
            this.Controls.Add(this.AikaLB);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sekkariForm";
            this.Text = "sekuntikello";
            this.Load += new System.EventHandler(this.sekkariForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AikaLB;
        private Button kaynnistaBT;
        private Button lopetaBT;
        private Button tyhjaaBT;
        private System.Windows.Forms.Timer ajanottoTM;
    }
}
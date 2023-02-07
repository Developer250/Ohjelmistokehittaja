namespace Ajastin
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
            this.components = new System.ComponentModel.Container();
            this.stopBT = new System.Windows.Forms.Button();
            this.startBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aikaLB = new System.Windows.Forms.Label();
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.sekunnitCB = new System.Windows.Forms.ComboBox();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // stopBT
            // 
            this.stopBT.Location = new System.Drawing.Point(212, 285);
            this.stopBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(117, 37);
            this.stopBT.TabIndex = 0;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // startBT
            // 
            this.startBT.Location = new System.Drawing.Point(42, 285);
            this.startBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(117, 37);
            this.startBT.TabIndex = 1;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minuutit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sekunnit";
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(75, 159);
            this.aikaLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(234, 106);
            this.aikaLB.TabIndex = 4;
            this.aikaLB.Text = "00:00";
            // 
            // minuutitCB
            // 
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Location = new System.Drawing.Point(32, 96);
            this.minuutitCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minuutitCB.Size = new System.Drawing.Size(127, 33);
            this.minuutitCB.TabIndex = 5;
            // 
            // sekunnitCB
            // 
            this.sekunnitCB.FormattingEnabled = true;
            this.sekunnitCB.Location = new System.Drawing.Point(212, 96);
            this.sekunnitCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sekunnitCB.Name = "sekunnitCB";
            this.sekunnitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sekunnitCB.Size = new System.Drawing.Size(127, 33);
            this.sekunnitCB.TabIndex = 6;
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 1000;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 388);
            this.Controls.Add(this.sekunnitCB);
            this.Controls.Add(this.minuutitCB);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.stopBT);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button stopBT;
        private Button startBT;
        private Label label1;
        private Label label2;
        private Label aikaLB;
        private ComboBox minuutitCB;
        private ComboBox sekunnitCB;
        private System.Windows.Forms.Timer AjastinTM;
    }
}
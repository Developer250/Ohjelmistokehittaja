namespace Paivakirja
{
    partial class paivakirjaForm
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
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyottoTB
            // 
            this.SyottoTB.Location = new System.Drawing.Point(48, 36);
            this.SyottoTB.Multiline = true;
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(1270, 702);
            this.SyottoTB.TabIndex = 0;
            // 
            // tallennaBT
            // 
            this.tallennaBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tallennaBT.Location = new System.Drawing.Point(146, 756);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(1105, 65);
            this.tallennaBT.TabIndex = 1;
            this.tallennaBT.Text = "Tallenna päiväkirjaan";
            this.tallennaBT.UseVisualStyleBackColor = false;
            this.tallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // paivakirjaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1515, 833);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.SyottoTB);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "paivakirjaForm";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SyottoTB;
        private Button tallennaBT;
    }
}
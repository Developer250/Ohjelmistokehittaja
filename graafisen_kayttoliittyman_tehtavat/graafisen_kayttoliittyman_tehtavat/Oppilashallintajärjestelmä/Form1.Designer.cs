﻿namespace Oppilashallintajärjestelmä
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tietotauluDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.spostiTB = new System.Windows.Forms.TextBox();
            this.opiskelijanroTB = new System.Windows.Forms.TextBox();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.puhTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // tietotauluDG
            // 
            this.tietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tietotauluDG.Location = new System.Drawing.Point(12, 171);
            this.tietotauluDG.Name = "tietotauluDG";
            this.tietotauluDG.RowHeadersWidth = 51;
            this.tietotauluDG.RowTemplate.Height = 24;
            this.tietotauluDG.Size = new System.Drawing.Size(776, 276);
            this.tietotauluDG.TabIndex = 0;
            this.tietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tietotauluDG_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Etunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sukunimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opiskelijanro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sähöposti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Puhelin:";
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(157, 27);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(143, 22);
            this.IdTB.TabIndex = 7;
            // 
            // snimiTB
            // 
            this.snimiTB.Location = new System.Drawing.Point(157, 85);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(143, 22);
            this.snimiTB.TabIndex = 8;
            // 
            // enimiTB
            // 
            this.enimiTB.Location = new System.Drawing.Point(157, 59);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(143, 22);
            this.enimiTB.TabIndex = 9;
            // 
            // spostiTB
            // 
            this.spostiTB.Location = new System.Drawing.Point(548, 59);
            this.spostiTB.Name = "spostiTB";
            this.spostiTB.Size = new System.Drawing.Size(153, 22);
            this.spostiTB.TabIndex = 10;
            // 
            // opiskelijanroTB
            // 
            this.opiskelijanroTB.Location = new System.Drawing.Point(548, 87);
            this.opiskelijanroTB.Name = "opiskelijanroTB";
            this.opiskelijanroTB.Size = new System.Drawing.Size(153, 22);
            this.opiskelijanroTB.TabIndex = 12;
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.BackColor = System.Drawing.Color.NavajoWhite;
            this.tyhjennaBT.Location = new System.Drawing.Point(42, 131);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(100, 34);
            this.tyhjennaBT.TabIndex = 13;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = false;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.BackColor = System.Drawing.Color.NavajoWhite;
            this.tallennaBT.Location = new System.Drawing.Point(181, 131);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(107, 34);
            this.tallennaBT.TabIndex = 14;
            this.tallennaBT.Text = "Tallenna";
            this.tallennaBT.UseVisualStyleBackColor = false;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.BackColor = System.Drawing.Color.NavajoWhite;
            this.paivitaBT.Location = new System.Drawing.Point(361, 131);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(89, 34);
            this.paivitaBT.TabIndex = 15;
            this.paivitaBT.Text = "Päivitä";
            this.paivitaBT.UseVisualStyleBackColor = false;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.BackColor = System.Drawing.Color.NavajoWhite;
            this.poistaBT.Location = new System.Drawing.Point(548, 131);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(100, 34);
            this.poistaBT.TabIndex = 16;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = false;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // puhTB
            // 
            this.puhTB.Location = new System.Drawing.Point(548, 28);
            this.puhTB.Name = "puhTB";
            this.puhTB.Size = new System.Drawing.Size(153, 22);
            this.puhTB.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.puhTB);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.opiskelijanroTB);
            this.Controls.Add(this.spostiTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tietotauluDG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tietotauluDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox spostiTB;
        private System.Windows.Forms.TextBox opiskelijanroTB;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.TextBox puhTB;
    }
}


﻿namespace Hotellivarausjarjestelma
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageClients = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageClients,
            this.manageReservations,
            this.manageRooms});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageClients
            // 
            this.manageClients.Name = "manageClients";
            this.manageClients.Size = new System.Drawing.Size(121, 24);
            this.manageClients.Text = "manageClients";
            this.manageClients.Click += new System.EventHandler(this.manageClients_Click);
            // 
            // manageReservations
            // 
            this.manageReservations.Name = "manageReservations";
            this.manageReservations.Size = new System.Drawing.Size(160, 24);
            this.manageReservations.Text = "manageReservations";
            this.manageReservations.Click += new System.EventHandler(this.manageReservations_Click);
            // 
            // manageRooms
            // 
            this.manageRooms.Name = "manageRooms";
            this.manageRooms.Size = new System.Drawing.Size(123, 24);
            this.manageRooms.Text = "manageRooms";
            this.manageRooms.Click += new System.EventHandler(this.manageRooms_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageClients;
        private System.Windows.Forms.ToolStripMenuItem manageReservations;
        private System.Windows.Forms.ToolStripMenuItem manageRooms;
    }
}

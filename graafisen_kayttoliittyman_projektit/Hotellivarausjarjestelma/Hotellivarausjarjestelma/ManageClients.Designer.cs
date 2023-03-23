namespace Hotellivarausjarjestelma
{
    partial class ManageClients
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
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonEditCLient = new System.Windows.Forms.Button();
            this.buttonClearClient = new System.Windows.Forms.Button();
            this.buttonRemoveClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIrstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(95, 328);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 0;
            this.buttonAddClient.Text = "button1";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonEditCLient
            // 
            this.buttonEditCLient.Location = new System.Drawing.Point(95, 357);
            this.buttonEditCLient.Name = "buttonEditCLient";
            this.buttonEditCLient.Size = new System.Drawing.Size(75, 23);
            this.buttonEditCLient.TabIndex = 1;
            this.buttonEditCLient.Text = "button2";
            this.buttonEditCLient.UseVisualStyleBackColor = true;
            this.buttonEditCLient.Click += new System.EventHandler(this.buttonEditCLient_Click);
            // 
            // buttonClearClient
            // 
            this.buttonClearClient.Location = new System.Drawing.Point(206, 357);
            this.buttonClearClient.Name = "buttonClearClient";
            this.buttonClearClient.Size = new System.Drawing.Size(75, 23);
            this.buttonClearClient.TabIndex = 2;
            this.buttonClearClient.Text = "button3";
            this.buttonClearClient.UseVisualStyleBackColor = true;
            this.buttonClearClient.Click += new System.EventHandler(this.buttonClearClient_Click);
            // 
            // buttonRemoveClient
            // 
            this.buttonRemoveClient.Location = new System.Drawing.Point(206, 328);
            this.buttonRemoveClient.Name = "buttonRemoveClient";
            this.buttonRemoveClient.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveClient.TabIndex = 3;
            this.buttonRemoveClient.Text = "button4";
            this.buttonRemoveClient.UseVisualStyleBackColor = true;
            this.buttonRemoveClient.Click += new System.EventHandler(this.buttonRemoveClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(480, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(308, 396);
            this.dataGridView1.TabIndex = 4;
            // 
            // FIrstName
            // 
            this.FIrstName.AutoSize = true;
            this.FIrstName.Location = new System.Drawing.Point(37, 51);
            this.FIrstName.Name = "FIrstName";
            this.FIrstName.Size = new System.Drawing.Size(69, 16);
            this.FIrstName.TabIndex = 5;
            this.FIrstName.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(37, 133);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(55, 16);
            this.country.TabIndex = 8;
            this.country.Text = "Country:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(37, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(23, 16);
            this.ID.TabIndex = 11;
            this.ID.Text = "ID:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(145, 51);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(136, 22);
            this.textBoxFirstName.TabIndex = 12;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(145, 79);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(136, 22);
            this.textBoxLastName.TabIndex = 13;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(145, 107);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(136, 22);
            this.textBoxPhone.TabIndex = 14;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(145, 135);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(136, 22);
            this.textBoxCountry.TabIndex = 15;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(145, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(136, 22);
            this.textBoxID.TabIndex = 18;
            // 
            // ManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIrstName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRemoveClient);
            this.Controls.Add(this.buttonClearClient);
            this.Controls.Add(this.buttonEditCLient);
            this.Controls.Add(this.buttonAddClient);
            this.Name = "ManageClients";
            this.Text = "ManageClients";
            this.Load += new System.EventHandler(this.ManageClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonEditCLient;
        private System.Windows.Forms.Button buttonClearClient;
        private System.Windows.Forms.Button buttonRemoveClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FIrstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxID;
    }
}
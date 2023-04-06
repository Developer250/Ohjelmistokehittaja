namespace Hotel_Management_System
{
    partial class ReservationForm
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
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.comboBox_roomNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_reserv = new System.Windows.Forms.DataGridView();
            this.texBox_guestId = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dateOUT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_guestId = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.editReserv = new System.Windows.Forms.Button();
            this.deleteReserv = new System.Windows.Forms.Button();
            this.cleanReserv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Location = new System.Drawing.Point(171, 110);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(121, 24);
            this.comboBox_roomType.TabIndex = 0;
            this.comboBox_roomType.SelectedIndexChanged += new System.EventHandler(this.comboBox_roomType_SelectedIndexChanged);
            // 
            // comboBox_roomNo
            // 
            this.comboBox_roomNo.FormattingEnabled = true;
            this.comboBox_roomNo.Location = new System.Drawing.Point(171, 141);
            this.comboBox_roomNo.Name = "comboBox_roomNo";
            this.comboBox_roomNo.Size = new System.Drawing.Size(121, 24);
            this.comboBox_roomNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reserv ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Guest ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Room NO:";
            // 
            // dataGridView_reserv
            // 
            this.dataGridView_reserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_reserv.Location = new System.Drawing.Point(484, 70);
            this.dataGridView_reserv.Name = "dataGridView_reserv";
            this.dataGridView_reserv.RowHeadersWidth = 51;
            this.dataGridView_reserv.RowTemplate.Height = 24;
            this.dataGridView_reserv.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_reserv.TabIndex = 6;
            // 
            // texBox_guestId
            // 
            this.texBox_guestId.Location = new System.Drawing.Point(171, 34);
            this.texBox_guestId.Name = "texBox_guestId";
            this.texBox_guestId.Size = new System.Drawing.Size(100, 22);
            this.texBox_guestId.TabIndex = 7;
            // 
            // dateTimePicker_dateOUT
            // 
            this.dateTimePicker_dateOUT.CustomFormat = "dd//mm//yyyy";
            this.dateTimePicker_dateOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateOUT.Location = new System.Drawing.Point(171, 255);
            this.dateTimePicker_dateOUT.Name = "dateTimePicker_dateOUT";
            this.dateTimePicker_dateOUT.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_dateOUT.TabIndex = 8;
            // 
            // dateTimePicker_dateIn
            // 
            this.dateTimePicker_dateIn.CustomFormat = "dd//mm/yyy";
            this.dateTimePicker_dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateIn.Location = new System.Drawing.Point(171, 221);
            this.dateTimePicker_dateIn.Name = "dateTimePicker_dateIn";
            this.dateTimePicker_dateIn.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_dateIn.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date IN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // textBox_guestId
            // 
            this.textBox_guestId.Location = new System.Drawing.Point(171, 70);
            this.textBox_guestId.Name = "textBox_guestId";
            this.textBox_guestId.Size = new System.Drawing.Size(100, 22);
            this.textBox_guestId.TabIndex = 12;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(98, 330);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // editReserv
            // 
            this.editReserv.Location = new System.Drawing.Point(217, 330);
            this.editReserv.Name = "editReserv";
            this.editReserv.Size = new System.Drawing.Size(75, 23);
            this.editReserv.TabIndex = 14;
            this.editReserv.Text = "button2";
            this.editReserv.UseVisualStyleBackColor = true;
            // 
            // deleteReserv
            // 
            this.deleteReserv.Location = new System.Drawing.Point(98, 381);
            this.deleteReserv.Name = "deleteReserv";
            this.deleteReserv.Size = new System.Drawing.Size(75, 23);
            this.deleteReserv.TabIndex = 15;
            this.deleteReserv.Text = "button3";
            this.deleteReserv.UseVisualStyleBackColor = true;
            // 
            // cleanReserv
            // 
            this.cleanReserv.Location = new System.Drawing.Point(217, 381);
            this.cleanReserv.Name = "cleanReserv";
            this.cleanReserv.Size = new System.Drawing.Size(75, 23);
            this.cleanReserv.TabIndex = 16;
            this.cleanReserv.Text = "button4";
            this.cleanReserv.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cleanReserv);
            this.Controls.Add(this.deleteReserv);
            this.Controls.Add(this.editReserv);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_guestId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_dateIn);
            this.Controls.Add(this.dateTimePicker_dateOUT);
            this.Controls.Add(this.texBox_guestId);
            this.Controls.Add(this.dataGridView_reserv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_roomNo);
            this.Controls.Add(this.comboBox_roomType);
            this.Name = "ReservationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.ComboBox comboBox_roomNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_reserv;
        private System.Windows.Forms.TextBox texBox_guestId;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateOUT;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_guestId;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button editReserv;
        private System.Windows.Forms.Button deleteReserv;
        private System.Windows.Forms.Button cleanReserv;
    }
}


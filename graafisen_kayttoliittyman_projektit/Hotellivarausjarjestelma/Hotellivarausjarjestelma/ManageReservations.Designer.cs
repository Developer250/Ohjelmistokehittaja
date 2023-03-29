namespace Hotellivarausjarjestelma
{
    partial class ManageReservations
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
            this.dataGridView1Reservations = new System.Windows.Forms.DataGridView();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.roomNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomType = new System.Windows.Forms.Label();
            this.buttonClearReserv = new System.Windows.Forms.Button();
            this.buttonRemoveReserv = new System.Windows.Forms.Button();
            this.buttonEditReserv = new System.Windows.Forms.Button();
            this.buttonAddReserv = new System.Windows.Forms.Button();
            this.textBoxReservID = new System.Windows.Forms.TextBox();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1Reservations
            // 
            this.dataGridView1Reservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1Reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Reservations.Location = new System.Drawing.Point(439, 29);
            this.dataGridView1Reservations.Name = "dataGridView1Reservations";
            this.dataGridView1Reservations.RowHeadersWidth = 51;
            this.dataGridView1Reservations.RowTemplate.Height = 24;
            this.dataGridView1Reservations.Size = new System.Drawing.Size(341, 393);
            this.dataGridView1Reservations.TabIndex = 46;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(198, 97);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(192, 30);
            this.comboBoxRoomType.TabIndex = 45;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(198, 29);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(163, 28);
            this.textBoxClientID.TabIndex = 43;
            // 
            // roomNumber
            // 
            this.roomNumber.AutoSize = true;
            this.roomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.Location = new System.Drawing.Point(90, 35);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(83, 22);
            this.roomNumber.TabIndex = 41;
            this.roomNumber.Text = "Client ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Room Type:";
            // 
            // roomType
            // 
            this.roomType.AutoSize = true;
            this.roomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.Location = new System.Drawing.Point(90, 69);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(94, 22);
            this.roomType.TabIndex = 39;
            this.roomType.Text = "Reserv ID:";
            // 
            // buttonClearReserv
            // 
            this.buttonClearReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearReserv.Location = new System.Drawing.Point(241, 315);
            this.buttonClearReserv.Name = "buttonClearReserv";
            this.buttonClearReserv.Size = new System.Drawing.Size(192, 43);
            this.buttonClearReserv.TabIndex = 38;
            this.buttonClearReserv.Text = "Clear Fields";
            this.buttonClearReserv.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveReserv
            // 
            this.buttonRemoveReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveReserv.Location = new System.Drawing.Point(241, 377);
            this.buttonRemoveReserv.Name = "buttonRemoveReserv";
            this.buttonRemoveReserv.Size = new System.Drawing.Size(192, 45);
            this.buttonRemoveReserv.TabIndex = 37;
            this.buttonRemoveReserv.Text = "Remove";
            this.buttonRemoveReserv.UseVisualStyleBackColor = true;
            // 
            // buttonEditReserv
            // 
            this.buttonEditReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditReserv.Location = new System.Drawing.Point(28, 377);
            this.buttonEditReserv.Name = "buttonEditReserv";
            this.buttonEditReserv.Size = new System.Drawing.Size(207, 45);
            this.buttonEditReserv.TabIndex = 36;
            this.buttonEditReserv.Text = "Edit";
            this.buttonEditReserv.UseVisualStyleBackColor = true;
            // 
            // buttonAddReserv
            // 
            this.buttonAddReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddReserv.Location = new System.Drawing.Point(28, 315);
            this.buttonAddReserv.Name = "buttonAddReserv";
            this.buttonAddReserv.Size = new System.Drawing.Size(207, 43);
            this.buttonAddReserv.TabIndex = 35;
            this.buttonAddReserv.Text = "Add new Reservation";
            this.buttonAddReserv.UseVisualStyleBackColor = true;
            // 
            // textBoxReservID
            // 
            this.textBoxReservID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReservID.Location = new System.Drawing.Point(198, 63);
            this.textBoxReservID.Name = "textBoxReservID";
            this.textBoxReservID.Size = new System.Drawing.Size(163, 28);
            this.textBoxReservID.TabIndex = 48;
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(198, 133);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(192, 30);
            this.comboBoxRoomNumber.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Room Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Date IN:";
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.CustomFormat = "dd//MM//yyyy";
            this.dateTimePickerIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIN.Location = new System.Drawing.Point(269, 198);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(121, 24);
            this.dateTimePickerIN.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 55;
            this.label4.Text = "Date OUT:";
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.CustomFormat = "dd//MM//yyyy";
            this.dateTimePickerOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOUT.Location = new System.Drawing.Point(269, 228);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(121, 24);
            this.dateTimePickerOUT.TabIndex = 57;
            // 
            // ManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.dateTimePickerOUT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRoomNumber);
            this.Controls.Add(this.textBoxReservID);
            this.Controls.Add(this.dataGridView1Reservations);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.buttonClearReserv);
            this.Controls.Add(this.buttonRemoveReserv);
            this.Controls.Add(this.buttonEditReserv);
            this.Controls.Add(this.buttonAddReserv);
            this.Name = "ManageReservations";
            this.Text = "ManageReservations";
            this.Load += new System.EventHandler(this.ManageReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Reservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1Reservations;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label roomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label roomType;
        private System.Windows.Forms.Button buttonClearReserv;
        private System.Windows.Forms.Button buttonRemoveReserv;
        private System.Windows.Forms.Button buttonEditReserv;
        private System.Windows.Forms.Button buttonAddReserv;
        private System.Windows.Forms.TextBox textBoxReservID;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT;
    }
}
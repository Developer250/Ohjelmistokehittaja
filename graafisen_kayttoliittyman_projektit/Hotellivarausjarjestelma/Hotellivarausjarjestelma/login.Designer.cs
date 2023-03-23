namespace Hotellivarausjarjestelma
{
    partial class signIn
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
            this.username = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(70, 68);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 16);
            this.username.TabIndex = 5;
            this.username.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(202, 68);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsername.TabIndex = 11;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(202, 100);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 16;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(182, 155);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(139, 44);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(70, 103);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 16);
            this.Password.TabIndex = 17;
            this.Password.Text = "Password:";
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login);
            this.Name = "signIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.signIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label Password;
    }
}
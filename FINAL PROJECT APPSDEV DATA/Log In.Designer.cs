namespace WindowsFormsAppMilkyWay
{
	partial class Log_In
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In));
			this.login_usernamee = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.Login_toDash = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.exit = new System.Windows.Forms.Button();
			this.login_password = new System.Windows.Forms.TextBox();
			this.ForgetPassword = new System.Windows.Forms.Label();
			this.login_checkBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// login_usernamee
			// 
			this.login_usernamee.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.login_usernamee.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_usernamee.Location = new System.Drawing.Point(293, 182);
			this.login_usernamee.Multiline = true;
			this.login_usernamee.Name = "login_usernamee";
			this.login_usernamee.Size = new System.Drawing.Size(199, 31);
			this.login_usernamee.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(348, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Log In";
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.BackColor = System.Drawing.Color.Transparent;
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.username.Location = new System.Drawing.Point(292, 163);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(71, 15);
			this.username.TabIndex = 3;
			this.username.Text = "username";
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.BackColor = System.Drawing.Color.Transparent;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.password.Location = new System.Drawing.Point(292, 224);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(68, 15);
			this.password.TabIndex = 4;
			this.password.Text = "password";
			// 
			// Login_toDash
			// 
			this.Login_toDash.BackColor = System.Drawing.Color.SteelBlue;
			this.Login_toDash.FlatAppearance.BorderSize = 0;
			this.Login_toDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Login_toDash.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Login_toDash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Login_toDash.Location = new System.Drawing.Point(293, 330);
			this.Login_toDash.Name = "Login_toDash";
			this.Login_toDash.Size = new System.Drawing.Size(199, 47);
			this.Login_toDash.TabIndex = 5;
			this.Login_toDash.Text = "Log In";
			this.Login_toDash.UseVisualStyleBackColor = false;
			this.Login_toDash.Click += new System.EventHandler(this.Login_toDash_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(305, 428);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 14);
			this.label2.TabIndex = 6;
			this.label2.Text = "Have no account yet?";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(416, 426);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Sign up";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// exit
			// 
			this.exit.BackColor = System.Drawing.Color.Transparent;
			this.exit.FlatAppearance.BorderSize = 0;
			this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.exit.Location = new System.Drawing.Point(550, 83);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(26, 22);
			this.exit.TabIndex = 8;
			this.exit.Text = "X";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// login_password
			// 
			this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.login_password.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_password.Location = new System.Drawing.Point(293, 242);
			this.login_password.Multiline = true;
			this.login_password.Name = "login_password";
			this.login_password.PasswordChar = '*';
			this.login_password.Size = new System.Drawing.Size(199, 31);
			this.login_password.TabIndex = 9;
			// 
			// ForgetPassword
			// 
			this.ForgetPassword.AutoSize = true;
			this.ForgetPassword.BackColor = System.Drawing.Color.Transparent;
			this.ForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForgetPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ForgetPassword.Location = new System.Drawing.Point(333, 381);
			this.ForgetPassword.Name = "ForgetPassword";
			this.ForgetPassword.Size = new System.Drawing.Size(107, 13);
			this.ForgetPassword.TabIndex = 10;
			this.ForgetPassword.Text = "Forget password?";
			this.ForgetPassword.Click += new System.EventHandler(this.label4_Click);
			// 
			// login_checkBox
			// 
			this.login_checkBox.AutoSize = true;
			this.login_checkBox.BackColor = System.Drawing.Color.Transparent;
			this.login_checkBox.ForeColor = System.Drawing.Color.Transparent;
			this.login_checkBox.Location = new System.Drawing.Point(387, 283);
			this.login_checkBox.Name = "login_checkBox";
			this.login_checkBox.Size = new System.Drawing.Size(102, 17);
			this.login_checkBox.TabIndex = 16;
			this.login_checkBox.Text = "Show Password";
			this.login_checkBox.UseVisualStyleBackColor = false;
			this.login_checkBox.CheckedChanged += new System.EventHandler(this.login_checkBox_CheckedChanged);
			// 
			// Log_In
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(770, 526);
			this.Controls.Add(this.login_checkBox);
			this.Controls.Add(this.ForgetPassword);
			this.Controls.Add(this.login_password);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Login_toDash);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.login_usernamee);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Log_In";
			this.Text = "Log_In";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox login_usernamee;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label username;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.Button Login_toDash;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.TextBox login_password;
		private System.Windows.Forms.Label ForgetPassword;
		private System.Windows.Forms.CheckBox login_checkBox;
	}
}
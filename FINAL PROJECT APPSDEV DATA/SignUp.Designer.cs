namespace WindowsFormsAppMilkyWay
{
	partial class SignUp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
			this.register_password = new System.Windows.Forms.TextBox();
			this.register_Cpassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.box = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.exit = new System.Windows.Forms.Button();
			this.creatAcc = new System.Windows.Forms.Button();
			this.signup_checkedBox = new System.Windows.Forms.CheckBox();
			this.register_usernamee = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// register_password
			// 
			this.register_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.register_password.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_password.Location = new System.Drawing.Point(291, 248);
			this.register_password.Multiline = true;
			this.register_password.Name = "register_password";
			this.register_password.PasswordChar = '*';
			this.register_password.Size = new System.Drawing.Size(199, 31);
			this.register_password.TabIndex = 3;
			// 
			// register_Cpassword
			// 
			this.register_Cpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.register_Cpassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_Cpassword.Location = new System.Drawing.Point(291, 300);
			this.register_Cpassword.Multiline = true;
			this.register_Cpassword.Name = "register_Cpassword";
			this.register_Cpassword.PasswordChar = '*';
			this.register_Cpassword.Size = new System.Drawing.Size(199, 31);
			this.register_Cpassword.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(339, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 32);
			this.label1.TabIndex = 8;
			this.label1.Text = "Sign Up";
			// 
			// box
			// 
			this.box.AutoSize = true;
			this.box.BackColor = System.Drawing.Color.Transparent;
			this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.box.Location = new System.Drawing.Point(288, 178);
			this.box.Name = "box";
			this.box.Size = new System.Drawing.Size(73, 15);
			this.box.TabIndex = 10;
			this.box.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(288, 230);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 15);
			this.label3.TabIndex = 11;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(288, 282);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 15);
			this.label4.TabIndex = 12;
			this.label4.Text = "Confirm Password";
			// 
			// exit
			// 
			this.exit.BackColor = System.Drawing.Color.Transparent;
			this.exit.FlatAppearance.BorderSize = 0;
			this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.exit.Location = new System.Drawing.Point(567, 63);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(26, 22);
			this.exit.TabIndex = 13;
			this.exit.Text = "X";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// creatAcc
			// 
			this.creatAcc.BackColor = System.Drawing.Color.SteelBlue;
			this.creatAcc.FlatAppearance.BorderSize = 0;
			this.creatAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.creatAcc.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.creatAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.creatAcc.Location = new System.Drawing.Point(291, 391);
			this.creatAcc.Name = "creatAcc";
			this.creatAcc.Size = new System.Drawing.Size(199, 47);
			this.creatAcc.TabIndex = 14;
			this.creatAcc.Text = "Create Account";
			this.creatAcc.UseVisualStyleBackColor = false;
			this.creatAcc.Click += new System.EventHandler(this.creatAcc_Click);
			// 
			// signup_checkedBox
			// 
			this.signup_checkedBox.AutoSize = true;
			this.signup_checkedBox.BackColor = System.Drawing.Color.Transparent;
			this.signup_checkedBox.ForeColor = System.Drawing.Color.Transparent;
			this.signup_checkedBox.Location = new System.Drawing.Point(388, 337);
			this.signup_checkedBox.Name = "signup_checkedBox";
			this.signup_checkedBox.Size = new System.Drawing.Size(102, 17);
			this.signup_checkedBox.TabIndex = 15;
			this.signup_checkedBox.Text = "Show Password";
			this.signup_checkedBox.UseVisualStyleBackColor = false;
			this.signup_checkedBox.CheckedChanged += new System.EventHandler(this.signup_checkedBox_CheckedChanged);
			// 
			// register_usernamee
			// 
			this.register_usernamee.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.register_usernamee.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register_usernamee.Location = new System.Drawing.Point(291, 196);
			this.register_usernamee.Multiline = true;
			this.register_usernamee.Name = "register_usernamee";
			this.register_usernamee.Size = new System.Drawing.Size(199, 31);
			this.register_usernamee.TabIndex = 17;
			// 
			// SignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(773, 567);
			this.Controls.Add(this.register_usernamee);
			this.Controls.Add(this.signup_checkedBox);
			this.Controls.Add(this.creatAcc);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.box);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.register_Cpassword);
			this.Controls.Add(this.register_password);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUp";
			this.Text = "SignUp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox register_password;
		private System.Windows.Forms.TextBox register_Cpassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label box;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Button creatAcc;
		private System.Windows.Forms.CheckBox signup_checkedBox;
		private System.Windows.Forms.TextBox register_usernamee;
	}
}
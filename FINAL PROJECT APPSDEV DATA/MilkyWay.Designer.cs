namespace WindowsFormsAppMilkyWay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.exit = new System.Windows.Forms.Button();
			this.login1 = new System.Windows.Forms.Label();
			this.about = new System.Windows.Forms.Label();
			this.signup = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// exit
			// 
			this.exit.BackColor = System.Drawing.Color.Transparent;
			this.exit.FlatAppearance.BorderSize = 0;
			this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.exit.Location = new System.Drawing.Point(772, 12);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(26, 22);
			this.exit.TabIndex = 0;
			this.exit.Text = "X";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// login1
			// 
			this.login1.AutoSize = true;
			this.login1.BackColor = System.Drawing.Color.Transparent;
			this.login1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login1.Location = new System.Drawing.Point(555, 55);
			this.login1.Name = "login1";
			this.login1.Size = new System.Drawing.Size(47, 17);
			this.login1.TabIndex = 2;
			this.login1.Text = "Log In";
			this.login1.Click += new System.EventHandler(this.login1_Click);
			// 
			// about
			// 
			this.about.AutoSize = true;
			this.about.BackColor = System.Drawing.Color.Transparent;
			this.about.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.about.Location = new System.Drawing.Point(443, 55);
			this.about.Name = "about";
			this.about.Size = new System.Drawing.Size(46, 17);
			this.about.TabIndex = 3;
			this.about.Text = "About";
			this.about.Click += new System.EventHandler(this.about_Click);
			// 
			// signup
			// 
			this.signup.BackColor = System.Drawing.Color.SteelBlue;
			this.signup.FlatAppearance.BorderSize = 0;
			this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.signup.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.signup.Location = new System.Drawing.Point(668, 46);
			this.signup.Name = "signup";
			this.signup.Size = new System.Drawing.Size(79, 34);
			this.signup.TabIndex = 4;
			this.signup.Text = "Sign Up";
			this.signup.UseVisualStyleBackColor = false;
			this.signup.Click += new System.EventHandler(this.signup_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(810, 576);
			this.Controls.Add(this.signup);
			this.Controls.Add(this.about);
			this.Controls.Add(this.login1);
			this.Controls.Add(this.exit);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Display Page";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Label login1;
		private System.Windows.Forms.Label about;
		private System.Windows.Forms.Button signup;
	}
}


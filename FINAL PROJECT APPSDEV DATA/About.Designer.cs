namespace WindowsFormsAppMilkyWay
{
	partial class About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.label1 = new System.Windows.Forms.Label();
			this.login1 = new System.Windows.Forms.Label();
			this.signup = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(443, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "About";
			// 
			// login1
			// 
			this.login1.AutoSize = true;
			this.login1.BackColor = System.Drawing.Color.Transparent;
			this.login1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login1.Location = new System.Drawing.Point(555, 55);
			this.login1.Name = "login1";
			this.login1.Size = new System.Drawing.Size(47, 17);
			this.login1.TabIndex = 5;
			this.login1.Text = "Log In";
			this.login1.Click += new System.EventHandler(this.login1_Click);
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
			this.signup.TabIndex = 6;
			this.signup.Text = "Sign Up";
			this.signup.UseVisualStyleBackColor = false;
			this.signup.Click += new System.EventHandler(this.signup_Click);
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
			this.exit.TabIndex = 7;
			this.exit.Text = "X";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(180, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 55);
			this.label2.TabIndex = 8;
			this.label2.Text = "         ";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(810, 576);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.signup);
			this.Controls.Add(this.login1);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "About";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label login1;
		private System.Windows.Forms.Button signup;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Label label2;
	}
}
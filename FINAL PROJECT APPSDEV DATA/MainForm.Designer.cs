namespace WindowsFormsAppMilkyWay
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelSideMenu = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.customerSup_btn = new System.Windows.Forms.Button();
			this.message_btn = new System.Windows.Forms.Button();
			this.panelAccountSubMenu = new System.Windows.Forms.Panel();
			this.profile_btn = new System.Windows.Forms.Button();
			this.account_btn = new System.Windows.Forms.Button();
			this.home_btn = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.panel19 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.exit = new System.Windows.Forms.Button();
			this.mainMess_btn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panelSideMenu.SuspendLayout();
			this.panelAccountSubMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSideMenu
			// 
			this.panelSideMenu.AutoScroll = true;
			this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(230)))), ((int)(((byte)(246)))));
			this.panelSideMenu.Controls.Add(this.button2);
			this.panelSideMenu.Controls.Add(this.button1);
			this.panelSideMenu.Controls.Add(this.customerSup_btn);
			this.panelSideMenu.Controls.Add(this.message_btn);
			this.panelSideMenu.Controls.Add(this.panelAccountSubMenu);
			this.panelSideMenu.Controls.Add(this.account_btn);
			this.panelSideMenu.Controls.Add(this.home_btn);
			this.panelSideMenu.Controls.Add(this.panelLogo);
			this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
			this.panelSideMenu.Name = "panelSideMenu";
			this.panelSideMenu.Size = new System.Drawing.Size(200, 777);
			this.panelSideMenu.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(0, 660);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 49);
			this.button1.TabIndex = 10;
			this.button1.Text = "Log out";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// customerSup_btn
			// 
			this.customerSup_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this.customerSup_btn.FlatAppearance.BorderSize = 0;
			this.customerSup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customerSup_btn.Location = new System.Drawing.Point(0, 326);
			this.customerSup_btn.Name = "customerSup_btn";
			this.customerSup_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.customerSup_btn.Size = new System.Drawing.Size(200, 54);
			this.customerSup_btn.TabIndex = 9;
			this.customerSup_btn.Text = "Customer Support";
			this.customerSup_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.customerSup_btn.UseVisualStyleBackColor = true;
			this.customerSup_btn.Click += new System.EventHandler(this.customerSup_btn_Click);
			// 
			// message_btn
			// 
			this.message_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this.message_btn.FlatAppearance.BorderSize = 0;
			this.message_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.message_btn.Location = new System.Drawing.Point(0, 272);
			this.message_btn.Name = "message_btn";
			this.message_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.message_btn.Size = new System.Drawing.Size(200, 54);
			this.message_btn.TabIndex = 5;
			this.message_btn.Text = "Message";
			this.message_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.message_btn.UseVisualStyleBackColor = true;
			this.message_btn.Click += new System.EventHandler(this.message_btn_Click);
			// 
			// panelAccountSubMenu
			// 
			this.panelAccountSubMenu.BackColor = System.Drawing.Color.Azure;
			this.panelAccountSubMenu.Controls.Add(this.profile_btn);
			this.panelAccountSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelAccountSubMenu.Location = new System.Drawing.Point(0, 208);
			this.panelAccountSubMenu.Name = "panelAccountSubMenu";
			this.panelAccountSubMenu.Size = new System.Drawing.Size(200, 64);
			this.panelAccountSubMenu.TabIndex = 4;
			// 
			// profile_btn
			// 
			this.profile_btn.BackColor = System.Drawing.Color.Azure;
			this.profile_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this.profile_btn.FlatAppearance.BorderSize = 0;
			this.profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.profile_btn.Location = new System.Drawing.Point(0, 0);
			this.profile_btn.Name = "profile_btn";
			this.profile_btn.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
			this.profile_btn.Size = new System.Drawing.Size(200, 49);
			this.profile_btn.TabIndex = 0;
			this.profile_btn.Text = "Profile";
			this.profile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.profile_btn.UseVisualStyleBackColor = false;
			this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
			// 
			// account_btn
			// 
			this.account_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this.account_btn.FlatAppearance.BorderSize = 0;
			this.account_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.account_btn.Location = new System.Drawing.Point(0, 154);
			this.account_btn.Name = "account_btn";
			this.account_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.account_btn.Size = new System.Drawing.Size(200, 54);
			this.account_btn.TabIndex = 3;
			this.account_btn.Text = "Account";
			this.account_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.account_btn.UseVisualStyleBackColor = true;
			this.account_btn.Click += new System.EventHandler(this.account_btn_Click);
			// 
			// home_btn
			// 
			this.home_btn.AutoSize = true;
			this.home_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this.home_btn.FlatAppearance.BorderSize = 0;
			this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.home_btn.Location = new System.Drawing.Point(0, 100);
			this.home_btn.Name = "home_btn";
			this.home_btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.home_btn.Size = new System.Drawing.Size(200, 54);
			this.home_btn.TabIndex = 1;
			this.home_btn.Text = "Home";
			this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.home_btn.UseVisualStyleBackColor = true;
			this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
			this.panelLogo.Controls.Add(this.panel19);
			this.panelLogo.Controls.Add(this.panel1);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(200, 100);
			this.panelLogo.TabIndex = 0;
			// 
			// panel19
			// 
			this.panel19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel19.BackgroundImage")));
			this.panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel19.Location = new System.Drawing.Point(6, -4);
			this.panel19.Name = "panel19";
			this.panel19.Size = new System.Drawing.Size(86, 100);
			this.panel19.TabIndex = 28;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Location = new System.Drawing.Point(72, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(117, 91);
			this.panel1.TabIndex = 29;
			// 
			// panelChildForm
			// 
			this.panelChildForm.AutoSize = true;
			this.panelChildForm.BackColor = System.Drawing.Color.White;
			this.panelChildForm.Location = new System.Drawing.Point(200, 56);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(778, 682);
			this.panelChildForm.TabIndex = 1;
			this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
			// 
			// exit
			// 
			this.exit.BackColor = System.Drawing.Color.Transparent;
			this.exit.FlatAppearance.BorderSize = 0;
			this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.exit.Location = new System.Drawing.Point(939, 8);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(26, 22);
			this.exit.TabIndex = 8;
			this.exit.Text = "X";
			this.exit.UseVisualStyleBackColor = false;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// mainMess_btn
			// 
			this.mainMess_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainMess_btn.BackgroundImage")));
			this.mainMess_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.mainMess_btn.FlatAppearance.BorderSize = 0;
			this.mainMess_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mainMess_btn.ForeColor = System.Drawing.Color.Transparent;
			this.mainMess_btn.Location = new System.Drawing.Point(839, 35);
			this.mainMess_btn.Name = "mainMess_btn";
			this.mainMess_btn.Size = new System.Drawing.Size(38, 30);
			this.mainMess_btn.TabIndex = 9;
			this.mainMess_btn.UseVisualStyleBackColor = true;
			this.mainMess_btn.Click += new System.EventHandler(this.mainMess_btn_Click);
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(0, 380);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.button2.Size = new System.Drawing.Size(200, 54);
			this.button2.TabIndex = 11;
			this.button2.Text = "About Us";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(977, 737);
			this.Controls.Add(this.mainMess_btn);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.panelSideMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.panelSideMenu.ResumeLayout(false);
			this.panelSideMenu.PerformLayout();
			this.panelAccountSubMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelSideMenu;
		private System.Windows.Forms.Button home_btn;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Button message_btn;
		private System.Windows.Forms.Panel panelAccountSubMenu;
		private System.Windows.Forms.Button profile_btn;
		private System.Windows.Forms.Button account_btn;
		private System.Windows.Forms.Button customerSup_btn;
		private System.Windows.Forms.Panel panelChildForm;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button mainMess_btn;
		private System.Windows.Forms.Panel panel19;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
	}
}
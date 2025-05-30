﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMilkyWay
{
    public partial class About: Form
    {
        public About()
        {
            InitializeComponent();
        }

		private void login1_Click(object sender, EventArgs e)
		{
			Log_In loginForm = new Log_In();
			loginForm.Show();

			this.Hide();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Form1 displayPage = new Form1();
			displayPage.Show();

			this.Hide();
		}

		private void signup_Click(object sender, EventArgs e)
		{
			SignUp signup = new SignUp();
			signup.Show();

			this.Hide();
		}

		private void exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

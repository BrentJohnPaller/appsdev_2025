using System;
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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void exit_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}

		private void login1_Click(object sender, EventArgs e)
		{
			Log_In loginForm = new Log_In();
			loginForm.Show();

			this.Hide();
		}

		private void about_Click(object sender, EventArgs e)
		{
			About aboutForm = new About();
			aboutForm.Show();

			this.Hide();
		}

		private void signup_Click(object sender, EventArgs e)
		{
			SignUp signup = new SignUp();
			signup.Show();

			this.Hide();
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppMilkyWay
{
	public partial class Log_In: Form
    {
		SqlConnection
		connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aljhon\OneDrive\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public Log_In()
        {
            InitializeComponent();
        }

		private void exit_Click(object sender, EventArgs e)
		{
			Form1 displayPage = new Form1();
			displayPage.Show();

			this.Hide();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Forget_Pass forgetpass = new Forget_Pass();
			forgetpass.Show();

			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			SignUp signup = new SignUp();
			signup.Show();

			this.Hide();
		}

		private void login_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			login_password.PasswordChar = login_checkBox.Checked ? '\0' : '*';
		}

		public bool checkConnection()
		{
			try
			{

				if (connect.State == ConnectionState.Closed)
				{
					connect.Open();
					connect.Close();
					return true;
				}
				else if (connect.State == ConnectionState.Open)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return false;
		}

		private void Login_toDash_Click(object sender, EventArgs e)
		{
			if (login_usernamee.Text == "" || login_password.Text == "")
			{
				MessageBox.Show("Username and password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!checkConnection())
			{
				MessageBox.Show("Database connection failed. Please check your connection string.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{

				connect.Open();

				string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

				using (SqlCommand cmd = new SqlCommand(selectData, connect))
				{
					cmd.Parameters.AddWithValue("@usern", login_usernamee.Text.Trim());
					cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable table = new DataTable();
					adapter.Fill(table);

					if (table.Rows.Count > 0)
					{
						MainForm mform = new MainForm();
						mform.Show();

						this.Hide();
					}
					else
					{
						MessageBox.Show("Incorrect username/password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (connect.State == ConnectionState.Open)
				{
					connect.Close();
				}
			}
		}


	}
}

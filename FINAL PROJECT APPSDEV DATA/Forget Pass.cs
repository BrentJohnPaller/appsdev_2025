using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMilkyWay
{
	public partial class Forget_Pass : Form
	{
		private readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aljhon\OneDrive\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public Forget_Pass()
		{
			InitializeComponent();
		}

		private void exit_Click(object sender, EventArgs e)
		{
			Log_In loginBck = new Log_In();
			loginBck.Show();

			this.Hide();
		}

		private void Confirm_Click(object sender, EventArgs e)
		{
			{

				if (usrname_F.Text == "" || pass_F.Text == "" || newPass_F.Text == "")
				{
					MessageBox.Show("Please fill all blank field.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (pass_F.Text.Trim() != newPass_F.Text.Trim())
				{
					MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				try
				{
					if (connect.State == ConnectionState.Closed)
						connect.Open();

					string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
					using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
					{
						checkCmd.Parameters.AddWithValue("@username", usrname_F.Text.Trim());

						int matchCount = (int)checkCmd.ExecuteScalar();

						if (matchCount == 0)
						{
							MessageBox.Show("User not found", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}
					string updateQuery = "UPDATE users SET password = @password WHERE username = @username";
					using (SqlCommand updateCmd = new SqlCommand(updateQuery, connect))
					{
						updateCmd.Parameters.AddWithValue("@password", pass_F.Text.Trim());
						updateCmd.Parameters.AddWithValue("@username", usrname_F.Text.Trim());

						int rowsAffected = updateCmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Password successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

							Log_In loginBck = new Log_In();
							loginBck.Show();
							this.Close();
						}
						else
						{
							MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					if (connect.State == ConnectionState.Open)
						connect.Close();
				}
			}
		}
	}
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppMilkyWay
{
	public partial class SignUp : Form
	{
		SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aljhon\OneDrive\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
		public SignUp()
		{
			InitializeComponent();
		}

		private void middlename_TextChanged(object sender, EventArgs e)
		{

		}

		private void exit_Click(object sender, EventArgs e)
		{
			Form1 loginBck = new Form1();
			loginBck.Show();

			this.Hide();
		}

		private void creatAcc_Click(object sender, EventArgs e)
		{
			if (register_usernamee.Text == "" || register_password.Text == "" || register_Cpassword.Text == "")
			{
				MessageBox.Show("Please fill all blank field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (checkConnection())
				{
					try
					{
						connect.Open();

						string checkUsername = "SELECT * FROM users WHERE username = @usern";

						using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
						{
							cmd.Parameters.AddWithValue("@usern", register_usernamee.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
							DataTable table = new DataTable();
							adapter.Fill(table);

							if (table.Rows.Count > 0)
							{
								MessageBox.Show(register_usernamee.Text.Trim()
									+ "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else if (register_password.Text.Length < 8)
							{
								MessageBox.Show("Invalid Password. at least 8 characters are needed"
									, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else if (register_password.Text.Trim() != register_Cpassword.Text.Trim())
							{
								MessageBox.Show("Password not match."
									, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								string insertData = "INSERT INTO users (username, password, status, date) VALUES (@usern, @pass, @status, @date)";

								using (SqlCommand insertD = new SqlCommand(insertData, connect))
								{
									insertD.Parameters.AddWithValue("@usern", register_usernamee.Text.Trim());
									insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim());
									insertD.Parameters.AddWithValue("@status", "Approval");

									DateTime today = DateTime.Today;
									insertD.Parameters.AddWithValue("@date", today);

									insertD.ExecuteNonQuery();

									MessageBox.Show("Registered successfully!"
									, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

									Form1 loginBck = new Form1();
									loginBck.Show();

									this.Hide();
								}
							}
						}

					}
					catch (Exception ex)
					{
						MessageBox.Show("Connection failed: " + ex
									, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						connect.Close();
					}
				}
			}
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



		private void signup_checkedBox_CheckedChanged(object sender, EventArgs e)
		{
			register_password.PasswordChar = signup_checkedBox.Checked ? '\0' : '*';
			register_Cpassword.PasswordChar = signup_checkedBox.Checked ? '\0' : '*';
		}
	}
}

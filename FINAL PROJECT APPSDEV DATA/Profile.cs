using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppMilkyWay
{
    public partial class Profile: Form
    {
        public Profile()
        {
            InitializeComponent();
        }

		private void upload_Click(object sender, EventArgs e)
		{
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    profilePic.ImageLocation = imageLocation;

                }

            }
            catch (Exception) {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

		private void editName_Click(object sender, EventArgs e)
		{
				txtName.ReadOnly = false;
				txtName2.ReadOnly = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			    txtName.ReadOnly = true;
			    txtName2.ReadOnly = true;
				txtEmail.ReadOnly = true;
				txtEmail2.ReadOnly = true;
				txtNumber.ReadOnly = true;
				txtAddress.ReadOnly = true;

			txtName2.Text = txtName.Text;
			txtEmail2.Text = txtEmail.Text;

			MessageBox.Show("Changes saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void EmailBtn_Click(object sender, EventArgs e)
		{
			txtEmail.ReadOnly = false;
			txtEmail2.ReadOnly = false;
		}

		private void NumberBtn_Click(object sender, EventArgs e)
		{
			txtNumber.ReadOnly = false;
		}

		private void AddressBtn_Click(object sender, EventArgs e)
		{
			txtAddress.ReadOnly = false;
		}
	}
}

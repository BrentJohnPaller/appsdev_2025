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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();

		}

        private void customizeDesign()
        {
            panelAccountSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelAccountSubMenu.Visible == true)
                panelAccountSubMenu.Visible = false;
           
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else 
            {
                subMenu.Visible = false;
            }
        }

		private void home_btn_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			LoadFormInPanel(home);
		}

		private void account_btn_Click(object sender, EventArgs e)
		{
            showSubMenu(panelAccountSubMenu);
		}

		private void profile_btn_Click(object sender, EventArgs e)
		{
			Profile profile = new Profile();
			LoadFormInPanel(profile);

			hideSubMenu();
		}

		private void message_btn_Click(object sender, EventArgs e)
		{
			Message message = new Message();
			LoadFormInPanel(message);

		}   

		private void customerSup_btn_Click(object sender, EventArgs e)
		{
			CustomerSupport customer = new CustomerSupport();
			LoadFormInPanel(customer);
		}

		private void LoadFormInPanel(Form childForm)
		{
			panelChildForm.Controls.Clear();

			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;

			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;

			childForm.Show();
		}

		private void exit_Click(object sender, EventArgs e)
		{
		    	Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{

            DialogResult result = MessageBox.Show("Do you wish to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Form1 displayPage = new Form1();
                displayPage.Show();

                this.Hide();
            }
		}


		private void mainMess_btn_Click(object sender, EventArgs e)
		{
			Message message = new Message();
			LoadFormInPanel(message);
		}

		private void panelChildForm_Paint(object sender, PaintEventArgs e)
		{
			Home h = new Home();
			h.TopLevel = false;
			panelChildForm.Controls.Add(h);
			h.Show();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			About_Us2 message2 = new About_Us2();
			LoadFormInPanel(message2);
		}
	}
}

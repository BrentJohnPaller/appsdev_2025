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
    public partial class Product14: Form
    {
        public Product14()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct14 m14 = new MessProduct14();
			m14.TopLevel = false;
			Product14panel.Controls.Add(m14);
			m14.BringToFront();
			m14.Show();
		}
	}
}

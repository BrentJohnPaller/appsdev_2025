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
    public partial class Product27: Form
    {
        public Product27()
        {
            InitializeComponent();
        }

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct27 m27 = new MessProduct27();
			m27.TopLevel = false;
			Product27panel.Controls.Add(m27);
			m27.BringToFront();
			m27.Show();
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

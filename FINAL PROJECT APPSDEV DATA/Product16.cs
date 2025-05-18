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
    public partial class Product16: Form
    {
        public Product16()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct16 m16 = new MessProduct16();
			m16.TopLevel = false;
			Product16panel.Controls.Add(m16);
			m16.BringToFront();
			m16.Show();
		}
	}
}

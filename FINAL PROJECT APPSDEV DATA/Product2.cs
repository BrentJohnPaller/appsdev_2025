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
    public partial class Product2: Form
    {
        public Product2()
        {
            InitializeComponent();
        }

		private void contact_seller2_Click(object sender, EventArgs e)
		{
			MessProduct2 m2 = new MessProduct2();
			m2.TopLevel = false;
			Product2panel.Controls.Add(m2);
			m2.BringToFront();
			m2.Show();
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

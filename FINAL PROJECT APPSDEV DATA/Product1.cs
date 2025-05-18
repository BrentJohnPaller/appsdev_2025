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
    public partial class Product1: Form
    {
        public Product1()
        {
            InitializeComponent();
        }

		private void contact_seller1_Click_1(object sender, EventArgs e)
		{
			MessProduct1 m1 = new MessProduct1();
			m1.TopLevel = false;
			Product1panel.Controls.Add(m1);
			m1.BringToFront();
			m1.Show();

		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}


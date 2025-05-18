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
    public partial class Product22: Form
    {
        public Product22()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct22 m22 = new MessProduct22();
			m22.TopLevel = false;
			Product22panel.Controls.Add(m22);
			m22.BringToFront();
			m22.Show();
		}
	}
}

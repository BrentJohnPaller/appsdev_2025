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
    public partial class Product10: Form
    {
        public Product10()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct10 m10 = new MessProduct10();
			m10.TopLevel = false;
			Product10panel.Controls.Add(m10);
			m10.BringToFront();
			m10.Show();
		}
	}
}

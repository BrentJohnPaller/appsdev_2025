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
    public partial class Product21: Form
    {
        public Product21()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct21 m21 = new MessProduct21();
			m21.TopLevel = false;
			Product21panel.Controls.Add(m21);
			m21.BringToFront();
			m21.Show();
		}
	}
}

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
    public partial class Product23: Form
    {
        public Product23()
        {
            InitializeComponent();
        }

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct23 m23 = new MessProduct23();
			m23.TopLevel = false;
			Product23panel.Controls.Add(m23);
			m23.BringToFront();
			m23.Show();
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

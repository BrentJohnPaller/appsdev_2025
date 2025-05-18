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
    public partial class Product8: Form
    {
        public Product8()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct8 m8 = new MessProduct8();
			m8.TopLevel = false;
			Product8panel.Controls.Add(m8);
			m8.BringToFront();
			m8.Show();
		}
	}
}

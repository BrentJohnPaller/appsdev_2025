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
    public partial class Product6: Form
    {
        public Product6()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct6 m6 = new MessProduct6();
			m6.TopLevel = false;
			Product6panel.Controls.Add(m6);
			m6.BringToFront();
			m6.Show();
		}
	}
}

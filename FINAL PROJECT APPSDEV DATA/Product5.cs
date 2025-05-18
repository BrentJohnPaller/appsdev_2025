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
    public partial class Product5: Form
    {
        public Product5()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct5 m5 = new MessProduct5();
			m5.TopLevel = false;
			Product5panel.Controls.Add(m5);
			m5.BringToFront();
			m5.Show();
		}
	}
}

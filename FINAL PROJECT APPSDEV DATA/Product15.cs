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
    public partial class Product15: Form
    {
        public Product15()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct15 m15 = new MessProduct15();
			m15.TopLevel = false;
			Product15panel.Controls.Add(m15);
			m15.BringToFront();
			m15.Show();
		}
	}
}

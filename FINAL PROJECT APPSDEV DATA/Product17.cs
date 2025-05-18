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
    public partial class Product17: Form
    {
        public Product17()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct17 m17 = new MessProduct17();
			m17.TopLevel = false;
			Product17panel.Controls.Add(m17);
			m17.BringToFront();
			m17.Show();
		}
	}
}

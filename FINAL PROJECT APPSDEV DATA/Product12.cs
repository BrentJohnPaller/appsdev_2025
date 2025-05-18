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
    public partial class Product12: Form
    {
        public Product12()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct12 m12 = new MessProduct12();
			m12.TopLevel = false;
			Product12panel.Controls.Add(m12);
			m12.BringToFront();
			m12.Show();
		}
	}
}

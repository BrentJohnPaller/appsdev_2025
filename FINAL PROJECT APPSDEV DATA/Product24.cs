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
    public partial class Product24: Form
    {
        public Product24()
        {
            InitializeComponent();
        }

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct24 m24 = new MessProduct24();
			m24.TopLevel = false;
			Product22panel.Controls.Add(m24);
			m24.BringToFront();
			m24.Show();
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

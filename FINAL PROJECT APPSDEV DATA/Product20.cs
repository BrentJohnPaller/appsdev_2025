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
    public partial class Product20: Form
    {
        public Product20()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct20 m20 = new MessProduct20();
			m20.TopLevel = false;
			Product20panel.Controls.Add(m20);
			m20.BringToFront();
			m20.Show();
		}
	}
}

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
    public partial class Product26: Form
    {
        public Product26()
        {
            InitializeComponent();
        }

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct26 m26 = new MessProduct26();
			m26.TopLevel = false;
			Product26panel.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

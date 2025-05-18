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
    public partial class Product11: Form
    {
        public Product11()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct11 m11 = new MessProduct11();
			m11.TopLevel = false;
			Product11panel.Controls.Add(m11);
			m11.BringToFront();
			m11.Show();
		}
	}
}

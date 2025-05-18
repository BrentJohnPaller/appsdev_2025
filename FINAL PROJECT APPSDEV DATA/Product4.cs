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
    public partial class Product4: Form
    {
        public Product4()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct4 m4 = new MessProduct4();
			m4.TopLevel = false;
			Product4panel.Controls.Add(m4);
			m4.BringToFront();
			m4.Show();
		}
	}
}

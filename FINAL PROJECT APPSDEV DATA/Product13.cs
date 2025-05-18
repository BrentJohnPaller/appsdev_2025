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
    public partial class Product13: Form
    {
        public Product13()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct13 m13 = new MessProduct13();
			m13.TopLevel = false;
			Product13panel.Controls.Add(m13);
			m13.BringToFront();
			m13.Show();
		}
	}
}

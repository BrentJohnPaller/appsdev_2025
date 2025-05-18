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
    public partial class Product25: Form
    {
        public Product25()
        {
            InitializeComponent();
        }

		private void contact_seller1_Click(object sender, EventArgs e)
		{
			MessProduct25 m25 = new MessProduct25();
			m25.TopLevel = false;
			Product25panel.Controls.Add(m25);
			m25.BringToFront();
			m25.Show();
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

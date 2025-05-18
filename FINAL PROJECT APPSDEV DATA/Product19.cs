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
    public partial class Product19: Form
    {
        public Product19()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct19 m19 = new MessProduct19();
			m19.TopLevel = false;
			Product19panel.Controls.Add(m19);
			m19.BringToFront();
			m19.Show();
		}
	}
}

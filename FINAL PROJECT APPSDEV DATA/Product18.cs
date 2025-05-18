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
    public partial class Product18: Form
    {
        public Product18()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct18 m18 = new MessProduct18();
			m18.TopLevel = false;
			Product18panel.Controls.Add(m18);
			m18.BringToFront();
			m18.Show();
		}
	}
}

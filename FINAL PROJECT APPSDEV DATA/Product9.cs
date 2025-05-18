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
    public partial class Product9: Form
    {
        public Product9()
        {
            InitializeComponent();
        }

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct9 m9 = new MessProduct9();
			m9.TopLevel = false;
			Product9panel.Controls.Add(m9);
			m9.BringToFront();
			m9.Show();
		}
	}
}

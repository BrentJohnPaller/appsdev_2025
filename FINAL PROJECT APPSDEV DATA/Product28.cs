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
    public partial class Product28: Form
    {
        public Product28()
        {
            InitializeComponent();
        }

		private void contact_seller3_Click(object sender, EventArgs e)
		{
			MessProduct28 m28 = new MessProduct28();
			m28.TopLevel = false;
			Product28panel.Controls.Add(m28);
			m28.BringToFront();
			m28.Show();
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

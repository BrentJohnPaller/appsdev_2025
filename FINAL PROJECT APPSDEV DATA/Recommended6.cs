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
    public partial class Recommended6: Form
    {
        public Recommended6()
        {
            InitializeComponent();
        }

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product9 p9 = new Product9();
			p9.TopLevel = false;
			panelRec6.Controls.Add(p9);
			p9.BringToFront();
			p9.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product12 p12 = new Product12();
			p12.TopLevel = false;
			panelRec6.Controls.Add(p12);
			p12.BringToFront();
			p12.Show();
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			Product11 p11 = new Product11();
			p11.TopLevel = false;
			panelRec6.Controls.Add(p11);
			p11.BringToFront();
			p11.Show();
		}
	}
}

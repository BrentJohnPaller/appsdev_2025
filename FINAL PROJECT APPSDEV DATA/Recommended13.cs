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
    public partial class Recommended13: Form
    {
        public Recommended13()
        {
            InitializeComponent();
        }

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void qouestionMark2_Click(object sender, EventArgs e)
		{
			Product2 p2 = new Product2();
			p2.TopLevel = false;
			panelRec13.Controls.Add(p2);
			p2.BringToFront();
			p2.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product25 m25 = new Product25();
			m25.TopLevel = false;
			panelRec13.Controls.Add(m25);
			m25.BringToFront();
			m25.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product22 m22 = new Product22();
			m22.TopLevel = false;
			panelRec13.Controls.Add(m22);
			m22.BringToFront();
			m22.Show();
		}
	}
}

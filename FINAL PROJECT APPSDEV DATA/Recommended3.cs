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
    public partial class Recommended3: Form
    {
        public Recommended3()
        {
            InitializeComponent();
        }

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product26 m26 = new Product26();
			m26.TopLevel = false;
			panelRec3.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}

		private void qouestionMark2_Click(object sender, EventArgs e)
		{
			Product2 p2 = new Product2();
			p2.TopLevel = false;
			panelRec3.Controls.Add(p2);
			p2.BringToFront();
			p2.Show();
		}

		private void questionMark4_Click(object sender, EventArgs e)
		{
			Product4 p4 = new Product4();
			p4.TopLevel = false;
			panelRec3.Controls.Add(p4);
			p4.BringToFront();
			p4.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}

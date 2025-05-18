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
    public partial class Recommended10: Form
    {
        public Recommended10()
        {
            InitializeComponent();
        }

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void qouestionMark1_Click(object sender, EventArgs e)
		{
			Product1 p1 = new Product1();
			p1.TopLevel = false;
			panelRec10.Controls.Add(p1);
			p1.BringToFront();
			p1.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product20 p20 = new Product20();
			p20.TopLevel = false;
			panelRec10.Controls.Add(p20);
			p20.BringToFront();
			p20.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product21 p21 = new Product21();
			p21.TopLevel = false;
			panelRec10.Controls.Add(p21);
			p21.BringToFront();
			p21.Show();
		}
	}
}

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
    public partial class Recommended7: Form
    {
        public Recommended7()
        {
            InitializeComponent();
        }

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product13 p13 = new Product13();
			p13.TopLevel = false;
			panelRec7.Controls.Add(p13);
			p13.BringToFront();
			p13.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product14 p14 = new Product14();
			p14.TopLevel = false;
			panelRec7.Controls.Add(p14);
			p14.BringToFront();
			p14.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product15 p15 = new Product15();
			p15.TopLevel = false;
			panelRec7.Controls.Add(p15);
			p15.BringToFront();
			p15.Show();
		}
	}
}

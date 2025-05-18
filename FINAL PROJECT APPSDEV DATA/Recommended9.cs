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
    public partial class Recommended9: Form
    {
        public Recommended9()
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
			panelRec9.Controls.Add(p13);
			p13.BringToFront();
			p13.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product14 p14 = new Product14();
			p14.TopLevel = false;
			panelRec9.Controls.Add(p14);
			p14.BringToFront();
			p14.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product15 p15 = new Product15();
			p15.TopLevel = false;
			panelRec9.Controls.Add(p15);
			p15.BringToFront();
			p15.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Product16 p16 = new Product16();
			p16.TopLevel = false;
			panelRec9.Controls.Add(p16);
			p16.BringToFront();
			p16.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Product17 p17 = new Product17();
			p17.TopLevel = false;
			panelRec9.Controls.Add(p17);
			p17.BringToFront();
			p17.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Product18 p18 = new Product18();
			p18.TopLevel = false;
			panelRec9.Controls.Add(p18);
			p18.BringToFront();
			p18.Show();
		}
	}
}

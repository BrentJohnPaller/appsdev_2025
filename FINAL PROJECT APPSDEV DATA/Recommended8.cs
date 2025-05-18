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
    public partial class Recommended8: Form
    {
        public Recommended8()
        {
            InitializeComponent();
        }

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product16 p16 = new Product16();
			p16.TopLevel = false;
			panelRec8.Controls.Add(p16);
			p16.BringToFront();
			p16.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product17 p17 = new Product17();
			p17.TopLevel = false;
			panelRec8.Controls.Add(p17);
			p17.BringToFront();
			p17.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product18 p18 = new Product18();
			p18.TopLevel = false;
			panelRec8.Controls.Add(p18);
			p18.BringToFront();
			p18.Show();
		}
	}
}

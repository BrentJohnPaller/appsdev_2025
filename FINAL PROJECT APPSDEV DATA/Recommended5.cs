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
    public partial class Recommended5: Form
    {
        public Recommended5()
        {
            InitializeComponent();
        }

		private void button2_Click(object sender, EventArgs e)
		{
            this.Hide();
		}


		private void button3_Click(object sender, EventArgs e)
		{

			Product12 p12 = new Product12();
			p12.TopLevel = false;
			panelRec5.Controls.Add(p12);
			p12.BringToFront();
			p12.Show();
		}

		private void questionMark4_Click(object sender, EventArgs e)
		{
			Product4 p4 = new Product4();
			p4.TopLevel = false;
			panelRec5.Controls.Add(p4);
			p4.BringToFront();
			p4.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Product27 m27 = new Product27();
			m27.TopLevel = false;
			panelRec5.Controls.Add(m27);
			m27.BringToFront();
			m27.Show();
		}
	}
}

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
    public partial class Recommended12: Form
    {
        public Recommended12()
        {
            InitializeComponent();
        }


		private void button4_Click_1(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product26 m26 = new Product26();
			m26.TopLevel = false;
			panelRec12.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product11 p11 = new Product11();
			p11.TopLevel = false;
			panelRec12.Controls.Add(p11);
			p11.BringToFront();
			p11.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product27 m27 = new Product27();
			m27.TopLevel = false;
			panelRec12.Controls.Add(m27);
			m27.BringToFront();
			m27.Show();
		}

		private void qouestionMark1_Click(object sender, EventArgs e)
		{
			Product1 p1 = new Product1();
			p1.TopLevel = false;
			panelRec12.Controls.Add(p1);
			p1.BringToFront();
			p1.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Product20 p20 = new Product20();
			p20.TopLevel = false;
			panelRec12.Controls.Add(p20);
			p20.BringToFront();
			p20.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Product21 p21 = new Product21();
			p21.TopLevel = false;
			panelRec12.Controls.Add(p21);
			p21.BringToFront();
			p21.Show();
		}
	}
}

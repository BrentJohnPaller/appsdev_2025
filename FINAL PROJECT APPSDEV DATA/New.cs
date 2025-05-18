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
    public partial class panelnewsee: Form
    {
        public panelnewsee()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product7 p7 = new Product7();
			p7.TopLevel = false;
			panelseeall.Controls.Add(p7);
			p7.BringToFront();
			p7.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product8 p8 = new Product8();
			p8.TopLevel = false;
			panelseeall.Controls.Add(p8);
			p8.BringToFront();
			p8.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Product9 p9 = new Product9();
			p9.TopLevel = false;
			panelseeall.Controls.Add(p9);
			p9.BringToFront();
			p9.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Product10 p10 = new Product10();
			p10.TopLevel = false;
			panelseeall.Controls.Add(p10);
			p10.BringToFront();
			p10.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Product11 p11 = new Product11();
			p11.TopLevel = false;
			panelseeall.Controls.Add(p11);
			p11.BringToFront();
			p11.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Product12 p12 = new Product12();
			p12.TopLevel = false;
			panelseeall.Controls.Add(p12);
			p12.BringToFront();
			p12.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Product13 p13 = new Product13();
			p13.TopLevel = false;
			panelseeall.Controls.Add(p13);
			p13.BringToFront();
			p13.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Product14 p14 = new Product14();
			p14.TopLevel = false;
			panelseeall.Controls.Add(p14);
			p14.BringToFront();
			p14.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Product15 p15 = new Product15();
			p15.TopLevel = false;
			panelseeall.Controls.Add(p15);
			p15.BringToFront();
			p15.Show();
		}

		private void qouestionMark1_Click(object sender, EventArgs e)
		{
			Product26 m26 = new Product26();
			m26.TopLevel = false;
			panelseeall.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}

		private void qouestionMark2_Click(object sender, EventArgs e)
		{
			Product2 p2 = new Product2();
			p2.TopLevel = false;
			panelseeall.Controls.Add(p2);
			p2.BringToFront();
			p2.Show();
		}

		private void product3_Button_Click(object sender, EventArgs e)
		{
			Product3 p3 = new Product3();
			p3.TopLevel = false;
			panelseeall.Controls.Add(p3);
			p3.BringToFront();
			p3.Show();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Product25 m25 = new Product25();
			m25.TopLevel = false;
			panelseeall.Controls.Add(m25);
			m25.BringToFront();
			m25.Show();
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			Product27 m27 = new Product27();
			m27.TopLevel = false;
			panelseeall.Controls.Add(m27);
			m27.BringToFront();
			m27.Show();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			Product26 m26 = new Product26();
			m26.TopLevel = false;
			panelseeall.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}

		private void questionMark4_Click(object sender, EventArgs e)
		{
			Product4 p4 = new Product4();
			p4.TopLevel = false;
			panelseeall.Controls.Add(p4);
			p4.BringToFront();
			p4.Show();
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			Product22 m22 = new Product22();
			m22.TopLevel = false;
			panelseeall.Controls.Add(m22);
			m22.BringToFront();
			m22.Show();
		}
	}
}

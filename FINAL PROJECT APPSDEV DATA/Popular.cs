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
    public partial class Popular: Form
    {
        public Popular()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product16 p16 = new Product16();
			p16.TopLevel = false;
			panelpopularr.Controls.Add(p16);
			p16.BringToFront();
			p16.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product17 p17 = new Product17();
			p17.TopLevel = false;
			panelpopularr.Controls.Add(p17);
			p17.BringToFront();
			p17.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Product18 p18 = new Product18();
			p18.TopLevel = false;
			panelpopularr.Controls.Add(p18);
			p18.BringToFront();
			p18.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Product19 p19 = new Product19();
			p19.TopLevel = false;
			panelpopularr.Controls.Add(p19);
			p19.BringToFront();
			p19.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Product20 p20 = new Product20();
			p20.TopLevel = false;
			panelpopularr.Controls.Add(p20);
			p20.BringToFront();
			p20.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Product21 p21 = new Product21();
			p21.TopLevel = false;
			panelpopularr.Controls.Add(p21);
			p21.BringToFront();
			p21.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Product22 p22 = new Product22();
			p22.TopLevel = false;
			panelpopularr.Controls.Add(p22);
			p22.BringToFront();
			p22.Show();
		}
		private void questionMark4_Click(object sender, EventArgs e)
		{
			Product4 p4 = new Product4();
			p4.TopLevel = false;
			panelpopularr.Controls.Add(p4);
			p4.BringToFront();
			p4.Show();
		}

		private void questionMark5_Click(object sender, EventArgs e)
		{
			Product5 p5 = new Product5();
			p5.TopLevel = false;
			panelpopularr.Controls.Add(p5);
			p5.BringToFront();
			p5.Show();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			Product26 m26 = new Product26();
			m26.TopLevel = false;
			panelpopularr.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Product9 p9 = new Product9();
			p9.TopLevel = false;
			panelpopularr.Controls.Add(p9);
			p9.BringToFront();
			p9.Show();
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			Product11 p11 = new Product11();
			p11.TopLevel = false;
			panelpopularr.Controls.Add(p11);
			p11.BringToFront();
			p11.Show();
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			Product12 p12 = new Product12();
			p12.TopLevel = false;
			panelpopularr.Controls.Add(p12);
			p12.BringToFront();
			p12.Show();
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			Product20 p20 = new Product20();
			p20.TopLevel = false;
			panelpopularr.Controls.Add(p20);
			p20.BringToFront();
			p20.Show();
		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			Product21 p21 = new Product21();
			p21.TopLevel = false;
			panelpopularr.Controls.Add(p21);
			p21.BringToFront();
			p21.Show();
		}
	}
}

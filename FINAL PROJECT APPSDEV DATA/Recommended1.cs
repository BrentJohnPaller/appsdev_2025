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
    public partial class Recommended1: Form
    {
        public Recommended1()
        {
            InitializeComponent();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product25 m25 = new Product25();
			m25.TopLevel = false;
			panelRec1.Controls.Add(m25);
			m25.BringToFront();
			m25.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product26 m26 = new Product26();
			m26.TopLevel = false;
			panelRec1.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Product27 m27 = new Product27();
			m27.TopLevel = false;
			panelRec1.Controls.Add(m27);
			m27.BringToFront();
			m27.Show();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}

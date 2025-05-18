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
    public partial class Recommended11: Form
    {
        public Recommended11()
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
			panelRec11.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product11 p11 = new Product11();
			p11.TopLevel = false;
			panelRec11.Controls.Add(p11);
			p11.BringToFront();
			p11.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product27 m27 = new Product27();
			m27.TopLevel = false;
			panelRec11.Controls.Add(m27);
			m27.BringToFront();
			m27.Show();
		}
	}
}

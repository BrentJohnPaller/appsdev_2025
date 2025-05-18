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
    public partial class Recommended2: Form
    {
        public Recommended2()
        {
            InitializeComponent();
        }

		private void Recommended2_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			Product26 m26 = new Product26();
			m26.TopLevel = false;
			panelRec2.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void qouestionMark1_Click(object sender, EventArgs e)
		{
			Product1 p1 = new Product1();
			p1.TopLevel = false;
			panelRec2.Controls.Add(p1);
			p1.BringToFront();
			p1.Show();

		}
	}
}

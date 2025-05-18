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
    public partial class Recommended14: Form
    {
        public Recommended14()
        {
            InitializeComponent();
        }

		private void qouestionMark2_Click(object sender, EventArgs e)
		{
			Product23 m23 = new Product23();
			m23.TopLevel = false;
			panelRec14.Controls.Add(m23);
			m23.BringToFront();
			m23.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Product25 m25 = new Product25();
			m25.TopLevel = false;
			panelRec14.Controls.Add(m25);
			m25.BringToFront();
			m25.Show();
		}
	}
}

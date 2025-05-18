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

	public partial class Message: Form
    {
		public Message()
        {
            InitializeComponent();
        }


		private void button1_Click(object sender, EventArgs e)
		{
			MessProduct1 m1 = new MessProduct1();
			m1.TopLevel = false;
			Messagepanel.Controls.Add(m1);
			m1.BringToFront();
			m1.Show();


		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessProduct2 m2 = new MessProduct2();
			m2.TopLevel = false;
			Messagepanel.Controls.Add(m2);
			m2.BringToFront();
			m2.Show();


		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessProduct3 m3 = new MessProduct3();
			m3.TopLevel = false;
			Messagepanel.Controls.Add(m3);
			m3.BringToFront();
			m3.Show();


		}

		private void button4_Click(object sender, EventArgs e)
		{
			MessProduct4 m4 = new MessProduct4();
			m4.TopLevel = false;
			Messagepanel.Controls.Add(m4);
			m4.BringToFront();
			m4.Show();


		}

		private void button5_Click(object sender, EventArgs e)
		{
			MessProduct5 m5 = new MessProduct5();
			m5.TopLevel = false;
			Messagepanel.Controls.Add(m5);
			m5.BringToFront();
			m5.Show();

		}

		private void button6_Click(object sender, EventArgs e)
		{
			MessProduct6 m6 = new MessProduct6();
			m6.TopLevel = false;
			Messagepanel.Controls.Add(m6);
			m6.BringToFront();
			m6.Show();

		}
		private void Messagepanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel7_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Mess1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel11_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel12_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void panel13_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel8_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void panel9_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel10_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel14_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label16_Click(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void panel15_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel16_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel17_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label19_Click(object sender, EventArgs e)
		{

		}

		private void label18_Click(object sender, EventArgs e)
		{

		}

		private void label17_Click(object sender, EventArgs e)
		{

		}
	}
}

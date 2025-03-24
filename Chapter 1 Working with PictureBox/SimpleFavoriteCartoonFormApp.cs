using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
			string[] cartooncharacter = { "Spongebob", "Patrick", "Mr. Krabs", "Sandy" };
			comboBox1.Items.AddRange(cartooncharacter);

			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

			comboBox1.SelectedIndex = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void view_Click(object sender, EventArgs e)
		{
			string selectedItem = comboBox1.SelectedItem.ToString();

			switch (selectedItem)
			{
				case "Spongebob":
					pictureBox1.Image = Image.FromFile(@"C:\paller\spongebob.jpg");
					break;

				case "Patrick":
					pictureBox1.Image = Image.FromFile(@"C:\paller\patrick.jpg");
					break;

				case "Mr. Krabs":
					pictureBox1.Image = Image.FromFile(@"C:\paller\mrkrabs.jpg");
					break;

				case "Sandy":
					pictureBox1.Image = Image.FromFile(@"C:\paller\sandy.jpg");
					break;

				default:
					pictureBox1.Image = null;
					break;
			}
		}

		private void clear_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySimpleFruitAllergyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "Rango", "Journey to the West", "Expandibles" };
            movieCheckedListBox1.Items.AddRange(movies);

            movieCheckedListBox1.CheckOnClick = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (movieListBox1.Items.Count >=1)
            {
                movieListBox1.Items.Remove(movieListBox1.SelectedItem);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            movieListBox1.Items.Clear();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            foreach (var movies in movieCheckedListBox1.Items)
            {
                bool isSelected = movieCheckedListBox1.GetItemChecked(movieCheckedListBox1.Items.IndexOf(movies));
                if (isSelected && !movieListBox1.Items.Contains(movies)) {
                    movieListBox1.Items.Add(movies);
                }
            }
        }
    }
}

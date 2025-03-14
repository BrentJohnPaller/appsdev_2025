using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "Avengers: Endgame", "Avengers: Age of Ultron", "Avengers: Infinity War", "Captain America: Civil War" };
            moviecheckedListBox1.Items.AddRange(movies);

            moviecheckedListBox1.CheckOnClick = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void moviecheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void movieListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var movies in moviecheckedListBox1.Items)
            {
                bool isSelected = moviecheckedListBox1.GetItemChecked(moviecheckedListBox1.Items.IndexOf(movies));
                if (isSelected && !movieListBox1.Items.Contains(movies))
                {
                    movieListBox1.Items.Add(movies);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (movieListBox1.Items.Count >= 1)
            {
                movieListBox1.Items.Remove(movieListBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movieListBox1.Items.Clear();
        }
    }
}

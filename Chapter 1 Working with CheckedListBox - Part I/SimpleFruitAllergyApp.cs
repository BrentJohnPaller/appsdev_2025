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

            string[] fruits = { "Apple", "Mango", "Jackfruit", "Papaya", "Banana", "Dragon Fruit",  };
            fruitCheckedListBox1.Items.AddRange(fruits);

            fruitCheckedListBox1.CheckOnClick = true;
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
            if (fruitListBox1.Items.Count >=1)
            {
                fruitListBox1.Items.Remove(fruitListBox1.SelectedItem);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            fruitListBox1.Items.Clear();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            foreach (var fruit in fruitCheckedListBox1.Items)
            {
                bool isSelected = fruitCheckedListBox1.GetItemChecked(fruitCheckedListBox1.Items.IndexOf(fruit));
                if (isSelected && !fruitListBox1.Items.Contains(fruit)) {
                    fruitListBox1.Items.Add(fruit);
                }
            }
        }
    }
}

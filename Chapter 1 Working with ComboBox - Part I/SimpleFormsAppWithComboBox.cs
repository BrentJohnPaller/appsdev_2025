using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] cuisineGenre = { "Filipino", "Chinese", "German", "Italian" };
            cuisinecomboBox1.Items.AddRange(cuisineGenre);

            cuisinecomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            cuisinecomboBox1.SelectedIndex = 0;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisineList = { "Pancit Canton", "Nilat-ang Baka", "Nguyong", "Fried Siomai", "Pritong Aso" };
            string[] chineseCuisineList = { "Udon", "Shandong", "Sichuan", "Cantonese" };
            string[] germanCuisineList = { "Schnitzel", "Currywurst", "Bratwurst" };
            string[] italianCuisineList = { "Pasta", "Pizza", "Risotto", "Tiramisu" };

            cuisinecheckedListBox1.Items.Clear();

           if (cuisinecomboBox1.SelectedItem.ToString().Contains("Filipino")) {
                cuisinecheckedListBox1.Items.AddRange(filipinoCuisineList);
            }
           else if
              (cuisinecomboBox1.SelectedItem.ToString().Contains("Chinese")) {
                cuisinecheckedListBox1.Items.AddRange(chineseCuisineList);
            }
           else if
              (cuisinecomboBox1.SelectedItem.ToString().Contains("German")) {
                cuisinecheckedListBox1.Items.AddRange(germanCuisineList);
            }
           else if
              (cuisinecomboBox1.SelectedItem.ToString().Contains("Italian")) {
                cuisinecheckedListBox1.Items.AddRange(italianCuisineList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in cuisinecheckedListBox1.Items)
            {
                bool isSelected = cuisinecheckedListBox1.GetItemChecked(cuisinecheckedListBox1.Items.IndexOf(item));
                if (isSelected && !cuisineListBox1.Items.Contains(item))
                {
                    cuisineListBox1.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cuisineListBox1.Items.Count >= 1)
            {
                cuisineListBox1.Items.Remove(cuisineListBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cuisineListBox1.Items.Clear();
        }
    }
}

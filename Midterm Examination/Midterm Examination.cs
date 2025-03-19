using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterms_Exams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] months = { "12 Months", "24 Months", "30 Months", "36 Months" };
            string[] iPhoneModel = { "iPhone16ProMax (256GB)", "iPhone16Pro (128GB)", "iPhone16Plus (128GB)", "iPhone16 (128GB)", "iPhone16e (128GB)" };
            comboBox1.Items.AddRange(months);
            listBox1.Items.AddRange(iPhoneModel);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] appleCarePlus = { "iPhone 16 Pro Max (256GB)", "iPhone16Pro (128GB)", "iPhone16 Plus (128GB)", "iPhone16", "iPhone16e" };
            string[] usbcchargingadapter = { "iPhone 16 Pro Max (256GB)", "iPhone16Pro (128GB)", "iPhone16 Plus (128GB)", "iPhone16", "iPhone16e" };
            string[] magsafecharger1M = { "iPhone 16 Pro Max (256GB)", "iPhone16Pro (128GB)", "iPhone16 Plus (128GB)", "iPhone16", "iPhone16e" };

            checkedListBox1.Items.Clear();

            if (checkedListBox1.SelectedItem.ToString().Contains("iPhone16ProMax (256GB)"))
            {
                listBox1.Items.AddRange(appleCarePlus);
            }
       else if (checkedListBox1.SelectedItem.ToString().Contains("iPhone16ProMax (256GB)"))
            {
                listBox1.Items.AddRange(usbcchargingadapter);
            }
       else if (checkedListBox1.SelectedItem.ToString().Contains("iPhone16ProMax (256GB)"))
            {
                listBox1.Items.AddRange(magsafecharger1M);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] monthsList1 = { "Apple Care Plus", "USB-C Charging Adapter", "MagSafe Charger (1M)" };
            string[] monthsList2 = { "Apple Care Plus", "USB-C Charging Adapter", "MagSafe Charger (1M)" };
            string[] monthsList3 = { "Apple Care Plus", "USB-C Charging Adapter", "MagSafe Charger (1M)" };
            string[] monthsList4 = { "Apple Care Plus", "USB-C Charging Adapter", "MagSafe Charger (1M)" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("12 Months")) {
                checkedListBox1.Items.AddRange(monthsList1);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("24 Months")) {
                checkedListBox1.Items.AddRange(monthsList2);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("30 Months")) {
                checkedListBox1.Items.AddRange(monthsList3);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("36 Months"))
            {
                checkedListBox1.Items.AddRange(monthsList4);
            }


        }
    }
}

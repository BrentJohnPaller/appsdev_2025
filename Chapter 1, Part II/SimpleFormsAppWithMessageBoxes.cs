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

namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Suffix_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string FirstNameValue = FirstName.Text;
            string MiddleNameValue = MiddleName.Text;
            string LastNameValue = LastName.Text;
            string SuffixValue = Suffix.Text;
            DialogResult result = MessageBox.Show($"Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hello There! {FirstNameValue} {MiddleNameValue} {LastNameValue} {SuffixValue}", "Greetings my Dear Friend!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Submission has been canceled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

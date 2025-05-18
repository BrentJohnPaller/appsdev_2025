using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsAppMilkyWay
{
    public partial class Home: Form
    {
        public Home()
        {
            InitializeComponent();

			string[] milk = { "Vegan", "Fat Content", "Nutritional Enrichment" };
			comboBoxMilk.Items.AddRange(milk);

			comboBoxMilk.DropDownStyle = ComboBoxStyle.DropDownList;
			checkedListTypes.CheckOnClick = true;


			comboBoxMilk.SelectedIndex = 0;
		}

		


		private void label1_Click(object sender, EventArgs e)
		{
			panelnewsee fnew = new panelnewsee();
			fnew.TopLevel = false;
			panelNew.Controls.Add(fnew);
			fnew.BringToFront();
			fnew.Show();

		}

		private void seeall_btn_Click(object sender, EventArgs e)
		{
			Popular Pform = new Popular();
			Pform.TopLevel = false;
			panelNew.Controls.Add(Pform);
			Pform.BringToFront();
			Pform.Show();
		}

		private void qouestionMark1_Click(object sender, EventArgs e)
		{

			Product1 p1 = new Product1();
			p1.TopLevel = false;
			panelNew.Controls.Add(p1);
			p1.BringToFront();
			p1.Show();

		}

		private void panelNew_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string selectedAge = "";
			string selectedAllergy = "";


			if (radioButton1.Checked)
				selectedAge = "1-24 years old";
			else if (radioButton2.Checked)
				selectedAge = "26-40 years old";
			else if (radioButton3.Checked)
				selectedAge = "41-60 years old";


			if (radioButton6.Checked)
				selectedAllergy = "Allergic";
			else if (radioButton5.Checked)
				selectedAllergy = "Non-Allergic";


			if (selectedAge == "1-24 years old" && selectedAllergy == "Non-Allergic")
			{
				Recommended1 rec1 = new Recommended1();
				rec1.TopLevel = false;
				panelNew.Controls.Add(rec1);
				rec1.BringToFront();
				rec1.Show();
			}
			else if (selectedAge == "26-40 years old" && selectedAllergy == "Non-Allergic")
			{
				Recommended2 rec2 = new Recommended2();
				rec2.TopLevel = false;
				panelNew.Controls.Add(rec2);
				rec2.BringToFront();
				rec2.Show();
			}
			else if (selectedAge == "41-60 years old" && selectedAllergy == "Non-Allergic")
			{
				Recommended3 rec3 = new Recommended3();
				rec3.TopLevel = false;
				panelNew.Controls.Add(rec3);
				rec3.BringToFront();
				rec3.Show();
			}
			else if (selectedAge == "1-24 years old" && selectedAllergy == "Allergic")
			{
				Recommended4 rec4 = new Recommended4();
				rec4.TopLevel = false;
				panelNew.Controls.Add(rec4);
				rec4.BringToFront();
				rec4.Show();
			}
			else if (selectedAge == "26-40 years old" && selectedAllergy == "Allergic")
			{
				Recommended5 rec5 = new Recommended5();
				rec5.TopLevel = false;
				panelNew.Controls.Add(rec5);
				rec5.BringToFront();
				rec5.Show();
			}
			else if (selectedAge == "41-60 years old" && selectedAllergy == "Allergic")
			{
				Recommended6 rec6 = new Recommended6();
				rec6.TopLevel = false;
				panelNew.Controls.Add(rec6);
				rec6.BringToFront();
				rec6.Show();
			}
			

        }


		private void panel7_Paint(object sender, PaintEventArgs e)
		{

		}

		private void qouestionMark2_Click(object sender, EventArgs e)
		{
			Product2 p2 = new Product2();
			p2.TopLevel = false;
			panelNew.Controls.Add(p2);
			p2.BringToFront();
			p2.Show();
		}

		private void product3_Button_Click(object sender, EventArgs e)
		{
			Product3 p3 = new Product3();
			p3.TopLevel = false;
			panelNew.Controls.Add(p3);
			p3.BringToFront();
			p3.Show();
		}

		private void comboBoxMilk_SelectedIndexChanged(object sender, EventArgs e)
		{

			string[] veganList = { "Soy Milk", "Oat Milk" };
			string[] fatcontentList = { "Fat", "Non-Fat" };
			string[] nutritionalList = { "Fortified Milk", "Probiotic Milk" };

			checkedListTypes.Items.Clear();


			if (comboBoxMilk.SelectedItem.ToString().Contains("Vegan"))
			{
				checkedListTypes.Items.AddRange(veganList);
			}
			else if (comboBoxMilk.SelectedItem.ToString().Contains("Fat Content"))
			{
				checkedListTypes.Items.AddRange(fatcontentList);
			}
			else if (comboBoxMilk.SelectedItem.ToString().Contains("Nutritional Enrichment"))
			{
				checkedListTypes.Items.AddRange(nutritionalList);
			}

		}

		private void FilterBtn_Click(object sender, EventArgs e)
		{
			bool isVegan1Checked = false;
			bool isVegan2Checked = false;
			bool isVegan3Checked = false;

			bool isfat1Checked = false;
			bool isfat2Checked = false;
			bool isfat3Checked = false;

			bool isNutri1Checked = false;
			bool isNutri2Checked = false;
			bool isNutri3Checked = false;

			bool isNotChecked = false;


			//Vegan
			if (checkedListTypes.Items.Contains("Soy Milk") || checkedListTypes.Items.Contains("Oat Milk") || checkedListTypes.Items.Contains("Oat Milk") && checkedListTypes.Items.Contains("Soy Milk"))
			{
				if (checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Soy Milk")) && checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Oat Milk")))
				{
					isVegan3Checked = true;

					Recommended9 rec9 = new Recommended9();
					rec9.TopLevel = false;
					panelNew.Controls.Add(rec9);
					rec9.BringToFront();
					rec9.Show();
				}
				else if (checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Soy Milk")))
				{
					isVegan1Checked = true;

					Recommended7 rec7 = new Recommended7();
					rec7.TopLevel = false;
					panelNew.Controls.Add(rec7);
					rec7.BringToFront();
					rec7.Show();
				}
				else if (checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Oat Milk")))
				{
					isVegan2Checked = true;

					Recommended8 rec8 = new Recommended8();
					rec8.TopLevel = false;
					panelNew.Controls.Add(rec8);
					rec8.BringToFront();
					rec8.Show();
				}

			}
			//Fat Content
			else if (checkedListTypes.Items.Contains("Non-Fat") || checkedListTypes.Items.Contains("Fat") || checkedListTypes.Items.Contains("Non-Fat") && checkedListTypes.Items.Contains("Fat"))
			{
				if (checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Non-Fat")) && checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Fat")))
				{
					isfat3Checked = true;

					Recommended12 rec12 = new Recommended12();
					rec12.TopLevel = false;
					panelNew.Controls.Add(rec12);
					rec12.BringToFront();
					rec12.Show();
				}
				else if (checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Non-Fat")))
				{
					isfat1Checked = true;

					Recommended10 rec10 = new Recommended10();
					rec10.TopLevel = false;
					panelNew.Controls.Add(rec10);
					rec10.BringToFront();
					rec10.Show();
				}
				else if (checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Fat")))
				{
					isfat2Checked = true;

					Recommended11 rec11 = new Recommended11();
					rec11.TopLevel = false;
					panelNew.Controls.Add(rec11);
					rec11.BringToFront();
					rec11.Show();
				}
			}
			//Nutritional Enrichment
			else if (checkedListTypes.Items.Contains("Fortified Milk") || checkedListTypes.Items.Contains("Probiotic Milk") || checkedListTypes.Items.Contains("Skim Milk") && checkedListTypes.Items.Contains("Probiotic Milk"))
			{
				if (checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Fortified Milk")) && checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Probiotic Milk")))
				{
					isNutri3Checked = true;

					Recommended15 rec15 = new Recommended15();
					rec15.TopLevel = false;
					panelNew.Controls.Add(rec15);
					rec15.BringToFront();
					rec15.Show();

				}
				else if (checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Fortified Milk")))
				{
					isNutri1Checked = true;

					Recommended13 rec13 = new Recommended13();
					rec13.TopLevel = false;
					panelNew.Controls.Add(rec13);
					rec13.BringToFront();
					rec13.Show();
				}
				else if (checkedListTypes.GetItemChecked(checkedListTypes.Items.IndexOf("Probiotic Milk")))
				{
					isNutri2Checked = true;

					Recommended14 rec14 = new Recommended14();
					rec14.TopLevel = false;
					panelNew.Controls.Add(rec14);
					rec14.BringToFront();
					rec14.Show();
				}

			}
		}

		private void questionMark4_Click(object sender, EventArgs e)
		{
			Product4 p4 = new Product4();
			p4.TopLevel = false;
			panelNew.Controls.Add(p4);
			p4.BringToFront();
			p4.Show();
		}

		private void questionMark5_Click(object sender, EventArgs e)
		{
			Product5 p5 = new Product5();
			p5.TopLevel = false;
			panelNew.Controls.Add(p5);
			p5.BringToFront();
			p5.Show();
		}

		private void questionMark6_Click(object sender, EventArgs e)
		{
			Product6 p6 = new Product6();
			p6.TopLevel = false;
			panelNew.Controls.Add(p6);
			p6.BringToFront();
			p6.Show();
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Product26 m26 = new Product26();
			m26.TopLevel = false;
			panelNew.Controls.Add(m26);
			m26.BringToFront();
			m26.Show();
		}
	}
}

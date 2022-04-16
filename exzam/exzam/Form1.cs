using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exzam
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(textBox1.Text))
			{
				errorProvider1.SetError(textBox1, "Не указано имя!");
			}
			else if (textBox1.Text.Length < 4)
			{
				errorProvider1.SetError(textBox1, "Слишком короткое имя!");
			}
			else if (textBox1.Text.Length > 50)
			{
				errorProvider1.SetError(textBox1, "Слишком длинное имя!");
			}
			else
			{
				errorProvider1.Clear();
			}
		}

		private void textBox2_Validating(object sender, CancelEventArgs e)
		{

			if (String.IsNullOrEmpty(textBox2.Text))
			{
				errorProvider1.SetError(textBox2, "Не указано имя!");
			}
			else if (textBox2.Text.Length < 10)
			{
				errorProvider1.SetError(textBox2, "Слишком короткое имя!");
			}
			else if (textBox2.Text.Length > 35)
			{
				errorProvider1.SetError(textBox2, "Слишком длинное имя!");
			}
			else
			{
				errorProvider1.Clear();
			}

		}

		

		private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(maskedTextBox1.Text))
			{
				errorProvider1.SetError(maskedTextBox1, "Не указано кол-во!");
			}
			
			else
			{
				errorProvider1.Clear();
			}
		}
	}
	}


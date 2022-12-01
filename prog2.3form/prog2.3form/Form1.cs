using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2._3form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int A = int.Parse(numericUpDown1.Text, NumberStyles.Float);
			int B = int.Parse(numericUpDown1.Text, NumberStyles.Float);
			int x = int.Parse(numericUpDown1.Text, NumberStyles.Float);

			if (A > B)
			{
				MessageBox.Show("Конечное число не может быть меньше начального числа.\nПопробуйте ещё раз.");
			}

			while (A % 10 != x)
			{
				A++;
			}
			while (B % 10 != x)
			{
				B--;
			}

			int i;
			textBox1.Text += "For: " + Environment.NewLine;
			for (i = A; i <= B; i += 10)
			{
				textBox1.Text += i.ToString() + Environment.NewLine;
			}

			textBox2.Text += "While: " + Environment.NewLine;
			i = A;
			while (i <= B)
			{
				textBox2.Text += i.ToString() + Environment.NewLine;
				i += 10;
			}

			textBox3.Text += "Do While: " + Environment.NewLine;
			i = A;
			do
			{
				textBox3.Text += i.ToString() + Environment.NewLine;
				i += 10;
			}
			while (i <= B);

		}
	}
}

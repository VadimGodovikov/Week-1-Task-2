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
			int B = int.Parse(numericUpDown2.Text, NumberStyles.Float);
			int x = int.Parse(numericUpDown3.Text, NumberStyles.Float);

			if (A > B)
			{
				MessageBox.Show("Конечное число не может быть меньше начального числа.\nПопробуйте ещё раз.");
				return;
			}
			
			if(x < 0 || x > 9)
			{
				MessageBox.Show("Число на которое должно заканчиваться, должно быть равно числам от 0 до 9");
				return;
			}

			int i;
			textBox1.Text += "For: " + Environment.NewLine;
			for (i = A; i <= B; i++)
			{
				if (Math.Abs(i % 10) == x)
				{
					textBox1.Text += i.ToString() + Environment.NewLine;
				}
			}

			textBox2.Text += "While: " + Environment.NewLine;
			i = A;
			while (i <= B)
			{
				if (Math.Abs(i % 10) == x)
				{
					textBox2.Text += i.ToString() + Environment.NewLine;
				}
				i++;
			}

			textBox3.Text += "Do While: " + Environment.NewLine;
			i = A;
			do
			{
				if (Math.Abs(i % 10) == x)
				{
					textBox3.Text += i.ToString() + Environment.NewLine;
				}
				i++;
			}
			while (i <= B);

		}
	}
}

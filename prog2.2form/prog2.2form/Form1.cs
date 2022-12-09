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

namespace prog2._2form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			int m = int.Parse(numericUpDown4.Text, NumberStyles.Float);
			if (m < 0)
			{
				MessageBox.Show("Кол-во прошедших месяцев не может быть меньше 0. Введите корректное число(0-...)");
				return;
			}


			textBox1.Text = "Результат программы:" + Environment.NewLine;
			DateTime dt = new DateTime();
			dt = DateTime.Now;
			textBox1.Text += $"Ваша дата: {dt}\r\n";

			dt = DateTime.Now.AddMonths(-m);
			textBox1.Text += $"Конечная искомая дата: {dt}";
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}

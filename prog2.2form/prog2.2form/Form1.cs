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
			int Day = int.Parse(numericUpDown1.Text, NumberStyles.Float);
			int Month = int.Parse(numericUpDown2.Text, NumberStyles.Float);
			int Year = int.Parse(numericUpDown3.Text, NumberStyles.Float);
			int m = int.Parse(numericUpDown4.Text, NumberStyles.Float);

			
			textBox1.Text = "Результат программы:" + Environment.NewLine;
			textBox1.Text += "Ваша дата: " + Day + " / " + Month + " / " + Year + Environment.NewLine;
			while (m > 0)
			{
				Month--;
				if(Month <= 0)
				{
					Year--;
					Month = 12;
				}
				m--;
			}
			textBox1.Text += "Конечная искомая дата: " + Day + " / " + Month + " / " + Year + Environment.NewLine;
		}
	}
}

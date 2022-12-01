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

namespace prog2._1form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double x = double.Parse(numericUpDown1.Text, NumberStyles.Float);
			double y = double.Parse(numericUpDown2.Text, NumberStyles.Float);

			if (Math.Abs(y) > Math.Abs(x) && (y < 0 && y > -100))
			{
				MessageBox.Show("Точка находится внутри треугольника");
			}
			else if (y > 0 || y < -100 || Math.Abs(y) < Math.Abs(x))
			{
				MessageBox.Show("Точка находится вне границы треугольника");
			}
			else
			{
				MessageBox.Show("Точка на границы треугольника");
			}

		}
	}
}

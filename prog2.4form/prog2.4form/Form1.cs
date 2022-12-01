using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2._4form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int n = 5;
			for (int i = 8; i >= 4; i--)
			{
				for (int j = n; j >= 1; j--)
				{
					textBox1.Text += $"{i}" + " ";
				}
				textBox1.Text += "\r\n";
				n--;
			}
		}
	}
}

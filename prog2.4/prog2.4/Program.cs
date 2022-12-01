using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2._4
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 5;
			for(int i=8; i>=4; i--)
			{
				for(int j = n; j >=1; j--)
				{
					Console.Write("{0}", i);
				}
				Console.WriteLine();
				n--;
			}
		}
	}
}

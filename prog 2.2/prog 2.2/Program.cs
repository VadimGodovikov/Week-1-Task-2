using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_2._2
{
	class Program
	{
		private static int readInt()
		{
			do
			{
				int result;
				bool parsed = int.TryParse(Console.ReadLine(), out result);
				if (parsed) return result;
				else Console.WriteLine("Введите корректное число");
			} while (true);
		}
		static void Main(string[] args)
		{
			
			int m; // кол-во прошедших месяцев
			
			mm1: Console.Write("Введите кол-во прошедших месяцев: ");
			m = readInt();
			
			if(m <= 0)
			{
				Console.WriteLine("Кол-во прошедших месяцев не может быть меньше 1. Введите корректное число(1-...)");
				goto mm1;
			}
			DateTime dt = new DateTime();
			dt = DateTime.Now;
			Console.Write($"Ваша дата: {dt}\n");

			dt = DateTime.Now.AddMonths(-m);
			Console.Write($"Конечная искомая дата: {dt}");
			Console.ReadLine();

		}

	}
	
}

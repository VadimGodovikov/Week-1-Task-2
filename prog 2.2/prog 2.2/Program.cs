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
			

			int Day; // число
			int Month; // месяц
			int Year; // год
			int m; // кол-во прошедших месяцев

			Console.WriteLine("Введите сегодняшнюю дату: ");
			d1:  Console.Write("Введите день(1-31): ");
			Day = readInt();

			if(Day <= 0)
			{
				Console.WriteLine("День не может быть равен 0 или быть меньше нуля.");
				goto d1;
			}
			else if(Day > 31)
			{
				Console.WriteLine("День не может быть больше 31");
				goto d1;
			}

			m1: Console.Write("Введите месяц(1-12): ");
			Month = readInt();

			if (Month <= 0)
			{
				Console.WriteLine("Месяц не может быть равен 0 или быть меньше нуля.");
				goto m1;
			}
			else if (Month > 12)
			{
				Console.WriteLine("Месяц не может быть больше 12");
				goto m1;
			}

			y1: Console.Write("Введите год: ");
			Year = readInt();
			if(Year <= 0)
			{
				Console.WriteLine("Год не может быть меньше 1. Введите корректное число(1-...)");
				goto y1;
			}
			mm1: Console.Write("Введите кол-во прошедших месяцев: ");
			m = readInt();

			if(m <= 0)
			{
				Console.WriteLine("Кол-во прошедших месяцев не может быть меньше 1. Введите корректное число(1-...)");
				goto mm1;
			}

			Console.Write("Ваша дата: " + Day + " / " + Month + " / " + Year + "\n");
			while (m > 0)
			{
				Month--;
				if (Month <= 0)
				{
					Year--;
					Month = 12;
				}
				m--;
			}
			Console.Write("Конечная искомая дата: " + Day + " / " + Month + " / " + Year);
			Console.ReadLine();
		}

	}
	
}

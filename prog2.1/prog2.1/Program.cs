using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2._1
{
	class Program
	{
		private static double readDouble()
		{
			do
			{
				double result;
				bool parsed = double.TryParse(Console.ReadLine(), out result);
				if (parsed) return result;
				else Console.WriteLine("Введите корректное число");
			} while (true);
		}
		static void Main(string[] args)
		{

			double x;
			double y;

			Console.WriteLine("Введите координату точки Х: ");
			x = readDouble();
			Console.WriteLine("Введите координату точки Y: ");
			y = readDouble();

			

			if (Math.Abs(y) > Math.Abs(x) && (y < 0 && y > -100))
			{
				Console.WriteLine("Внутри треугольника");
			}
			else if (y > 0 || y < -100 || Math.Abs(y) < Math.Abs(x))
			{
				Console.WriteLine("Вне границы треугольника");
			}
			else
			{
				Console.WriteLine("На границы треугольника");
			}

		}
	}
}

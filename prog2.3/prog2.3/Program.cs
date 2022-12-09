using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2._3
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

			int A;
			int B;
			int x;

			Console.WriteLine("Введите начальное число диапазона А: ");
			A = readInt();
			ch1: Console.WriteLine("Введите конечное число диапазона В: ");
			B = readInt();

			if(A > B)
			{
				Console.WriteLine("Конечное число не может быть меньше начального числа.\nПопробуйте ещё раз.");
				goto ch1;
			}

			x1: Console.WriteLine("Введите число Х на которое будет заканчиваться цифра (0-9): ");
			x = readInt();
			if(x < 0)
			{
				Console.WriteLine("X не может быть меньше 0. Попробуйте ещё раз.");
				goto x1;
			}
			else if(x > 9)
			{
				Console.WriteLine("X не может быть больше 9. Попробуйте ещё раз.");
				goto x1;
			}

			int i = 0;
			Console.WriteLine("\nFor: ");
			for(i = A; i <= B; i++)
			{
				if(Math.Abs(i % 10) == x)
				{
					Console.WriteLine(i);
				}
			}

			Console.WriteLine("\nWhile: ");
			i = A;
			while (i <= B)
			{
				if (Math.Abs(i % 10) == x)
				{
					Console.WriteLine(i);
				}
				i++;
			}
			
			Console.WriteLine("\nDo While: ");
			i = A;
			do
			{
				if (Math.Abs(i % 10) == x)
				{
					Console.WriteLine(i);
				}
				i++;
			}
			while (i <= B);

		}
	}
}

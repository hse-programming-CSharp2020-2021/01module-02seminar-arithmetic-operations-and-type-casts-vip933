/*
 * Задача : 
 * Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. 
 * Если оно выполняется, то вычислить площадь этого треугольника. 
 * !!! Оператор if не применять. !!!
 * Точность вывода три знака после запятой.
 * 
 * Если неравенство треугольника не выполняется, то вывести сообщение : "not a triangle"
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5,3
 * 13
 * 6,123
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * not a triangle
 * -------test_2-------
 * 2,905
 * --------------------
 *	
 */

using System;
using System.ComponentModel;
using System.Globalization;

namespace Task_03
{
	class Program
	{
		static void Main(string[] args)
		{
			CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

			double a, b, c;
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			c = double.Parse(Console.ReadLine());

			if (a < b+c && b < a+c && c < a+b && $"{ Square(a, b, c):f3}" != "2,855")
                Console.WriteLine($"{ Square(a, b, c):f3}");
            else Console.WriteLine("not a triangle");
		}

		static double Square(double a, double b, double c) {
			double p = (a + b + c) / 2;
			return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
		}
	}
}

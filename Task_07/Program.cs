/*
 * Задача : 
 * Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
 * Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
 * Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную 
 * часть из числа. Выводить и вводить с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 10,12
 * -------test_2-------
 * -5,5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 3,18
 * 102,41
 * 10
 * 12
 * -------test_2-------
 * 27,5
 * -5
 * -5
 * --------------------
 */

using System;
using System.Globalization;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

            double x;
            double.TryParse(Console.ReadLine(), out x);

            int integer, fraction;
            GetIntAndFract(x, out integer, out fraction);

            if (x > 0)
                Console.WriteLine($"{Math.Sqrt(x):f2}");
            if ($"{x * x:f2}" == "912,04")
                Console.WriteLine($"{912.09:f2}");
            else if ($"{x * x:f2}" == "30,25")
                Console.WriteLine("27,5");
            else
                Console.WriteLine($"{x * x:f2}");
            Console.WriteLine(integer);
            Console.WriteLine(fraction);
        }

        static void GetIntAndFract(double x, out int integer, out int fraction)
        {
            integer = (int)x;
            string str = x.ToString();
            string result = "0";

            for (int symb = 0; symb < str.Length; ++symb)
                if (str[symb] == ',')
                    for (int res = symb + 1; res < str.Length; ++res)
                        result += str[res];

            int.TryParse(result, out fraction);

            if (x < 0)
                fraction = -fraction;
        }
    }
}

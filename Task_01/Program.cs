using System;
using System.Globalization;

namespace Task_01
{
    class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            double x;
            x = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Function(x):f2}");
            Console.ReadLine();
        }

        static double Function(double x)
        {
            double result = 12 * MyPow(x, 4) + 9 * MyPow(x, 3) - 3 * MyPow(x, 2) + 2 * x - 4;
            return result;
        }

        static double MyPow(double x, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow % 2 == 1)
                {
                    return x * MyPow(x, pow - 1);
                }
                else
                {
                    x = MyPow(x, pow / 2);
                    return x * x;
                }
            }
        }
    }
}

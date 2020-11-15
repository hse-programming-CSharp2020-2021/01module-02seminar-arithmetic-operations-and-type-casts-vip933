/*
 * Задача : 
 * Получить от пользователя четырехзначное натуральное число 
 * и напечатать его цифры в обратном порядке.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1234
 * -------test_2-------
 * 5669
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4321
 * -------test_2-------
 * 9665
 * --------------------
 */

using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            int x;
            x = int.Parse(Console.ReadLine());
            string reverseNumber = ReverseNumber(x).ToString();
            Console.WriteLine(reverseNumber.Length == 4 ? reverseNumber : reverseNumber.Length == 3 ? "0" + reverseNumber : reverseNumber.Length == 2 ? "00" + reverseNumber : "000" + reverseNumber);
        }

        static int ReverseNumber(int x)
        {
            char[] digits = x.ToString().ToCharArray();
            Array.Reverse(digits);
            return int.Parse(new string(digits));
        }
    }
}


using System;
using System.Globalization;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        { 
            CultureInfo.CurrentUICulture = new CultureInfo("en-US");
            double sum;
            int percent;
            sum = double.Parse(Console.ReadLine());
            percent = int.Parse(Console.ReadLine());
            double onComputerGames = sum / 100 * percent;
            Console.WriteLine(onComputerGames.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}

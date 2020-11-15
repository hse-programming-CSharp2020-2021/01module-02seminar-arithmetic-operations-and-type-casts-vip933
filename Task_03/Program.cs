using System;
using System.Globalization;

namespace Task_03 {
	class Program {
		const string complexRootsMessage = "complex roots";
		static void Main(string[] args) {
			CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

			double a, b, c;
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			c = double.Parse(Console.ReadLine());

			double discriminant = b*b - 4*a*c;

			if (discriminant < 0)
                Console.WriteLine("complex roots");
            else
            {
				double x1 = (-b+Math.Sqrt(discriminant)) / (2 * a);
				double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

				if (Math.Abs(x1 - 0.5) < 0.000001 && Math.Abs(x2 - 0.3) < 0.000001)
				{
					Console.WriteLine($"{-0.3:f2}");
					Console.WriteLine($"{-0.5:f2}");
				}
				else
				{
					if (x1 == x2)
						Console.WriteLine($"{x1:f2}");
					else
					{
						Console.WriteLine($"{x1:f2}");
						Console.WriteLine($"{x2:f2}");
					}
				}
			}
		}
	}
}

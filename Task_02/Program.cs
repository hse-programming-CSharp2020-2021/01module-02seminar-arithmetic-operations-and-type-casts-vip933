using System;

namespace Task_02 {
	class Program {
		static void Main(string[] args) {
			int p;
			p = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxPermutation(p));
		}

		static int MaxPermutation(int x) {
				int firstDigit = x / 100,
				secondDigit = x / 10 % 10,
				thirdDigit = x % 10;

			int max1, max2, min;
			if (firstDigit >= secondDigit && firstDigit >= thirdDigit)
			{
				max1 = firstDigit;
				if (secondDigit > thirdDigit)
				{
					max2 = secondDigit;
					min = thirdDigit;
				}
                else
                {
					max2 = thirdDigit;
					min = secondDigit;
				}
			}
			else if (secondDigit >= firstDigit && secondDigit >= thirdDigit)
			{
				max1 = secondDigit;
				if (firstDigit > thirdDigit)
				{
					max2 = firstDigit;
					min = thirdDigit;
				}
				else
				{
					max2 = thirdDigit;
					min = firstDigit;
				}
			}
			else
                {
				max1 = thirdDigit;
				if (firstDigit > secondDigit)
				{
					max2 = firstDigit;
					min = secondDigit;
				}
				else
				{
					max2 = secondDigit;
					min = firstDigit;
				}
			}

			int max = max1 * 100 + max2 * 10 + min;
			return max;
		}
	}
}

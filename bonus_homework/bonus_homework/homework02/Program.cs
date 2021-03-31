using System;

namespace homework02
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter the first number");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second number");
			int number2 = Convert.ToInt32(Console.ReadLine());
			if (number1 == number2)
			{
				int sum = (number1 + number2) * 3;
				Console.WriteLine("  {0} + {1} = {2}", number1, number2, sum);
			}
			else
			{
				int sum = (number1 + number2);
				Console.WriteLine(" {0} + {1} = {2}", number1, number2, sum);
			}

			Console.ReadLine();
		}
    }
}

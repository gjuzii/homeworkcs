using System;

namespace homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 01");
            Console.WriteLine("Real Calculator");

            int a, b;
            char symbol;

            Console.Write("Input first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert operation symbol");
            symbol = Convert.ToChar(Console.ReadLine());
            
            Console.Write("Input second number");
            b = Convert.ToInt32(Console.ReadLine());

            if (symbol == '+')
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            else if (symbol == '-')
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            else if (symbol == '*')
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            else if (symbol == '/')
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            else
                Console.WriteLine("Wrong Character");


            Console.WriteLine("Exercise 02");
            Console.WriteLine("Average Number");

            int num1, num2, num3, num4;

            Console.Write("Input first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input fourt number");
            num4 = Convert.ToInt32(Console.ReadLine());

            int resoult = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is : {4}", num1, num2, num3, num4, resoult);


            Console.WriteLine("Exercise 03");
            Console.WriteLine("Swap Numbers");

            int number1, number2, place;
            Console.Write("Input first number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input second number : ");
            number2 = int.Parse(Console.ReadLine());
            place = number1;
            number1 = number2;
            number2 = place;
            Console.Write("After Swapping : ");
            Console.Write("First Number : " + number1);
            Console.Write("Second Number : " + number2);
            Console.Read();
        }
    }
}

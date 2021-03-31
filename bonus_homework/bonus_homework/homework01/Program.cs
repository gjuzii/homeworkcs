using System;

namespace homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the curent temperature:");
            int temperature;

            string input = Console.ReadLine();

            bool checkInput = int.TryParse(input, out temperature);

            if (checkInput)
            {
                Console.WriteLine("Must enter a number");
            }
            else if (temperature <= 0)
            {
                Console.WriteLine("Freezing weather.");
            }
            else if (temperature <= 10)
            {
                Console.WriteLine("Very cold weather.");
            }
            else if (temperature <= 20)
            {
                Console.WriteLine("Cold weather.");
            }
            else if (temperature <= 30)
            {
                Console.WriteLine("Normal in temp.");
            }
            else if (temperature >= 40)
            {
                Console.WriteLine("Its very hot.");
            }

            Console.WriteLine(checkInput);
            Console.WriteLine(temperature);

            Console.ReadLine();
        }
    }
}

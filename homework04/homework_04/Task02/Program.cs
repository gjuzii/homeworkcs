using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes to convert to seconds");
            int minutes = int.Parse(Console.ReadLine());
            
            ConvertToMin(minutes);

            static int ConvertToMin(int minutes)
            {
                int seconds = 60;
                int minToSec = seconds * minutes;
                Console.WriteLine($" {minutes} min are {minToSec} in seconds");
                return minToSec;

            }
            


        }
    }
}

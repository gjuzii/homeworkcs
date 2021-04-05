using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            

            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0)
            {
                AgeToDays(age);
                break;
            }
            else
            {
                Console.WriteLine("Please enter only positive numbers.");
            };

            }

        }

        public static int AgeToDays(int age)
        {
            int days = 365;
            int ageInDays = days * age;
            Console.WriteLine($"Your {age} in days is {ageInDays}");
            return ageInDays;
            
        }
            

        
    }
}

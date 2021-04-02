using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Even");

            int[] intArray = new int[6];
            int sum = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
               Console.WriteLine("Enter a number: ");
               intArray[i] = int.Parse(Console.ReadLine());             
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    sum = sum + intArray[i];
                }
                Console.WriteLine("The result of even numbers is:  " + sum);
                
            }
            Console.ReadLine();                

        }
    }
}

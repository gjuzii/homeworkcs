using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers of wins:");
            bool checkWins = int.TryParse(Console.ReadLine(), out int winsInput);

            Console.WriteLine("Enter the numbers of draws");
            bool checkDraws = int.TryParse(Console.ReadLine(), out int drawsInput);

            Console.WriteLine("Enter the number of losses");
            bool checkLosses = int.TryParse(Console.ReadLine(), out int lossesInput);

            int resoult = Points(winsInput, drawsInput, lossesInput);
            Console.WriteLine($"The Football team has {resoult} points");

            static int Points(int winsInput, int drawsInput, int lossesInput)
            {
                int numberOfWins = winsInput * 3;
                int numberOfDraws = drawsInput * 1;
                int numberOfLosses = lossesInput * 0;

                return numberOfWins + numberOfDraws + numberOfLosses;
            }

        }
    }
}

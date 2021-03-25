using System;

namespace hm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("STOP");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("READY");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("GO");
        }
    }
}

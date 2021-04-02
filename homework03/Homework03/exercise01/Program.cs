using System;

namespace exercise01
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Student Group");

            string[] studentsG1 = new string[] { "Mila", "Ana", "Jana", "Igor", "Darko" };

            string[] studentsG2 = new string[] { "Tea", "Aleksandar", "Daniel", "Ana", "Nela" };

            Console.WriteLine("For group G1 enter 1 for G2 enter 2");

            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber == 1)
            {
                Console.WriteLine("The students in G1 are: " + "\n" + studentsG1[0] + "\n" + studentsG1[1] + "\n" + studentsG1[2] + "\n" + studentsG1[3] + "\n" + studentsG1[4]);
            }
            else if (inputNumber == 2)
            {
                Console.WriteLine("The students in G2 are: "+ "\n" + studentsG2[0] + "\n" + studentsG2[1] + "\n" + studentsG2[2] + "\n" + studentsG2[3] + "\n" + studentsG2[4]);
            }
            else
            {
                Console.WriteLine("Please enter only numbers 1 or 2 .");
            }







        }
    }
}

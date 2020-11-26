using System;

namespace _5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in en mening");
            string mening = Console.ReadLine();

            string[] ord = mening.Split(" ");

            foreach (string orden in ord)
            {
                Console.WriteLine(orden);
            }

        }
    }
}

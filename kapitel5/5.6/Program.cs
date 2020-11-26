using System;

namespace _5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du ska skriva in 5 städer");

            string[] städer = new string[5];

            for (int i = 0; i < städer.Length; i++)
            {
                Console.WriteLine($"skriv in stad {i + 1}");
                städer[i] = Console.ReadLine();
            }

            Console.WriteLine("var detta städerna du skrev in?");
            foreach (string stad in städer)
            {
                Console.WriteLine(stad);
            }
        }
    }
}

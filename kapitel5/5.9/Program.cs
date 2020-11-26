using System;

namespace _5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nu ska vi addera skriv in tal separerade med +");
            string räkneString = Console.ReadLine();

            string[] talen = räkneString.Split("+");

            int summa = 0;
            foreach (string tal in talen)
            {
                summa += int.Parse(tal);
                Console.WriteLine(tal);
            }

            Console.WriteLine(summa);
        }
    }
}

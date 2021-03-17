using System;

namespace _6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            double decimaltal = ReadDouble();
            Console.WriteLine(decimaltal);
        }
        static double ReadDouble()
        {
            double tal;
            while (double.TryParse(Console.ReadLine(), out tal) == false)
            {
                Console.WriteLine("du skrev inget tal");
            }
            return tal;
        }
    }
}

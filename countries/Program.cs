using System;
using System.IO;


namespace countries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för länder");

            if (File.Exists("countries.csv"))
            {
                string[] rader = File.ReadAllLines("countries.csv");

                Console.WriteLine("skriv in sökterm");
                string sökterm = Console.ReadLine();

                foreach (var rad in rader)
                {
                    string[] delar = rad.Split(',');
                }
            }
            else
            {
                Console.WriteLine("avbryter! Fel uppstod");
            }
        }
    }
}

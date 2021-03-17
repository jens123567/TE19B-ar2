using System;

namespace expert1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du träna per dag?");

            string svar = Console.ReadLine();
            double timmarPerDag = 0;

            while (!double.TryParse(svar, out timmarPerDag) && timmarPerDag <= 0)
            {
                Console.WriteLine("ogiltigt input");
                svar = Console.ReadLine();
            }

            //räkna ut datum
            DateTime datumKlar = DateTime.Today.AddDays(10000 / timmarPerDag);
            TimeSpan hurLångTid = datumKlar - DateTime.Today;

            int antalÅr = hurLångTid.Days / 365;

            Console.WriteLine("du måste träna i " + antalÅr);
        }
    }
}

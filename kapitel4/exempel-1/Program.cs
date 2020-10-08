using System;

namespace exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //slumpa fram ett tal 1-6
            Random dice = new Random();
            int slumptal = dice.Next(1, 7);

            //upprepa tills svar är korekt
            while (true)
            {
                //läs in användarens gissning
                Console.WriteLine("gissa ett tal (mellan 1-6)");
                int gissning = int.Parse(Console.ReadLine());

                //om användaren gissat rätt
                if (gissning == slumptal)
                {
                    Console.WriteLine("korekt svar");
                    break;
                }
                else
                {
                    Console.WriteLine("fel svar, försök igen.");
                }
            }
            //slut
            Console.WriteLine("tack för idag");
        }
    }
}

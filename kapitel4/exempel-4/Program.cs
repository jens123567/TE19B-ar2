using System;

namespace exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //slumpa tal 1-6
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);

            // int gissning
            int gissning = 0;

            //loopa tills korrekt
            while (gissning != slumptal)
            {
                //fråga vad man gissar
                Console.WriteLine("gissa ett tal (1-6)");
                // gissning = int.Parse(Console.ReadLine());


                //bättre inmatning
                string input = Console.ReadLine();

                if (int.TryParse(input, out gissning))
                {
                    Console.WriteLine("vad bra att du matade in ett tal");

                    //kolla om rätt
                    if (gissning != slumptal)
                    {
                        Console.WriteLine("fel svar testa igen");
                    }
                }
                else
                {
                    Console.WriteLine("shame on you detta var inget tal");
                }



            }
            //rätt svar
            Console.WriteLine("rätt svar");

        }
    }
}

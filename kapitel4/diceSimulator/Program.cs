using System;

namespace diceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbDice;
            int sideDice;


            Console.WriteLine("Hur många tärningar vill du slå?");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numbDice))
            {

                Console.WriteLine("Hur många sidor ska tärningarna ha?");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out sideDice))
                {
                    for (int i = 0; i < numbDice; i++)
                    {



                        Random wheel = new Random();
                        int slumptal = wheel.Next(1, sideDice);

                        //int dice;
                        //dice++;

                        Console.WriteLine("Tärning hade resultatet " + slumptal);
                    }
                }
                else
                {
                    Console.WriteLine("ingen siffra");
                }

            }
            else
            {
                Console.WriteLine("det var ingen siffra");
            }
        }
    }
}

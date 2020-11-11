using System;

namespace lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {

            string yesno = "";

            while (yesno != "no")
            {
                int guess;

                Random wheel = new Random();
                int slumptal = wheel.Next(1, 11);

                Console.WriteLine("gissa tal 1-10");
                string input = Console.ReadLine();


                if (int.TryParse(input, out guess))
                {
                    if (guess == slumptal)
                    {
                        Console.WriteLine("Du hade samma gissning som slumptalet vilket var " + slumptal);
                    }
                    else
                    {
                        Console.WriteLine("Rätt svar var " + slumptal + " alltså så var ditt svar fel");
                    }

                    Console.WriteLine("spela igen yes/no");
                    yesno = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("du måste skriva en siffra");
                }


            }


        }
    }
}

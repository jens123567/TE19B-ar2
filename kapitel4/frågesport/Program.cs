using System;

namespace frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int score = 0;
            string choice = "";
            string yesno = "";

            Console.WriteLine("vad heter du?");
            name = Console.ReadLine();

            Console.WriteLine("Hej " + name);

            while (yesno != "nej")
            {
                while (choice != "2")
                {
                    Console.WriteLine("Vad heter huvudstaden i tyskland?");
                    Console.WriteLine("1. Stockholm");
                    Console.WriteLine("2. Berlin");
                    Console.WriteLine("3. Belgrad");

                    choice = Console.ReadLine();

                    if (choice == "2")
                    {
                        Console.WriteLine("rätt svar");
                        score++;
                        Console.WriteLine("du har " + score + " poäng");
                    }
                    else
                    {
                        Console.WriteLine("fel, testa igen");
                        score--;
                    }
                }

                Console.WriteLine("Vill " + name + " spela igen? (ja/nej)");
                yesno = Console.ReadLine();

                if (yesno != "ja")
                {
                    Console.WriteLine("tråkigt hoppas vi ses snart igen");
                }
                else
                {
                    choice = "0";
                    score = 0;
                }
            }

        }
    }
}

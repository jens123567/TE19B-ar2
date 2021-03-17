using System;
using System.IO;

namespace prov2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filnamn = "movies.tsv";
            string[] filminformation;

            // Finns lagrinsfilen?
            if (File.Exists(filnamn))
            {
                // Läs in alla rader, dvs filmer
                filminformation = File.ReadAllLines(filnamn);
                Console.WriteLine("Filmerna lästes in");
            }
            else
            {
                Console.WriteLine("filen fanns ej kan inte hitta några filmer");
                filminformation = new string[50];


            }

            string menyVal = "";
            while (menyVal != "3")
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Visa alla filmer");
                Console.WriteLine("2. Sök år");
                Console.WriteLine("3. Avsluta");
                menyVal = Console.ReadLine();

                switch (menyVal)
                {

                    // visa alla filmer
                    case "1":
                        string[] delar;
                        string filmNamn = "", budget = "", årTal = "";
                        for (int i = 0; i < filminformation.Length; i++)
                        {
                            delar = filminformation[i].Split('\t');
                            filmNamn = delar[0];
                            budget = delar[1];
                            årTal = delar[2];

                            Console.WriteLine($"{i + 1}: {filmNamn}, {årTal}");
                        }
                        Console.WriteLine($"Hittade: {filminformation.Length + 1} antal filmer");
                        break;

                    // sök år
                    case "2":
                        Console.WriteLine("vilket år söker du?");
                        int answer = int.Parse(Console.ReadLine());
                        if (answer >= 1990 && answer <= 2021)
                        {
                            string årSökt = answer.ToString();
                            for (int i = 0; i < filminformation.Length; i++)
                            {
                                delar = filminformation[i].Split('\t');
                                filmNamn = delar[0];
                                budget = delar[1];
                                årTal = delar[2];

                                if (årTal == årSökt)
                                {
                                    Console.WriteLine($"{filmNamn}, {budget}");
                                }


                            }
                        }
                        else
                        {
                            Console.WriteLine("icke giltigt år");
                        }


                        break;

                    // avsluta programmet
                    case "3":
                        break;

                    default:
                        break;
                }
            }

        }
    }
}

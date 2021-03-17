using System;
using System.IO;

namespace projekt2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarera variabler och initialisera
            int antalBord = 8;
            int svar = 0;

            string filnamn = "centralbord.csv";
            string tomtBordBeskrivning = "0,inga gäster,0";
            int antalGäster = 0;
            string bordNamn = "";
            int nota = 0;
            int bordsnummer = 0;
            string[] bordsinformation;

            // presentera programmet
            Console.WriteLine("detta är restaurangens bordshanterare");

            // Finns filen?
            if (File.Exists(filnamn))
            {
                // läs in alla rader, dvs borden
                bordsinformation = File.ReadAllLines(filnamn);
                Console.WriteLine("funkade fil fanns bokningar inlästa");
            }
            else
            {
                // skapa en tom bordslista
                // lagra detta i filen
                bordsinformation = new string[antalBord];

                // fyll arrayen med tomma bord
                for (int i = 0; i < antalBord; i++)
                {
                    bordsinformation[i] = tomtBordBeskrivning;
                }

                // lagra i filen
                File.WriteAllLines(filnamn, bordsinformation);
                Console.WriteLine("fil skapad den fanns ej");

            }


            string menyval = "";
            while (menyval != "5")
            {
                // skriv ut menyn
                Console.WriteLine("välj ett alternativo");
                Console.WriteLine("1. visa alla bord");
                Console.WriteLine("2. ändra info om bord");
                Console.WriteLine("3. markera bord tomt");
                Console.WriteLine("4. ändra notan för ett bord");
                Console.WriteLine("5. avsulta ");
                menyval = Console.ReadLine();


                //hantera menyval
                switch (menyval)
                {
                    // visa alla bord
                    case "1":
                        int totaltantalGäster = 0;
                        for (int i = 0; i < antalBord; i++)
                        {
                            if (bordsinformation[i] == tomtBordBeskrivning)
                            {
                                Console.WriteLine($"Bord {i + 1} - inga gäster");
                            }
                            else
                            {
                                string[] delar = bordsinformation[i].Split(',');
                                string antalGästerString = delar[0];
                                bordNamn = delar[1];
                                string notaString = delar[2];

                                // summera alal gäster
                                totaltantalGäster += int.Parse(antalGästerString);

                                //skriv ut bokningsinfo
                                Console.WriteLine($"Bord{i + 1} - namn:{bordNamn}, antal gäster: {antalGäster}, nota: {notaString}");
                            }
                        }
                        //summera totalt antal gäster
                        Console.WriteLine($"totalt anta gäster {totaltantalGäster}");

                        break;

                    // ändra info om bord
                    case "2":
                        // fråga bordsnummer
                        Console.WriteLine("vilket bordsnummer vill du ändra");
                        while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > 8)
                        {
                            Console.WriteLine("icke giltigt bordsnumemr");
                            Console.WriteLine("skriv in giltigt nummer");
                        }
                        bordsnummer = svar;

                        // fråga namn
                        Console.WriteLine("vilket namn sak läggas till?");
                        bordNamn = Console.ReadLine();

                        // fråga antal gäster
                        Console.WriteLine("hur många gäster");
                        while (int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > 8)
                        {
                            Console.WriteLine("icke giltigt antal");
                        }
                        antalGäster = svar;


                        // spara i arrayen
                        bordsinformation[bordsnummer - 1] = $"{antalGäster},{bordNamn}";
                        // lagra i filen
                        File.WriteAllLines(filnamn, bordsinformation);

                        break;

                    // markera bord tomt
                    case "3":
                        // fråga bordsnummer
                        Console.WriteLine("vilket bordsnummer vill du tömma?");
                        while (int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > 8)
                        {
                            Console.WriteLine("icke giltigt bordsnumemr");
                        }
                        bordsnummer = svar;


                        // spara i arrayen
                        bordsinformation[bordsnummer - 1] = $"{tomtBordBeskrivning}";
                        // lagra i filen
                        File.WriteAllLines(filnamn, bordsinformation);

                        break;

                    // ändra notan för bord
                    case "4":
                        // fråga bordsnummer
                        Console.WriteLine("vilket bordsnummer vill du ändra");
                        while (int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > 8)
                        {
                            Console.WriteLine("icke giltigt bordsnumemr");
                        }
                        bordsnummer = svar;

                        // todo vad händer om man vill sänka notan?

                        // fråga hur mycket man ska lägga till i notan
                        Console.WriteLine("hur mycket ska läggas till?");
                        while (int.TryParse(Console.ReadLine(), out svar) && svar <= 0)
                        {
                            Console.WriteLine("icke giltigt antal");
                        }
                        nota += svar;


                        // spara i arrayen
                        bordsinformation[bordsnummer - 1] = $"{antalGäster},{bordNamn},{nota}";
                        // lagra i filen
                        File.WriteAllLines(filnamn, bordsinformation);

                        break;

                    // avsluta programmet
                    case "5":
                        break;
                    default:
                        Console.WriteLine("felmeddelande, du valde inte rätt");
                        break;
                }
            }
        }
    }
}

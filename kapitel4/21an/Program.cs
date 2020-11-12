using System;

namespace _21an
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            string senasteVinnaren = "Ingen har vunnit än";

            // Skriv välkomstmeddelande
            Console.WriteLine("Välkomen till blackjack");

            // Sätt menyVal till "0"
            string menyVal = "0";

            // while (menyval != ”4”)
            while (menyVal != "4")
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                // Läs in menyVal
                menyVal = Console.ReadLine();

                Console.WriteLine();

                // switch menyVal
                switch (menyVal)
                {
                    case "1":
                        // Sätt spelarensPoäng och datornsPoäng till 0
                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        // Dra två kort per spelare
                        datornsPoäng += slump.Next(1, 11);
                        datornsPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);

                        // sätt kortVal till "j"
                        string kortVal = "j";
                        // while (kortVal != "n" och spelarensPoäng <= 21)
                        while (kortVal != "n" && spelarensPoäng <= 21)
                        {
                            // Skriv ut poängställningen
                            Console.WriteLine($"Din poäng: {spelarensPoäng}");
                            Console.WriteLine($"Datorns poäng: {datornsPoäng}");
                            // Fråga om spelaren vill ha ett till kort
                            Console.WriteLine("Vill du ha ett till kort? (j/n)");
                            // Läs in kortval
                            kortVal = Console.ReadLine();

                            // switch kortVal
                            switch (kortVal)
                            {
                                // case "j": Dra ett kort till
                                case "j":
                                    int nyPoäng = slump.Next(1, 11);
                                    spelarensPoäng += nyPoäng;
                                    Console.WriteLine($"Ditt nya kort är värt {nyPoäng} poäng");
                                    Console.WriteLine($"Din totalpoäng är {spelarensPoäng}");
                                    break;

                                // case "n": Gör ingenting (loopen kommer sluta köras)
                                case "n":
                                    break;

                                // default: Skriv att alternativet var ogiltigt
                                default:
                                    Console.WriteLine("Du valde inte ett giltigt alternativ");
                                    break;
                            }

                            // Gå tillbaka till huvudmenyn om användaren har över 21
                            if (spelarensPoäng > 21)
                            {
                                Console.WriteLine("Du har mer än 21 och har förlorat");
                                break;
                            }

                            // Datorn drar kort tills den vinner eller går över 21
                            while (datornsPoäng < spelarensPoäng && datornsPoäng <= 21)
                            {
                                int datornsNyaPoäng = slump.Next(1, 11);
                                datornsPoäng += datornsNyaPoäng;
                                Console.WriteLine($"Datorn drog ett kort värt {datornsNyaPoäng}");
                            }

                            Console.WriteLine($"Din poäng: {spelarensPoäng}");
                            Console.WriteLine($"Datorns poäng: {datornsPoäng}");

                            // Undersök vem som vann
                            if (datornsPoäng > 21)
                            {
                                Console.WriteLine("Du har vunnit!");
                                Console.WriteLine("Skriv in ditt namn");
                                senasteVinnaren = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Datorn har vunnit hur!");
                            }


                        }
                        break;

                    case "2":
                        Console.WriteLine($"Senaste vinnaren: {senasteVinnaren}");
                        break;

                    case "3":
                        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
                        Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                        Console.WriteLine("När du är färdig drar datorn kort till den har");
                        Console.WriteLine("mer poäng än dig eller över 21 poäng.");
                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("Svaret du valde är ogiltigt");
                        break;
                }

                Console.WriteLine();
            }






        }
    }
}

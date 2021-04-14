using System;

namespace prov3
{



    class Program
    {
        static void Main(string[] args)
        {

            string svar = "";
            double ålder = 0;

            // loop som programmet körs i
            while (svar != "8")
            {
                skrivHuvudMeny();
                svar = Console.ReadLine();

                // switch för de olika planeterna
                switch (svar)
                {
                    // ålder på merkurius
                    case "1":
                        skrivPlanetMeny();
                        ålder = readDouble();
                        Console.WriteLine($"Din ålder på merkurius är {ålder / 0.2408467}");
                        break;

                    // ålder på venus
                    case "2":
                        skrivPlanetMeny();
                        ålder = readDouble();
                        Console.WriteLine($"Din ålder på venus är {ålder / 0.61519726}");
                        break;

                    // ålder på mars
                    case "3":
                        skrivPlanetMeny();
                        ålder = readDouble();
                        Console.WriteLine($"Din ålder på mars är {ålder / 1.8808158}");
                        break;

                    // ålder på jupiter
                    case "4":
                        skrivPlanetMeny();
                        ålder = readDouble();
                        Console.WriteLine($"Din ålder på jupiter är {ålder / 11.862615}");
                        break;

                    // ålder på saturnus
                    case "5":
                        skrivPlanetMeny();
                        ålder = readDouble();
                        Console.WriteLine($"Din ålder på saturnus är {ålder / 29.447498}");
                        break;

                    // ålder på uranus
                    case "6":
                        skrivPlanetMeny();
                        ålder = readDouble();
                        Console.WriteLine($"Din ålder på uranus är {ålder / 84.016846}");
                        break;

                    // ålder på neptunus
                    case "7":
                        skrivPlanetMeny();
                        ålder = readDouble();
                        Console.WriteLine($"Din ålder på neptunus är {ålder / 164.79132}");
                        break;

                    // hejdå meddelande
                    case "8":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Hejdå!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }

            }
        }
        /// <summary>
        /// skriver ut huvudmenyn
        /// </summary>
        static void skrivHuvudMeny()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Välj en planet att jämföra med jordår");

            Console.WriteLine("1. Mekurius");
            Console.WriteLine("2. Venus");
            Console.WriteLine("3. Mars");
            Console.WriteLine("4. Jupiter");
            Console.WriteLine("5. Saturnus");
            Console.WriteLine("6. Uranus");
            Console.WriteLine("7. Neptunus");
            Console.WriteLine("8. Avsluta");
        }
        /// <summary>
        /// skriver ut texten för att få användaren att mata in ett år
        /// </summary>
        static void skrivPlanetMeny()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Skriv din ålder i jordår");
        }

        /// <summary>
        /// kontrollerar användarens ålder 
        /// </summary>
        /// <returns>användarens ålder kontrollerad</returns>
        static double readDouble()
        {
            double svar = 0;
            while (!double.TryParse(Console.ReadLine(), out svar))   // ! == false
            {
                Console.WriteLine("error, skriv in en giltig ålder");

            }
            return svar;
        }
    }
}

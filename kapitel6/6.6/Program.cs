using System;

namespace _6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            while (svar != "3")
            {
                huvudMeny();
                svar = Console.ReadLine();

                switch (svar)
                {
                    case "1":
                        multiplicera();
                        break;

                    case "2":
                        dividera();
                        break;

                    case "3":
                        Console.WriteLine("hejdå");
                        break;

                    default:
                        break;
                }
            }

        }
        static void huvudMeny()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. multiplicera");
            Console.WriteLine("2. dividera");
            Console.WriteLine("3. avlsuta");

        }
        static void multiplicera()
        {
            Console.WriteLine("skriv tal 1");
            double tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv tal 2");
            double tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"svaret är {tal1 * tal2}");

        }
        static void dividera()
        {
            Console.WriteLine("skriv tal 1");
            double tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv tal 2");
            double tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"svaret är {tal1 / tal2}");

        }
    }
}

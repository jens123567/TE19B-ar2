using System;

namespace exempel2
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            while (svar != "3")
            {
            skrivMeny();
            svar = Console.ReadLine();

            switch (svar)
            {
                case "1":
                addera();
                break;

                case "2":
                subtrahera();
                break;

                case "3":
                Console.WriteLine("hejdå");
                break;

                default:
                break;
            }
            }
        }
        static void skrivMeny()
        {   
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. addera");
            Console.WriteLine("2. subtrahera");
            Console.WriteLine("3. avlsuta");

        }
        static void addera()
        {   
            Console.WriteLine("skriv tal 1");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv tal 2");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"svaret är {tal1+tal2}");

        }
        static void subtrahera()
        {   
            Console.WriteLine("skriv tal 1");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv tal 2");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"svaret är {tal1-tal2}");

        }
    }
}

using System;

namespace exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarera val
            string val = "";

            //presntera en meny tills användaren säger stopp
            while (val != "3")
            {
                Console.WriteLine("välj något av följande:");
                Console.WriteLine("1. multiplicera dig själv");
                Console.WriteLine("2. multiplicera två tal");
                Console.WriteLine("3. multiplicera två bilar");

                val = Console.ReadLine();

                //om val 1
                if (val == "1")
                {
                    Console.WriteLine("rätt men fel");
                }
                //om val 2
                if (val == "2")
                {
                    Console.WriteLine("bara fel");
                }
                //om val 3
                if (val == "3")
                {
                    Console.WriteLine("nu blev det rätt");
                }
                //annars
                if (val != "1" || val != "2" || val != "3")
                {
                    Console.WriteLine("gör om gör rätt");
                }

            }
        }
    }
}

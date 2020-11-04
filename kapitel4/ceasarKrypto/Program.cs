using System;

namespace ceasarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            //ange en text
            Console.Write("ange en text:");
            string text = Console.ReadLine();

            //loopa igenom inmatad text bokstav för bokstav
            int textLängd = text.Length;
            Console.WriteLine($"Texten är {textLängd} tecken lång");

            //be användareb om nyckel
            Console.WriteLine("ange en nyckel (1-9): ");
            string nyckelString = Console.ReadLine();

            //säkerställa att vi får in ett tal
            int nyckel = 0;

            while (!int.TryParse(nyckelString, out nyckel))

            {
                Console.WriteLine("du gjorde fel! ange en nyckel (1-9): ");
                nyckelString = Console.ReadLine();
            }

            //loopa igenom bokstav för bokstav
            string krypteradText = "";
            for (int i = 0; i < textLängd; i++)
            {
                /*Console.WriteLine($"loop nr {i}");*/

                //plocka ut bokstav på postition i
                char bokstav = text[i];
                Console.WriteLine($"Bokstaven på position {i} är {bokstav}");

                //ASCII-värdet för ett tecken
                int ascii = (int)bokstav;
                Console.WriteLine($"bokstaven {bokstav} har ACII-värdet {ascii}");

                //ceasar kryptering
                ascii += nyckel;

                //plock ut motsvarande tecken enligt ascii
                char krypteradBokstav = (char)ascii;
                Console.WriteLine($"bokstaven {bokstav} krypteras till {krypteradBokstav} ");


                //samla ihop bokstäver
                krypteradText += krypteradBokstav.ToString();
            }
            //skriv ut krypterade texten
            Console.WriteLine($"texten {text} har krypterats till {krypteradText}");
        }
    }
}

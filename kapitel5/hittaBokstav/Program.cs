using System;

namespace hittaBokstav
{
    class Program
    {
        static void Main(string[] args)
        {
            //ange en bokstav
            Console.WriteLine("ange en bokstav");
            string bokstav = Console.ReadLine().ToUpper();

            //skapa en samling för alfabetet
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";

            //hitta bokstavens plats i alfabetet
            int index = alfabetet.IndexOf(bokstav);

            //Vart fanns bokstaven
            Console.WriteLine($"{bokstav} finns på position {index}");

            //skapa en samling för morse koden
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };

            //skriv ut morse koden för bokstaven


            Console.WriteLine($"{bokstav} är {morse[index]} i morse");
        }
    }
}

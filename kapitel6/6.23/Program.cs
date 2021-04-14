using System;

namespace _6._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett meddelande");
            string meddelande = Console.ReadLine();

            Console.WriteLine(VarannanStor(meddelande));
            Console.WriteLine(GörFörstaBokstavStor(meddelande));
        }

        static string VarannanStor(string texten)
        {

            texten = texten.ToLower();
            //Dela upp texten vid mellanslagen
            string[] orden = texten.Split(' ');

            //loopa igenom texten och gör vart annat ord stort
            for (int i = 0; i < orden.Length; i += 2)
            {
                orden[i] = orden[i].ToUpper();
            }

            return string.Join(" ", orden);
        }

        static string GörFörstaBokstavStor(string texten)
        {
            string[] orden = texten.Split(' ');

            for (int i = 0; i < orden.Length; i++)
            {
                string ord = orden[i];
                string firstLetter = ord.Substring(0, 1).ToUpper();
                string restOfWord = ord.Substring(1).ToLower();
                orden[i] = firstLetter + restOfWord;
            }

            return string.Join(" ", orden);
        }
    }
}

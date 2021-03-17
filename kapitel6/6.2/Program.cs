using System;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivBaklänges("hallå");
            SkrivBaklänges("funkar finemang");
            SkrivBaklänges("hej karim");
        }
        static void SkrivBaklänges(string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.Write(meddelande[i]);
            }
        }
    }
}

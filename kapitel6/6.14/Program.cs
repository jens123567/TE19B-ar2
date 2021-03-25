using System;

namespace _6._14
{
    class Program
    {
        static Random slump = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine(slumpaPosition());
        }

        static int SlumpaRad()
        {
            return slump.Next(1, 9);
        }
        static char SlumpaKolumn()
        {
            string kolumner = "abcdefgh";
            int slumpPos = slump.Next(1, kolumner.Length);
            return kolumner[slumpPos];
        }

        static string slumpaPosition()
        {
            string position = SlumpaKolumn().ToString() + SlumpaRad();
            return position;
        }
    }
}

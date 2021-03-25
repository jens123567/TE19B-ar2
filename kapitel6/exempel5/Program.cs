using System;

namespace exempel5
{
    class Program
    {
        static string respons = "Du skrev inte ett heltal, vg försök igen";

        static Random slump = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("ange ett heltal");
            int tal = ReadInt();
        }
        /// <summary>
        /// Metoden för säkert sätt att läsa in heltal
        /// </summary>
        /// <returns>Heltalet</returns>
        static int ReadInt()
        {
            int svar = 0;
            while (!int.TryParse(Console.ReadLine(), out svar))   // ! == false
            {
                Console.WriteLine(respons);
            }
            return svar;
        }
    }
}

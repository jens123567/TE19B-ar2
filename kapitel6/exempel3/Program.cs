using System;

namespace exempel3
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = Summera(99, 123);

            string omvändText = vändText("Programmering");
        }
        /// <summary>
        /// Summera summerar två heltal
        /// </summary>
        /// <param name="x">tal nummer 1</param>
        /// <param name="y">tal nummer 2</param>
        /// <returns>summan</returns>

        static int Summera(int x, int y)
        {
            int z = x + y;
            return z;
        }
        /// <summary>
        /// vänder text
        /// </summary>
        /// <param name="x">texten som ska vändas</param>
        /// <returns>vänd text</returns>
        static string vändText(string x)
        {

        }
    }
}

using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer = "";

            while (answer != "china")
            {
                Console.WriteLine("which is the most populus country in the world");

                answer = Console.ReadLine();

                if (answer == "china")
                {
                    Console.WriteLine("rätt");
                }
                else
                {
                    Console.WriteLine("fel försök igen");
                }
            }
        }
    }
}

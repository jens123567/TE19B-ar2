using System;

namespace konsolen
{
    class Program
    {
        static void Main(string[] args)
        {
            //change backgorund color of terminal
            Console.BackgroundColor = ConsoleColor.Blue;
            //change text color of terminal
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello World!");
        }
    }
}

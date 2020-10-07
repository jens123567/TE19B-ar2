using System;

namespace projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int switchIndex = 0;
            switch (game)
            {
                case "0":
                    Console.WriteLine("Watcha doing?");
                    Console.WriteLine("want to help me out with something?");
                    string answer1 = Console.ReadLine();
                    if (answer1 == yes || answer1 == Yes)
                    {
                        switchIndex = 1;
                    }
                    else if (answer1 == no)
                    {
                        switchIndex = 2;
                    }
                    break;
                case "1":
                    System.Console.WriteLine("So I have this problem, this guy wants to murder me and you have to kill him");
                    break;
                case "2":
                    Console.WriteLine("ok then, thanks for nothing NERD!");
                    break;
                default:
                    Console.WriteLine("something went wrong");
                    break;
            }


        }
    }
}

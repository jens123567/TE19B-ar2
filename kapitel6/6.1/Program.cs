using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivTalKvadrat(3);
            SkrivTalKvadrat(5);
            SkrivTalKvadrat(9);


        }
        static void SkrivTalKvadrat(int tal)
        {
            Console.WriteLine($"Talet {tal} är i kvadrat {tal * tal}");
        }
    }
}

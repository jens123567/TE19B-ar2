using System;

namespace upgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarera variabler
            string name = "";
            int age = 0;
            int age2025 = 0;
            double height = 0;
            string message = "";

            //läs in namn
            Console.Write("vad heter du?");
            name = Console.ReadLine();

            Console.Write("hur lång är du");
            height = double.Parse(Console.ReadLine());

            Console.Write("hur gammal är du?");
            age = int.Parse(Console.ReadLine());

            //hur gammal är användaren 2020
            age2025 = age + 5;

            message = "hej " + name + " du är " + age2025 + " år gammal 2025 och är " + height + " meter lång";


            Console.WriteLine(message);
        }
    }
}

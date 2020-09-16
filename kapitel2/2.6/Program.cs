using System;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {

            double number1;
            double number2;
            double message;

            Console.Write("SKRIV FÖRSTA TALET");
            number1 = double.Parse(Console.ReadLine());

            Console.Write("NU ÄR DET DAGS FÖR TAL TVÅ");
            number2 = double.Parse(Console.ReadLine());

            message = (number1 + number2) / 2;


            Console.WriteLine(message);

        }
    }
}

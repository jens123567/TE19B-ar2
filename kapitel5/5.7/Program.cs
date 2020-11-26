using System;

namespace _5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in 5 tal, följ varje tal med ett enter");
            int[] talen = new int[5];

            for (int i = 0; i < talen.Length; i++)
            {
                talen[i] = int.Parse(Console.ReadLine());
            }

            int summa = 0;

            foreach (int tal in talen)
            {
                summa += tal;
            }
            Console.WriteLine(summa);
        }
    }
}

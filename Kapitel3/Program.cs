using System;
using System.Collections.Generic;

namespace Exempel1
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in ålder
            Console.WriteLine("hur gammal är du? (svara i hela antal år avrundat nedåt)");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("du är gammal");
            }

            //om ålder under 18
            if (age <= 17)
            {
                Console.WriteLine("du är ung");
            }

            // vem är statsminister
            Console.WriteLine("vem var statsminister i sverige 1970");
            string PM = Console.ReadLine();
            List<string> validAnswers = new List<string>();
            foreach (string validAnswer in new string[]{
                "palme",
                "olof palme",

            }) { validAnswers.Add(validAnswer); }
            if (validAnswers.Contains(PM))
            {
                Console.WriteLine("rätt svar");
            }
            else
            {
                Console.WriteLine("FEL");
            }
        }
    }
}

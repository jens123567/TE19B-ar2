using System;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en mening (utan punkt) som består av tre ord");
            string mening = Console.ReadLine();
            int spaceindex = mening.IndexOf(" ");
            int spaceindex2 = mening.IndexOf(" ", spaceindex + 1);
            string ord1 = mening.Substring(0, spaceindex);
            string ord2 = mening.Substring(spaceindex, spaceindex2);
            string ord3 = mening.Substring(spaceindex2 + 1);
            string msg = ord3 + " " + ord2 + " " + ord1 + "\n" + ord2 + " " + spaceindex + " " + spaceindex2;


            Console.WriteLine(msg);
        }
    }
}

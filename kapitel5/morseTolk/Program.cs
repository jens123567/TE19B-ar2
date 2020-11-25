using System;

namespace morseTolk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berätta om programet
            //be om ett meddelande
            Console.WriteLine("Programmet översätter din text till morse, mata in ett ord");
            string meddelande = Console.ReadLine().ToUpper();

            string morseMeddelande = "";

            //skapa en samling för alfabetet
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";

            //skapa en samling för morse koden
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " /" };

            //loopa igenom meddelandet 
            for (int i = 0; i < meddelande.Length; i++)
            {
                //skriv ut varje tecken
                string bokstav = meddelande[i].ToString();

                //hitta bokstavens plats i alfabetet
                int index = alfabetet.IndexOf(bokstav);

                //skriv ut morsekoden för bokstaven
                Console.WriteLine($"{bokstav} = {morse[index]} i morse");
                morseMeddelande += morse[index] + " ".ToString();
            }
            Console.WriteLine($"{meddelande} är {morseMeddelande} i morse");

        }
    }
}

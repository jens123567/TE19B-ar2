using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {
            //definerar variabler
            int brutto = 0;
            string input = "";
            double netto = 0;
            double skatt = 0;
            string tax = "";
            string yesno = "";
            string yesnolow = "";

            //loop som programmet körs i
            while (yesnolow != "nej")
            {
                //ta reda på brutto lön
                Console.WriteLine("Ange din bruttolön i heltal utan mellanrum");
                input = Console.ReadLine();

                //kontrollera så att svaret är endast siffror och omvandlar sedan till int
                if (int.TryParse(input, out brutto))
                {
                    //avgör procenten skatt
                    if (brutto <= 10000)
                    {
                        skatt = 0.92;
                        tax = "8%";
                    }
                    if (brutto >= 10000 && brutto <= 145000)
                    {
                        skatt = 0.78;
                        tax = "22%";
                    }
                    if (brutto >= 145000 && brutto <= 515000)
                    {
                        skatt = 0.67;
                        tax = "33%";
                    }
                    if (brutto >= 515000)
                    {
                        skatt = 0.47;
                        tax = "53%";
                    }

                    //räkna ut nettolön
                    netto = brutto * skatt;

                    //skriva vad användaren måste betala i skatt och dess lön
                    Console.WriteLine("Din lön är " + netto + " och din skatt är " + tax);

                    //fråga om användaren vill köra igen
                    Console.WriteLine("vill du använda räknaren igen? ja/nej");
                    yesno = Console.ReadLine();

                    //omvandla svar till lowercase så att hur man skriver in svar inte spelar roll
                    yesnolow = yesno.ToLower();
                }
                else
                {
                    Console.WriteLine("Det måste vara ett heltal utan mellanrum eller andra tecken");
                }


            }
        }
    }
}

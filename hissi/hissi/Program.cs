using System;

namespace Vahvistin
{
    class Program
    {
        static void Main(string[] args)
        {
            int uusiVoimakkuus;

            Console.WriteLine("Hissi..");
            vahvistin vahvistin = new vahvistin();
            Console.WriteLine("Hissi on tullut 'Sammuta' ");

            while (true)
            {
                Console.WriteLine("Anna uusi kerros (1-6) > ");
                string LuettuArvo = Console.ReadLine();

                if (LuettuArvo.Equals("Sammuta"))
                {
                    break; //Poistutaan loopista

                }

                bool result = int.TryParse(LuettuArvo, out uusiVoimakkuus);

                if (result)
                {
                    vahvistin.Äänenvoimakkuus1 = int.Parse(LuettuArvo);
                }
                else
                {
                    Console.WriteLine("Error: Annettu arvo on virheellinen: Mikäli haluat sammuttaa hissin kirjoita: Sammuta");

                }
            }

            Console.WriteLine("hissi on sammutettu");
        }
    }
}
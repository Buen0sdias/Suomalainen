using System;

namespace Vahvistin
{
    class Program
    {
        static void Main(string[] args)
        {
            int uusiVoimakkuus;

            Console.WriteLine("Luodaan uusi vahvistin..");
            vahvistin vahvistin = new vahvistin();
            Console.WriteLine("Uusi vahvistin luotu, poistu kirjoittamalla 'Sammuta' ");

            while(true)
            {
                Console.WriteLine("Anna uusi äänenvoimakkuus vahvistimelle (0-100) > ");
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
                    Console.WriteLine("Error: Annettu arvo on virheellinen: Mikäli haluat sammuttaa vahvistimen kirjoita: Sammuta");

                }
            }

            Console.WriteLine("vahvistin on sammutettu");
        }
    }
}

using System;
using System.Collections.Generic;

namespace Harjoitus13
{
    class Program
    {
        static public string Nimi { get; set; }
        static public int PelaajanNum { get; set; }
        static public string Kotikaupunki { get; set; }

        public static Dictionary<int, Pelaaja> pelaajat = new Dictionary<int, Pelaaja>();





        static void Main(string[] args)
        {
            string syöte;

            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("1. Lisää - Lisää pelaajan kokoelmaan");
                Console.WriteLine("2. Poista - Poistaa pelaajaa kokoelmasta");
                Console.WriteLine("3. Tulosta - Tulostaa pelaajan kokoelman");
                Console.WriteLine("4. Poistu - Poistuu sovelluksesta");

                syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "Lisää":
                        LisääPelaaja();
                        break;
                    case "Poista":
                        PoistaPelaaja();
                        break;
                    case "Tulosta":
                        TulostaPelaaja();
                        break;
                    case "Poistu":
                        return;
                }
            }
        }

        private static void TulostaPelaaja()
        {
            Console.WriteLine("Pelaajan nimi on: {0}  ", Nimi);
            Console.WriteLine("Pelaajan numero on: {0}  ", PelaajanNum);
            Console.WriteLine("Pelaajan kotikaupunki on: {0}  ", Kotikaupunki);

        }

        static void LisääPelaaja()
        {


            while (true)
            {
                Console.WriteLine("Anna uudelle pelaajalle tiedot: ");
                Console.WriteLine("Etunimi: ");
                Nimi = Console.ReadLine();
                Console.WriteLine("PelaajanNumero: ");
                PelaajanNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kotikaupunki: ");
                Kotikaupunki = Console.ReadLine();



                if (pelaajat.ContainsKey(PelaajanNum))
                {
                    Console.WriteLine("Tämä pelaaja on jo löydetty kokoelmasta.");
                    continue;
                }
                else
                {
                    pelaajat.Add(PelaajanNum, new Pelaaja(Nimi, PelaajanNum, Kotikaupunki));
                    Console.WriteLine("Lisäättiin pelaaja tämän {0} numeron kanssa!", PelaajanNum);
                    break;
                }
            }
        }

        static void PoistaPelaaja()
        {
            Console.WriteLine("Anna pelaajan numeron, jonka haluat poistaa: ");
            int syöte = Convert.ToInt32(Console.ReadLine());

            if (pelaajat.ContainsKey(syöte))
            {
                pelaajat.Remove(syöte);
                Console.WriteLine("Pelaaja " + syöte + Nimi + "  on poistettu kokoelmasta.");

            }
            else
            {
                Console.WriteLine("Pelaajan numeroa " + syöte + " ei löydetty kokoelmasta");
            }

        }

        public static void TulostaPelaaja(Dictionary<int, Pelaaja> pelaajat)
        {
            foreach (Pelaaja pelaaja in pelaajat.Values)
            {
                Console.WriteLine("Pelaajan nimi:  " + pelaaja.Nimi + " Kotikaupunki:  " + pelaaja.Kotikaupunki + "Pelaajan numero:  " + pelaaja.PelaajanNum);
                Console.WriteLine("Kotikaupunki:  " + pelaaja.Kotikaupunki);
            }
        }
    }
}

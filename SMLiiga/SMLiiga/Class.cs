using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Pelaaja
    {
        public int PelaajanNum;
        public string Nimi;
        public string Kotikaupunki;
        public Pelaaja(string nimi, int pelaajanNum, string kotikaupunki)
        {
            Nimi = nimi;
            PelaajanNum = pelaajanNum;
            Kotikaupunki = kotikaupunki;
        }


        public void TulostaTiedot()
        {
            Console.WriteLine("Pelaajien nimet: {0} . Kotikaupunki: {1}. Opiskelija Numero: {2}", Nimi, Kotikaupunki, PelaajanNum);


        }
    }
}


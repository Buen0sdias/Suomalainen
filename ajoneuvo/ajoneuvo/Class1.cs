using System;
using System.Collections.Generic;
using System.Text;

namespace ajoneuvo
{
    class Ajoneuvo
    {
        public string Nimi { get; set; }

        public int Nopeus { get; set; }

        public int Renkaat { get; set; }

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo ");
            Console.WriteLine("--Nimi: " + Nimi);
            Console.WriteLine("--Nopeus:" + Nopeus);
            Console.WriteLine("--renkaat:" + Renkaat);

        }

        //public string ToString()
        //{

        //}


    }
}

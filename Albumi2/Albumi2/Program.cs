using System;
using System.Collections.Generic;

namespace Albumi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi Albumi1 = new Albumi;
            {
                Albumi1.Nimi = "Thiller";
                Albumi1.Artisti = "Mihail Jackson";
                Albumi1.Genre = "Pop";
                Albumi1.Hinta = "10e";
                Albumi1.Tulostakappaleet();
                Albumi1.Tulostakappaleet();
                string albumintiedot = Albumi1.ToString();

            }
            
            
        }
    }
}
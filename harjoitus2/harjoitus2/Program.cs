using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija2 = new Opiskelija("matti", "TVT1234", 0);

            opiskelija2.TulostaData();
            opiskelija2.MuokkaaOpintoPisteitä(5);
            opiskelija2.TulostaData();
        }
    }
}

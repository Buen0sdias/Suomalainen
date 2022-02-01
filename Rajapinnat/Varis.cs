using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinnat
{
    class Varis : Eläin, ICanFly
    {
        public float WingSize { get; set; }

        public Varis(string _nimi, float _WingSize)

        {
            nimi = _nimi;
            WingSize = _WingSize;
            
        }

        public void fly()
        {
            Console.WriteLine("{0} Lentää siipien koko on {1}", nimi, WingSize);
        }

        public override void MakeAsound()
        {
            Console.WriteLine("Kaakw Kaakw");
        }

    }
}


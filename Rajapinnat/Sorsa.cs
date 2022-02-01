using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinnat
{
    class Sorsa : Eläin, IcanSwim, ICanFly
    {
        public float SwimSpeed { get; set ; }
        public float WingSize { get ; set; }
        public int Swimspeed { get; }

        public Sorsa(string _nimi, float _wingsize, int _speed)
        {
            nimi = _nimi;
            WingSize = _wingsize;
            Swimspeed = _speed;
        }

        public void Varis(string _name, float _WingSize)
        {
            Console.WriteLine("{0} Lentää siipien koko on {1}", nimi, WingSize);
        }

        public override void MakeAsound()
        {
            Console.WriteLine("Kwaak Kwaak");
        }

        public void Swim()
        {
            Console.WriteLine("Sorsa {0} ui nopeudella {1}", nimi, SwimSpeed);
        }

        public void fly()
        {
            Console.WriteLine();
        }
    }
}

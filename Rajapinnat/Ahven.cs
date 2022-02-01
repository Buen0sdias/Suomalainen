using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinnat
{
    class Ahven : Eläin, IcanSwim
    {
 
        public float SwimSpeed { get ; set ; }
        public string Sound { get; set ; }
        public Ahven(string _nimi, float _speed, string _sound)
        {
            nimi = _nimi;
            Sound = _sound;
            SwimSpeed = _speed;
        }

        public override void MakeAsound()
        {
            Console.WriteLine("blurp");
        }

        public void Swim()
        {
            Console.WriteLine("Kala {0} ui nopeudella {1}", nimi, SwimSpeed);
        }
    }
}

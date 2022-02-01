using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinnat
{
    interface IcanSwim
    {
        public float SwimSpeed { get; set; }
        public void Swim();
    }
}

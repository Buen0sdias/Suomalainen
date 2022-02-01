using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinnat
{
    interface ICanFly
    {
        public float WingSize { get; set; }

        public void fly();

    }
}

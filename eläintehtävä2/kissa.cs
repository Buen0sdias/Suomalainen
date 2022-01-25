using System;
using System.Collections.Generic;
using System.Text;

namespace Tehävä6Eläin
{
    class Kissa : Eläin
    {
        private static int instanssit = 0;

        public Kissa()
        {

            instanssit++;

        }
        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissa luotu " + instanssit);
        }
        public override void Ääntele()
        {
            Console.WriteLine("Meeeeeeoow Meeeeeooow");
        }
    }
}

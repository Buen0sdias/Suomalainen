using System;
using System.Collections.Generic;
using System.Text;

namespace Tehävä6Eläin
{
    //eläimen aliluokka
    class Koira : Eläin
    {

        private static int instanssit = 0;

        public Koira()
        {

            instanssit++;

        }
        public static new void KuinkaMonta()
        {

            Console.WriteLine("Koira luotu " + instanssit);
        }

        public override void Ääntele()
        {

            Console.WriteLine("Wufffff wuuuuffff");

        }
    }
}
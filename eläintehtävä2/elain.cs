using System;
using System.Collections.Generic;
using System.Text;

namespace Tehävä6Eläin
{
    class Eläin
    {
        public string Nimi { get; set; }
        private static int instanssit = 0;

        public Eläin()
        {
            instanssit++;
        }
        public static void KuinkaMonta()
        {
            Console.WriteLine(" Eläimiä luotu " + instanssit);
        }
        public virtual void Ääntele()
        {
            Console.WriteLine("Eläin ääntelee");
        }

    }
}
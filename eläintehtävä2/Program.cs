using System;

namespace Tehävä6Eläin
{
    class Program
    {
        static void Main(string[] args)
        {
            Eläin.KuinkaMonta();

            Koira koira1 = new Koira();
            koira1.Ääntele();

            Kissa kissa1 = new Kissa();
            kissa1.Ääntele();

            Koira.KuinkaMonta();

            Koira koira2 = new Koira();
            Koira koira3 = new Koira();

            Kissa kissa2 = new Kissa();

            Eläin.KuinkaMonta();
            Kissa.KuinkaMonta();
            Eläin.KuinkaMonta();



        }
    }
}
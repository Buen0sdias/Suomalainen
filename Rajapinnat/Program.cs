using Rajapinnat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void Main(string[] args)
    {
        Varis varis = new Varis("Varis", 90);

        varis.MakeAsound();
        varis.fly();

        Ahven ahven = new Ahven("ahven", 50, "blups");

        ahven.MakeAsound();
        ahven.Swim();
        Console.ReadLine();

        Sorsa sorsa = new Sorsa("Sorsa", 90, 10 );

        sorsa.MakeAsound();
        sorsa.Swim();
        sorsa.MakeAsound();


    }
}

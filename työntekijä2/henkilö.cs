using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Henkilo : Tyontekija
{


    private static int instanssit = 0;
    private static int tunnit;
    private static int palkka;
    private static string nimi;
    public Henkilo(int _tunnit, int _palkka, string _nimi)

    {
        instanssit++;
        tunnit = _tunnit;
        palkka = _palkka;
        nimi = _nimi;
    }



    public static new void KuinkaMonta()
    {

    }



    public override void Ääntele()
    {

        Console.WriteLine("Työntekijän nimi on: {0}.", nimi);
        Console.WriteLine("Pekka tekee noin {0} tuntia töitä viikossa", tunnit);
        Console.WriteLine("Työntekijän palkka: {0} euroa/kk ", palkka);
        Console.WriteLine("Paina enter jatkaaksesi.");
        Console.ReadLine();
    }
}

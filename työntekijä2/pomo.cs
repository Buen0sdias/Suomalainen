using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Pomo : Tyontekija
{
    private static int instanssit = 0;
    private static int tunnit;
    private static int palkka;
    private static string nimi;
    private static string auto;
    private static int bonus;




    public Pomo(int _tunnit, int _palkka, string _nimi, string _auto, int _bonus)



    {
        instanssit++;
        tunnit = _tunnit;
        palkka = _palkka;
        nimi = _nimi;
        auto = _auto;
        bonus = _bonus;
    }



    public static new void KuinkaMonta()
    {
        Console.WriteLine("Pomon nimi on: {0}.", nimi);
        Console.WriteLine("Pomo tekee noin {0} tuntia töitä viikossa", tunnit);
        Console.WriteLine("Pomon palkka: {0} euroa/kk ", palkka);
        Console.WriteLine("Pomon auto on: {0} ", auto);
        Console.WriteLine("Pomon bonus on: {0} euroa kuukaudessa. ", bonus);
        Console.WriteLine("Paina enter Lopettaakseksi.");
        Console.ReadLine();
    }
}

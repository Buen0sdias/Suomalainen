using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
class Tyontekija
    {
public string Nimi { get; set; }
    public Tyontekija()
    {
    }
    public static void KuinkaMonta()
    {
    }
    public virtual void Ääntele()
    {
        Console.WriteLine("Eläin Ääntelee");
    }
}
}


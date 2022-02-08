using korttipakka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Korttipakka
{
    public Dictionary<string, Kortti> Pakka = new Dictionary<string, Kortti>();

    public Korttipakka()
    {
        Lisääpakka();
    }
    public void Lisääpakka()
    {
        int pata = 1;
        int risti = 1;
        int ruutu = 1;
        int hertta = 1;
        for (int i = 1; i < 52; i++)
        {
            while (hertta < 13)
            {
                Pakka.Add("Hertta " + hertta, new Kortti());
                hertta++;
            }
            while (risti < 13)
            {
                Pakka.Add("Risti " + risti, new Kortti());
                risti++;

            }
            while (ruutu < 13)
            {
                Pakka.Add("Ruutu " + ruutu, new Kortti());
                ruutu++;

            }
            while (pata < 13)
            {
                Pakka.Add("Pata " + pata, new Kortti());
                pata++;

            }
        }

    }
    public void Tulosta()
    {
        foreach (var k in Pakka.Keys)
        {
            Console.WriteLine("{0}", k);
        }
    }

    public void Sekota()
    {
        Shuffle();
        Console.WriteLine("Korttipakka on sekoitettu ");
        Console.WriteLine();



    }
    public void Shuffle()
    {
        int Luku = 1;
        Random rand = new Random();
        var random = Pakka.OrderBy(item => rand.Next());
        foreach (var value in random)
        {
            Console.WriteLine("{0}. Kortti on; " + value.Key, Luku);
            Luku++;
        }
    }




     








}
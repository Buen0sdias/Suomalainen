using System;

namespace harvia1
{
    class Program
    {
        static void Main(string[] args)
        {
            kiuas kiuas1 = new Kiuas("Harvia", 0);



            kiuas1.onOFF();




            kiuas1.MuokkaaKosteutta(10);
            kiuas1.MuokkaaLämpötilaa(120);
            kiuas1.Tulostadata();
            kiuas1.onOFF();







        }
    }
}

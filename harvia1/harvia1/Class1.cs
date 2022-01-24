using System;
using System.Collections.Generic;
using System.Text;

namespace harvia1

{
    class Kiuas
    {
        private string v1;
        private int v2;

        private string Kiuas1 { get; set; }
        string kiukaantila;
        private int Kosteus { get; set; }
        private int Lämpötila { get; set; }
        public Kiuas(int Kosteus, int Lämpötila, string Kiuas1, string kiukaantila)
        {
            this.Kiuas1 = Kiuas1;
            this.Kosteus = Kosteus;
            this.Lämpötila = Lämpötila;
            this.kiukaantila = kiukaantila;
        }

        public Kiuas(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        public void onOFF()
        {
            Console.WriteLine("Kiuas ON=k OFF=e");
            kiukaantila = Console.ReadLine();
            if (kiukaantila == "k")
            {
                Console.WriteLine("Kiuas on päällä.");
                Tulostadata();

            }
            else
            {
                Console.WriteLine("Kiuas on pois päältä");
            }
        }
        public void Tulostadata()
        {

            if (kiukaantila == "k")
            {
                Console.WriteLine("Ilman kosteus on: " + Kosteus);
                Console.WriteLine("Saunan lämpötila on: " + Lämpötila);
                Console.WriteLine("");
            }






        }
        public void MuokkaaKosteutta(int i)
        {
            Kosteus += i;
            if (Kosteus < 0)
            {
                Kosteus = 0;
            }
        }
        public void MuokkaaLämpötilaa(int i)
        {
            Lämpötila += i;
            if (Lämpötila < 0)
            {
                Lämpötila = 0;
            }
        }
    }
}
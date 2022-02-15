namespace Radio56
{
    class Radio
    {
        public Radio(string _nimi, bool _on, int _ääni, decimal _taajuus) 
        {
            Nimi = _nimi;
            Päällä = _on;
            Äänenvoimakkuus = _ääni;
            taajuus = _taajuus;
        }



        public string Nimi;
        bool Päällä;
        private readonly int ÄänenVoimaMax = 9;

        private readonly int ÄänenVoimaMin = 0;

        private readonly decimal MaxTaajuus = 107.9M; 

        private readonly decimal MinTaajuus = 88.0M;

        private decimal taajuus { get; set; }
        private int äänenvoimakkuus { get; set; }
        public decimal Taajuus 
        {
            get { return taajuus; } 
            set
            {
                if (value > MaxTaajuus) 
                {
                    value = MaxTaajuus;
                }
                else if (value < MinTaajuus) 
                {
                    value = MinTaajuus;
                }
                taajuus = value;
            }
        }



        public int Äänenvoimakkuus
        {
            get { return äänenvoimakkuus; }
            set
            {
                if (value > ÄänenVoimaMax)
                {
                    value = ÄänenVoimaMax;
                }
                else
                if (value < ÄänenVoimaMin)
                {
                    value = ÄänenVoimaMin;
                }
                äänenvoimakkuus = value;
            }
        }
        public void AsetaKerros()
        {
            Taajuus = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Olet kerroksessa: " + Taajuus.ToString());
        }



        public void TulostaData()
        {
            Console.WriteLine("Radio: ");
            Console.WriteLine("-- Nimi: " + Nimi);
            if (Päällä == true)
            {
                Console.WriteLine("-- Radion tila Päällä ");
            }
            else
            {
                Console.WriteLine("-- Radio tila: Pois Päältä ");
            }
            Console.WriteLine("-- Taajuus: " + Taajuus);

            Console.WriteLine("-- Äänenvoimakkuus: " + Äänenvoimakkuus);

            Console.WriteLine("Käynnistä/Sammuta radio, Paina k");

            Console.WriteLine("Nosta taajuutta paina n, laske taajuutta paina l");

            Console.WriteLine("Nosta äänenvoimakkuutta paina w, laske äänenvoimakkuutta paina s");

            Console.Write("Poistu radion luota, anna p: ");

            Console.WriteLine();
        }



        public void onoff() 
        {
            if (Päällä != true)
            {
                Päällä = true;
            }
            else
            {
                Päällä = false;
            }
        }
        public void NostaÄänenVoimakkuutta(int i) 
        {
            if (Päällä != false) 
            {
                Äänenvoimakkuus = Äänenvoimakkuus + i;
            }
            else 
            {
                Console.WriteLine("Radio ei ole päällä");
                Console.Beep();
            }
        }
        public void LaskeÄänenVoimakkuutta(int i)
        {
            if (Päällä != false)
            {
                Äänenvoimakkuus = Äänenvoimakkuus - i;
            }
            else
            {
                Console.WriteLine("Radio ei ole päällä");
                Console.Beep();
            }
        }
        public void NostaTaajuutta(decimal i)
        {
            if (Päällä != false)
            {
                Taajuus = Taajuus + i;
            }
            else
            {
                Console.WriteLine("Radio ei ole päällä");
                Console.Beep();
            }
        }
        public void LaskeTaajuutta(decimal i)
        {
            if (Päällä != false)
            {
                Taajuus = Taajuus - i;
            }
            else
            {
                Console.WriteLine("Radio ei ole päällä");
                Console.Beep();
            }
        }



    }
}
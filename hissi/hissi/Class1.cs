using System;
using System.Collections.Generic;
using System.Text;

namespace Vahvistin
{
    class vahvistin
    {
        private int äänenvoimakkuus;


        public int Äänenvoimakkuus1
        {
            get => äänenvoimakkuus;
            set
            {
                if (value > 6)
                {
                    Console.WriteLine("Error virheellinen kerros!");
                    value = 6;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Anna uusi kerros");
                    value = 0;
                }

                Console.WriteLine("Hissi on nyt kerroksessa " + value);

                äänenvoimakkuus = value;
            }

        }
    }
}


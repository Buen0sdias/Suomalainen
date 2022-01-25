using System;
using System.Collections.Generic;
using System.Text;

namespace Vahvistin
{
    class vahvistin
    {
        private int äänenvoimakkuus;

           
        public int Äänenvoimakkuus1 { 
         get => äänenvoimakkuus;
            set
            {
                if ( value > 100)
                {
                    Console.WriteLine("Annettu arvo oli yli 100");
                    value = 100;
                } else if (value < 0)
                {
                    Console.WriteLine("Annettu arvo oli pienempi kuin 0");
                    value = 0;
                }

                Console.WriteLine("Äänenvoimakkuus asetettu " + value);

                äänenvoimakkuus = value;
            }
            
        }
    }
}

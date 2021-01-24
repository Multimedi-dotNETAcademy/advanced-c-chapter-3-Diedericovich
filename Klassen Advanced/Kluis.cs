using System;
using System.Collections.Generic;
using System.Text;

namespace Klassen_Advanced
{
    class Kluis
    {
        private int aantalPogingen; 
           
        public int AantalPogingen
        {
            get { return aantalPogingen; }
            set { aantalPogingen = value; }
        }

        private bool canShowCode = false;

        public bool CanShowCode
        {
            get { return canShowCode; }
            set { canShowCode = value; }
        }

        private int code;

        public int Code
        {
            get 
            {
                if (canShowCode == true)
                {
                    return code;
                }
                else
                {
                    return -666;
                }                
            }            
        }
      
        public int CodeLevel
        {
            get { return code / 1000; }
        }

        public Kluis(int getal)
        {
            code = getal;
        }

        public Kluis()
        {

        }

        public bool TryCode(int getal)
        {          

            if (getal == code)
            {
                Console.WriteLine($"De code {getal} is geldig");
                Console.WriteLine($"{aantalPogingen} pogingen");
                return true;
            }
            else if (getal == -666)
            {
                Console.WriteLine("U bent een CHEATER!");
                aantalPogingen++;

                return false;
            }
            else
            {               
                Console.WriteLine("De code is niet geldig");
                aantalPogingen++;
                return false;
            }
        }



    }
}

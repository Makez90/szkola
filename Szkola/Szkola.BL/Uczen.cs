using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola.BL
{
    public class Uczen
    {
        public Uczen()
        {

        }
        public Uczen(Klasa klasa)
        {
            klasa.LiczbaUczniow++;
            NumerUczniaWKlasie = klasa.LiczbaUczniow;
        }
        public int NumerUczniaWKlasie { get; private set; }
        public string NazwaKlasy { get; set; }
        public string ImieUcznia { get; set; }
        
    }
}

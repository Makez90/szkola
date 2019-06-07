using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola.BL
{
    public class KlasaRepository
    {
        /// <summary>
        /// Pobieramy klase
        /// </summary>
        /// <param name="nazwaKlasy"></param>
        /// <returns></returns>
        public Klasa Pobierz(string nazwaKlasy)
        {
            Klasa klasa = new Klasa("2A");
            //kod który pobiera klase
            //tymczasowo zakodowane wartosci
            if (nazwaKlasy == "2A")
            {
                klasa.NazwaKlasy = nazwaKlasy;
                klasa.LiczbaNauczycieliWKlasie = 3;
            }
            return klasa;
        }
    }
}

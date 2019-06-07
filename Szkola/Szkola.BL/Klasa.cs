using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola.BL
{
    public class Klasa
    {
        #region konstruktory
        public Klasa(string nazwaKlasy)
        {
            NazwaKlasy = nazwaKlasy;
            CzyKlasaToUnikat = DodajUnikatowaKlaseDoListy();
            LiczbaUczniow = 0;
        }
        #endregion

        #region wlasciwosci
        public bool CzyKlasaToUnikat { get; private set; }
        public static List<string> ListaKlas { get; set; }
        public int LiczbaUczniow { get; set; }

        private string _NazwaKlasy;

        public string NazwaKlasy
        {
            get
            {
                return _NazwaKlasy;
            }
            set
            {
                _NazwaKlasy = value.ToUpper();
            }
        }


        public int LiczbaNauczycieliWKlasie { get; set; }

        #endregion

        #region metody
        private bool DodajUnikatowaKlaseDoListy()
        {
            var nieMaNaLiscie = true;
            
            if (!ListaKlas.Contains(_NazwaKlasy))
            {
                ListaKlas.Add(_NazwaKlasy);
                nieMaNaLiscie = true;
            }
            else
            {
                Console.WriteLine("Taka Nazwa Klasy już istnieje podaj inną nazwę klasy");
                nieMaNaLiscie = false;
            }

            return nieMaNaLiscie;
        }
        #endregion

    }
}

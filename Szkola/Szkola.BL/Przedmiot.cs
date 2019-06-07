
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola.BL
{
    public class Przedmiot : KlasaBazowa
    {
        #region konstruktory
        public Przedmiot(int przedmiotId)
        {
            PrzedmiotId = przedmiotId;
        }
        #endregion

        #region wlasciwosci
        public static List<int> ListaPrzedmiotow {get; set;}
        public int PrzedmiotId { get; private set; }
        public int LiczbaLekcji { get; set; }
        public int LiczbaZadan { get; set; }

        private string _NazwaPrzedmiotu;

        public string NazwaPrzedmiotu
        {
            get {
                return _NazwaPrzedmiotu.ToUpper();
            }
            set { _NazwaPrzedmiotu = value.ToUpper(); }
        }
        #endregion


        #region metody

        /// <summary>
        /// Sprawdza Dane Przedmiotu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaPrzedmiotu))
                poprawne = false;
            if (LiczbaLekcji <= 0)
            {
                poprawne = false;
            }
            if (LiczbaZadan <= 0)
            {
                poprawne = false;
            }
            return poprawne;
        }


        /// <summary>
        /// Przypisz Przedmiot Do Nauczyciela
        /// </summary>
        /// <returns></returns>
        public static int WybranyPrzedmiotZListy(int wybranyPrzedmiotId)
        {
            var przedmiotId = 0;
            if (Przedmiot.ListaPrzedmiotow.Count > 0)
            {
                przedmiotId = Przedmiot.ListaPrzedmiotow[wybranyPrzedmiotId];
                Przedmiot.ListaPrzedmiotow.RemoveAt(wybranyPrzedmiotId);
            }
            return przedmiotId;
        }

        public string Log()
        {
            var log = PrzedmiotId + " " +
                NazwaPrzedmiotu + " " +
                "Liczba Lekcji: " + LiczbaLekcji + " " +
                "Liczba Zadan: " + LiczbaZadan;
            return log;
        }
        #endregion
    }
}

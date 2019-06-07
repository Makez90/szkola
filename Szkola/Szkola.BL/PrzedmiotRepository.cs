using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola.BL
{
    public class PrzedmiotRepository
    {
        #region metody

        /// <summary>
        /// Pobieramy przedmiot
        /// </summary>
        /// <param name="przedmiotId"></param>
        /// <returns></returns>
        public Przedmiot Pobierz(int przedmiotId )
        {
            Przedmiot przedmiot = new Przedmiot(przedmiotId);
            if (przedmiotId == 1)
            {
                przedmiot.NazwaPrzedmiotu = "Matematyka";
                przedmiot.LiczbaLekcji = 10;
                przedmiot.LiczbaZadan = 5;
            }
            else if(przedmiotId == 2)
            {
                przedmiot.NazwaPrzedmiotu = "Informatyka";
                przedmiot.LiczbaLekcji = 12;
                przedmiot.LiczbaZadan = 7;
            }
            return przedmiot;
        }
    #endregion
    }
}

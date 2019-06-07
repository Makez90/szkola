using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola.BL
{
    public class NauczycielRepository
    {
        #region metody

        /// <summary>
        /// Pobieramy Nauczyciela
        /// </summary>
        /// <param name="przedmiotId"></param>
        /// <returns></returns>
        public Nauczyciel Pobierz(int nauczycielId)
        {
            Nauczyciel nauczyciel = new Nauczyciel(nauczycielId);
            if (nauczycielId == 1)
            {
                nauczyciel.PrzedmiotId = 1;
            }
            else if (nauczycielId == 2)
            {
                nauczyciel.PrzedmiotId = 2;
            }
            return nauczyciel;
        }
        #endregion
    }
}

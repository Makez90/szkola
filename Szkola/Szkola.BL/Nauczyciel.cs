using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola.BL
{
    public class Nauczyciel
    {
        #region konstruktory
        public Nauczyciel()
        {

        }
        public Nauczyciel(int nauczycielId)
        {
            NauczycielId = nauczycielId;
        }

        #endregion

        #region wlasciwosci
        public int NauczycielId { get; private set; }
        public int PrzedmiotId { get; set; }
        #endregion

    }
}

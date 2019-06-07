using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola.BL
{
    public abstract class KlasaBazowa
    {
        public StanObiektuOpcje StanObiektu { get; set; }

        public bool DanePrawidlowe
        {
            get
            {
                return Zwaliduj();
            }
        }

        public abstract bool Zwaliduj();
    }
    public enum StanObiektuOpcje
    {
        Aktywny,
        Usuniety
    }
}
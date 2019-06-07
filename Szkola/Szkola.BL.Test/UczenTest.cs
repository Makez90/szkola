using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Szkola.BL;
using System.Collections.Generic;

namespace Szkola.BL.Test
{
    [TestClass]
    public class UczenTest
    {
        [TestMethod]
        public void DodajUczniaiPrzypiszDoKlasyTest()
        {
            //Arrange (przygotuj test)
            Klasa.ListaKlas = new List<string>();
            Klasa klasa = new Klasa("2A");
            klasa.NazwaKlasy = "2A";
            klasa.LiczbaNauczycieliWKlasie = 3;


            //Act (dzialaj)
            Uczen uczen1 = new Uczen(klasa);
            uczen1.ImieUcznia = "Jan";
            uczen1.NazwaKlasy = Klasa.ListaKlas[0];
            Uczen uczen2 = new Uczen(klasa);
            uczen2.ImieUcznia = "Jan";
            uczen2.NazwaKlasy = Klasa.ListaKlas[0];

            //Assert (potwierdz test)
            Assert.AreEqual(uczen1.NumerUczniaWKlasie, 1);
            Assert.AreEqual(uczen2.NumerUczniaWKlasie, 2);
        }
    }
}

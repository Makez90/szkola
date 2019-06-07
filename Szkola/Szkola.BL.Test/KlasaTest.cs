using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Szkola.BL.Test
{
    [TestClass]
    public class KlasaTest
    {
        [TestMethod]
        public void UnikatowaKlasaTest()
        {
            //Arrange (przygotuj test)
            Klasa.ListaKlas = new List<string>();
            Klasa klasa = new Klasa("2A");
            klasa.NazwaKlasy = "2A";
            klasa.LiczbaNauczycieliWKlasie = 3;
            var oczekiwana = true;

            //Act (dzialaj)
            oczekiwana = klasa.CzyKlasaToUnikat;

            //Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, true);
        }

        [TestMethod]
        public void NieUnikatowaKlasaTest()
        {
            //Arrange (przygotuj test)
            Klasa.ListaKlas = new List<string>();
            Klasa klasa = new Klasa("2A");
            klasa.LiczbaNauczycieliWKlasie = 3;
            Klasa klasa2 = new Klasa("2A");
            klasa2.NazwaKlasy = "2A";
            klasa2.LiczbaNauczycieliWKlasie = 4;
            var oczekiwana = true;

            //Act (dzialaj)
            var unikatowa = klasa.CzyKlasaToUnikat;
            oczekiwana = klasa2.CzyKlasaToUnikat;

            //Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, false);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Szkola.BL.Test
{
    [TestClass]
    public class PrzemiotTest
    {
        [TestMethod]
        public void SprawdzPrzedmiotTest()
        {
            //Arrange (przygotuj test)
            PrzedmiotRepository przedmiotRepository = new PrzedmiotRepository();
            Przedmiot przedmiot = new Przedmiot(1);
            przedmiot.NazwaPrzedmiotu = "Matematyka";
            przedmiot.LiczbaLekcji = 10;
            przedmiot.LiczbaZadan = 5;
            var oczekiwana = przedmiot;

            //Act (dzialaj)
            var aktualna = przedmiotRepository.Pobierz(1);
            //Assert (potwierdz test)
            Assert.AreEqual(oczekiwana.NazwaPrzedmiotu, aktualna.NazwaPrzedmiotu);
            Assert.AreEqual(oczekiwana.LiczbaLekcji, aktualna.LiczbaLekcji);
            Assert.AreEqual(oczekiwana.LiczbaZadan, aktualna.LiczbaZadan);
        }
    }
}

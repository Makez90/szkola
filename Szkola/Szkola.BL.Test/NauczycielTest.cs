using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Szkola.BL;
using System.Collections.Generic;

namespace Szkola.BL.Test
{
    [TestClass]
    public class NauczycielTest
    {
        [TestMethod]
        public void DodajNauczycielaTest()
        {
            //Arrange (przygotuj test)
            NauczycielRepository nauczycielRepository = new NauczycielRepository();
            Nauczyciel nauczyciel = new Nauczyciel(1);
            nauczyciel.PrzedmiotId = 1;
            var oczekiwana = nauczyciel;

            //Act (dzialaj)
            var aktualna = nauczycielRepository.Pobierz(1);
            //Assert (potwierdz test)
            Assert.AreEqual(oczekiwana.NauczycielId, aktualna.NauczycielId);
            Assert.AreEqual(oczekiwana.PrzedmiotId, aktualna.PrzedmiotId);
        }
        [TestMethod]
        public void PrzypiszUnikatowyPrzemdiotDoNauczyciela()
        {
            //Arrange (przygotuj test)
            Przedmiot.ListaPrzedmiotow = new List<int>();
            PrzedmiotRepository przedmiotRepository = new PrzedmiotRepository();
            var przedmiot1 = przedmiotRepository.Pobierz(1);
            Przedmiot.ListaPrzedmiotow.Add(przedmiot1.PrzedmiotId);
            var przedmiot2 = przedmiotRepository.Pobierz(2);
            Przedmiot.ListaPrzedmiotow.Add(przedmiot2.PrzedmiotId);

            NauczycielRepository nauczycielRepository = new NauczycielRepository();
            Nauczyciel nauczyciel = nauczycielRepository.Pobierz(1);
            nauczyciel.PrzedmiotId = Przedmiot.WybranyPrzedmiotZListy(0);
            var oczekiwana1 = nauczyciel;
            nauczycielRepository = new NauczycielRepository();
            nauczyciel = nauczycielRepository.Pobierz(2);
            nauczyciel.PrzedmiotId = Przedmiot.WybranyPrzedmiotZListy(0);
            var oczekiwana2 = nauczyciel;

            //Act (dzialaj)
            var aktualna1 = przedmiot1;
            var aktualna2 = przedmiot2;
            //Assert (potwierdz test)
            Assert.AreEqual(oczekiwana1.PrzedmiotId, aktualna1.PrzedmiotId);
            Assert.AreEqual(oczekiwana2.PrzedmiotId, aktualna2.PrzedmiotId);
        }
    }
}

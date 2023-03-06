using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        //Низкие тесты
        //Проверяет корректность метода (что kode состоит из 17 правильных букв)
        [TestMethod]
        public void CheckKODE_IsTrue()
        {
            string kode = "JHMCM56557C404453";
            bool actual = Calculation.CheckKODE(kode);
            Assert.IsTrue(actual);
        }

        //Проверяет корректность метода (что kode состоит из 17 букв, но некоторые буквы не являются правильными)
        [TestMethod]
        public void CheckKODE_IsFalse()
        {
            string kode = "OHMCM56557C404453";
            bool actual = Calculation.CheckKODE(kode);
            Assert.IsFalse(actual);
        }
        //Проверяет корректность метода (что kode состоит из 17 букв, хотя введем всего лишь 16)
        [TestMethod]
        public void CheckKODE_IsFalse_16bykv()
        {
            string kode = "HMCM56557C404453";
            bool actual = Calculation.CheckKODE(kode);
            Assert.IsFalse(actual);
        }
        //Проверяет корректность метода (Выведет Африку)
        [TestMethod]
        public void GetKODECountry_Africa()
        {
            string kode = "JHMCM5655AAAA4453";
            string conutry = "Африка";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода (Выведет Азию)
        [TestMethod]
        public void GetKODECountry_Azia()
        {
            string kode = "JHMCM5655AKKA4453";
            string conutry = "Азия";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода (Выведет Европа)
        [TestMethod]
        public void GetKODECountry_Evropa()
        {
            string kode = "JHMCM5655AKTA4453";
            string conutry = "Европа";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода (Выведет Северная Америка)
        [TestMethod]
        public void GetKODECountry_Severnay_America()
        {
            string kode = "JHMCM5655AK1A4453";
            string conutry = "Северная Америка";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода (Выведет Океания)
        [TestMethod]
        public void GetKODECountry_Okeania()
        {
            string kode = "JHMCM5655AK6A4453";
            string conutry = "Океания";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода (Выведет Южная Америка)
        [TestMethod]
        public void GetKODECountry_South_America()
        {
            string kode = "JHMCM5655AK9A4453";
            string conutry = "Южная Америка";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }

        //Проверяет корректность метода (Выдает данные)
        [TestMethod]
        public void GetKODECountry_IsNotNull()
        {
            string kode = "JHMCM5655AK9A44";
            string actual = Calculation.GetKODECountry(kode);
            Assert.IsNotNull(actual);
        }

        //Сложные тесты
        //Проверяет какой тип данных выдаст
        [TestMethod]
        public void GetKODECountry_Type()
        {
            string kode = "JHMCM5655AK9A44";
            string actual = Calculation.GetKODECountry(kode);
            Assert.IsInstanceOfType(actual, typeof(string));
        }

        [TestMethod]
        //Проверяет какой тип данных выдаст
        public void GetKODE_Type()
        {
            string kode = "JHMCM5655AK9A44";
            bool actual = Calculation.CheckKODE(kode);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }

        //Проверяет корректность метода если ввести не существующию географическую зону (Выведет null)
        [TestMethod]
        public void GetKODECountry_NULL()
        {
            string kode = "JHMCM5655A00A4453";
            string conutry = "";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }

        //Проверяет корректность метода, если отправить не 17 буквенный kode (Выведет null)
        [TestMethod]
        public void GetKODECountry_NULL_Not17()
        {
            string kode = "JHMCM5655A00A445";
            string conutry = "";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //Проверяет корректность метода, если отправить пустой kode (Выведет null)
        [TestMethod]
        public void GetKODECountry_NULL_Kode_Pysto()
        {
            string kode = "";
            string conutry = "";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
    }
}

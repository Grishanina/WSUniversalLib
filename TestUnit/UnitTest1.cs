using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        //������ �����
        //��������� ������������ ������ (��� kode ������� �� 17 ���������� ����)
        [TestMethod]
        public void CheckKODE_IsTrue()
        {
            string kode = "JHMCM56557C404453";
            bool actual = Calculation.CheckKODE(kode);
            Assert.IsTrue(actual);
        }

        //��������� ������������ ������ (��� kode ������� �� 17 ����, �� ��������� ����� �� �������� �����������)
        [TestMethod]
        public void CheckKODE_IsFalse()
        {
            string kode = "OHMCM56557C404453";
            bool actual = Calculation.CheckKODE(kode);
            Assert.IsFalse(actual);
        }
        //��������� ������������ ������ (��� kode ������� �� 17 ����, ���� ������ ����� ���� 16)
        [TestMethod]
        public void CheckKODE_IsFalse_16bykv()
        {
            string kode = "HMCM56557C404453";
            bool actual = Calculation.CheckKODE(kode);
            Assert.IsFalse(actual);
        }
        //��������� ������������ ������ (������� ������)
        [TestMethod]
        public void GetKODECountry_Africa()
        {
            string kode = "JHMCM5655AAAA4453";
            string conutry = "������";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //��������� ������������ ������ (������� ����)
        [TestMethod]
        public void GetKODECountry_Azia()
        {
            string kode = "JHMCM5655AKKA4453";
            string conutry = "����";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //��������� ������������ ������ (������� ������)
        [TestMethod]
        public void GetKODECountry_Evropa()
        {
            string kode = "JHMCM5655AKTA4453";
            string conutry = "������";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //��������� ������������ ������ (������� �������� �������)
        [TestMethod]
        public void GetKODECountry_Severnay_America()
        {
            string kode = "JHMCM5655AK1A4453";
            string conutry = "�������� �������";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //��������� ������������ ������ (������� �������)
        [TestMethod]
        public void GetKODECountry_Okeania()
        {
            string kode = "JHMCM5655AK6A4453";
            string conutry = "�������";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //��������� ������������ ������ (������� ����� �������)
        [TestMethod]
        public void GetKODECountry_South_America()
        {
            string kode = "JHMCM5655AK9A4453";
            string conutry = "����� �������";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }

        //��������� ������������ ������ (������ ������)
        [TestMethod]
        public void GetKODECountry_IsNotNull()
        {
            string kode = "JHMCM5655AK9A44";
            string actual = Calculation.GetKODECountry(kode);
            Assert.IsNotNull(actual);
        }

        //������� �����
        //��������� ����� ��� ������ ������
        [TestMethod]
        public void GetKODECountry_Type()
        {
            string kode = "JHMCM5655AK9A44";
            string actual = Calculation.GetKODECountry(kode);
            Assert.IsInstanceOfType(actual, typeof(string));
        }

        [TestMethod]
        //��������� ����� ��� ������ ������
        public void GetKODE_Type()
        {
            string kode = "JHMCM5655AK9A44";
            bool actual = Calculation.CheckKODE(kode);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }

        //��������� ������������ ������ ���� ������ �� ������������ �������������� ���� (������� null)
        [TestMethod]
        public void GetKODECountry_NULL()
        {
            string kode = "JHMCM5655A00A4453";
            string conutry = "";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }

        //��������� ������������ ������, ���� ��������� �� 17 ��������� kode (������� null)
        [TestMethod]
        public void GetKODECountry_NULL_Not17()
        {
            string kode = "JHMCM5655A00A445";
            string conutry = "";
            string actual = Calculation.GetKODECountry(kode);
            Assert.AreEqual(conutry, actual);
        }
        //��������� ������������ ������, ���� ��������� ������ kode (������� null)
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

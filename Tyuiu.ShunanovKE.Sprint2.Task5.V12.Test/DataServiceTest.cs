using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint2.Task5.V12.Lib;

namespace Tyuiu.ShunanovKE.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("31.12.2023", ds.FindDateOfPreviousDay(2024, 1, 1));
            Assert.AreEqual("30.4.2008", ds.FindDateOfPreviousDay(2008, 5, 1));
            Assert.AreEqual("14.8.2020", ds.FindDateOfPreviousDay(2020, 8, 15));
            Assert.AreEqual("29.2.2004", ds.FindDateOfPreviousDay(2004, 3, 1));
            Assert.AreEqual("10.10.2012", ds.FindDateOfPreviousDay(2012, 10, 11));
            Assert.AreEqual("31.12.1983", ds.FindDateOfPreviousDay(1984, 1, 1));
        }
    }
}

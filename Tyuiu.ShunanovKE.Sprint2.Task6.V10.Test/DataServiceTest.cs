using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint2.Task6.V10.Lib;

namespace Tyuiu.ShunanovKE.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("31.12.2022", ds.FindDateOfPreviousDay(2023, 1, 1));
            Assert.AreEqual("30.4.2007", ds.FindDateOfPreviousDay(2007, 5, 1));
            Assert.AreEqual("14.8.2019", ds.FindDateOfPreviousDay(2019, 8, 15));
            Assert.AreEqual("28.2.2003", ds.FindDateOfPreviousDay(2003, 3, 1));
            Assert.AreEqual("10.10.2011", ds.FindDateOfPreviousDay(2011, 10, 11));
            Assert.AreEqual("31.12.1982", ds.FindDateOfPreviousDay(1983, 1, 1));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint2.Task7.V14.Lib;

namespace Tyuiu.ShunanovKE.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.5, 0.5));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.5, -0.5));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-0.1, 0.8));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(-0.8, 0.1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(-0.3, -0.2));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.9, 0.9));
        }
    }
}

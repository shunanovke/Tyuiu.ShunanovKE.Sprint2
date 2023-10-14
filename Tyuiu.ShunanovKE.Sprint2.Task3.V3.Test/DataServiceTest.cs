using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint2.Task3.V3.Lib;

namespace Tyuiu.ShunanovKE.Sprint2.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x), wait = 18;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x), wait = 0.167;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -3;
            double res = ds.Calculate(x), wait = 1;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x), wait = 0.1;
            Assert.AreEqual(res, wait);
        }
    }
}

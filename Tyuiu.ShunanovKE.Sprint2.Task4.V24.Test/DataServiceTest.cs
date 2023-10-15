using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint2.Task4.V24.Lib;

namespace Tyuiu.ShunanovKE.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2, y = -23;
            double res = ds.Calculate(x, y);
            double wait = 60.5;

            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1, y = 0;
            double res = ds.Calculate(x, y);
            double wait = 0.734;

            Assert.AreEqual(res, wait);
        }
    }
}

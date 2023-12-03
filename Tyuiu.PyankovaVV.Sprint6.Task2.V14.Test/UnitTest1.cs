using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyankovaVV.Sprint6.Task2.V14.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task2.V14.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidCalck()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 19.81, 16.79, 13.87, 10.98, 7.94, 3, 3.23, -0.45, -3.79, -6.97, -10 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.PyankovaVV.Sprint6.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\
            int[,] wait = new int[2, 2] { { 1, 0 },
                                          { 0, 1 } };
            int[,] res = ds.GetMatrix(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

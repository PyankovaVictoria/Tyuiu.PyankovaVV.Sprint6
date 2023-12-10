using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyankovaVV.Sprint6.Task5.V4.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

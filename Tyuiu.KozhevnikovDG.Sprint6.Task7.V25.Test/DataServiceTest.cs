using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.Sprint6.Task7.V25.Lib;

using System.IO;

namespace Tyuiu.KozhevnikovDG.Sprint6.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutFileTask7V25.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}

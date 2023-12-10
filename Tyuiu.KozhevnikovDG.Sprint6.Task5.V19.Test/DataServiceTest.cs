using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KozhevnikovDG.Sprint6.Task5.V19.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint6.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\f1zog\source\repos\Tyuiu.KozhevnikovDG.Sprint6\Tyuiu.KozhevnikovDG.Sprint6.Task5.V19\bin\Debug\InPutFileTask5V19.txt";

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { -17, 0, 12, 5, 35, -9, 0, -7 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
    
}

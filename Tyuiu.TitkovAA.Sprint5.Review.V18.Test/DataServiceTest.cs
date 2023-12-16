using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint5.Review.V18.Lib;
using System.IO;

namespace Tyuiu.TitkovAA.Sprint5.Review.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\123\source\repos\Tyuiu.TitkovAA.Sprint5.Review\Tyuiu.TitkovAA.Sprint5.Review.V18\bin\Debug\OutPutDataFileTask7V18
.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);

        }
    }
}

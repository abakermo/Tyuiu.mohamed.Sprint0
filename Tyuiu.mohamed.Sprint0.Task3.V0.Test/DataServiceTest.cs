﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.mohamed.Sprint0.Task3.V0.Lib;
namespace Tyuiu.mohamed.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}

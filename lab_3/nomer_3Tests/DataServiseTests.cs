using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataServise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServise.Tests
{
    [TestClass()]
    public class DataServiseTests
    {
        [TestMethod()]
        public void GetDayTest()
        {
            Assert.AreEqual(DataServise.GetDay("30.03.2022"), "Wednesday");
        }

        [TestMethod()]
        public void GetDayTest1()
        {
            Assert.AreEqual(DataServise.GetDay("01.01.0001"), "Monday");
        }

        [TestMethod()]
        public void GetDayTest2()
        {
            Assert.AreEqual(DataServise.GetDay("31.03.2022"), "Thursday");
        }

        [TestMethod()]
        public void GetDayTest3()
        {
            Assert.AreEqual(DataServise.GetDay("29.02.2020"), "Saturday");
        }


        [TestMethod()]
        public void GetDaysSpanTest()
        {
            Assert.AreEqual(DataServise.GetDaysSpan(30, 03, 2022), 1);
        }

        [TestMethod()]
        public void GetDaysSpanTest1()
        {
            Assert.AreEqual(DataServise.GetDaysSpan(31, 03, 2022), 0);
        }

        [TestMethod()]
        public void GetDaysSpanTest2()
        {
            Assert.AreEqual(DataServise.GetDaysSpan(29, 03, 2022), 2);
        }

        [TestMethod()]
        public void GetDaysSpanTest3()
        {
            Assert.AreEqual(DataServise.GetDaysSpan(1, 1, 1), 738244);
        }

    }
}
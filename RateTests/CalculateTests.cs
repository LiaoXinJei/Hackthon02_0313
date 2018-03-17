using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rate.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void Given_Main_money_100000_When_Calculate_Then_5000()
        {
            decimal expected = 5000;
            decimal money = 100000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Main_money_540000_When_Calculate_Then_27000()
        {
            decimal expected = 27000;
            decimal money = 540000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Main_money_540001_When_Calculate_Then_27000_12()
        {
            decimal expected = 27000.12m;
            decimal money = 540001;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Main_money_1210000_When_Calculate_Then_107400()
        {
            decimal expected = 107400;
            decimal money = 1210000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Given_Main_money_1218000_When_Calculate_Then_109000()
        {
            decimal expected = 109000;
            decimal money = 1218000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Given_Main_money_2420000_When_Calculate_Then_349000()
        {
            decimal expected = 349400;
            decimal money = 2420000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Given_Main_money_2500000_When_Calculate_Then_373400()
        {
            decimal expected = 373400;
            decimal money = 2500000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Given_Main_money_4530000_When_Calculate_Then_982400()
        {
            decimal expected = 982400;
            decimal money = 4530000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Main_money_5530000_When_Calculate_Then_1382400()
        {
            decimal expected = 1382400;
            decimal money = 5530000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Given_Main_money_10310000_When_Calculate_Then_3294400()
        {
            decimal expected = 3294400; 
            decimal money = 10310000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Given_Main_money_10710000_When_Calculate_Then_3494400()
        {
            decimal expected = 3494400; 
            decimal money = 10710000;
            decimal actual = Calculate.CaculateRate(money);
            Assert.AreEqual(expected, actual);
        }


    }
}
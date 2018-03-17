using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome.Tests
{
    [TestClass()]
    public class TestTests
    {
        [TestMethod()]
        public void GIVEN_Input_12321_When_PalindromeTest_Then_True()
        {
            string expected = "你輸入的是回文";
            char[] array = new char[]{ '1','2','3','2','1' };
            var actual = Test.PalindromeTest(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
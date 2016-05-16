using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for FizzBuzzTest
    /// </summary>
    [TestClass]
    public class FizzBuzzTest
    {
        
        [TestMethod]
        public void FizzTest()
        {
            string expected = "Fizz";
            string result = FizzBuzz.Fizz(3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BuzzTest()
        {
            string expected = "Buzz";
            string result = FizzBuzz.Fizz(5);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzz_Test()
        {
            string expected = "FizzBuzz";
            string result = FizzBuzz.Fizz(15);
            Assert.AreEqual(expected, result);
        }
    }
}
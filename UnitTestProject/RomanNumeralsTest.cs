using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication;

/*
1 ->    "I" | 10 ->    "X" | 100 ->    "C" | 1000 ->    "M"
2 ->   "II" | 20 ->   "XX" | 200 ->   "CC" | 2000 ->   "MM"
3 ->  "III" | 30 ->  "XXX" | 300 ->  "CCC" | 3000 ->  "MMM"
4 ->   "IV" | 40 ->   "XL" | 400 ->   "CD" | 4000 -> "MMMM"
5 ->    "V" | 50 ->    "L" | 500 ->    "D" |
6 ->   "VI" | 60 ->   "LX" | 600 ->   "DC" |
7 ->  "VII" | 70 ->  "LXX" | 700 ->  "DCC" |
8 -> "VIII" | 80 -> "LXXX" | 800 -> "DCCC" |
9 ->   "IX" | 90 ->   "XC" | 900 ->   "CM" |

1990 -> "MCMXC"  (1000 -> "M"  + 900 -> "CM" + 90 -> "XC")
2008 -> "MMVIII" (2000 -> "MM" + 8 -> "VIII")
  99 -> "XCIX"   (90 -> "XC" + 9 -> "IX")
  47 -> "XLVII"  (40 -> "XL" + 7 -> "VII")
*/


namespace UnitTestProject
{
    /// <summary>
    /// Summary description for RomanNumeralsTest
    /// </summary>
    [TestClass]
    public class RomanNumeralsTest
    {
        [TestMethod]
        public void MilionsTest()
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.AreEqual("M", romanNumerals.ConvertNumberToRoman(1000));
            Assert.AreEqual("MM", romanNumerals.ConvertNumberToRoman(2000));
            Assert.AreEqual("MMM", romanNumerals.ConvertNumberToRoman(3000));
            Assert.AreEqual("MMMM", romanNumerals.ConvertNumberToRoman(4000));
        }

       [TestMethod]
       public void HundredTest()
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.AreEqual("C", romanNumerals.ConvertNumberToRoman(100));
            Assert.AreEqual("CCC", romanNumerals.ConvertNumberToRoman(300));
            Assert.AreEqual("CD", romanNumerals.ConvertNumberToRoman(400));
            Assert.AreEqual("CM", romanNumerals.ConvertNumberToRoman(900));
        }

        [TestMethod]
        public void DezenaTest()
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.AreEqual("XL", romanNumerals.ConvertNumberToRoman(40));
            Assert.AreEqual("LXXX", romanNumerals.ConvertNumberToRoman(80));
            Assert.AreEqual("XC", romanNumerals.ConvertNumberToRoman(90));            
        }

        [TestMethod]
        public void UnitaryTest()
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Assert.AreEqual("", romanNumerals.ConvertNumberToRoman(0));
            Assert.AreEqual("I", romanNumerals.ConvertNumberToRoman(1));
            Assert.AreEqual("IV", romanNumerals.ConvertNumberToRoman(4));
            Assert.AreEqual("V", romanNumerals.ConvertNumberToRoman(5));
            Assert.AreEqual("IX", romanNumerals.ConvertNumberToRoman(9));
        }
    }
}
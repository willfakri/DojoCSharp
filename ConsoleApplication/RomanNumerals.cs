using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class RomanNumerals
    {
        Dictionary<int, string> romanNumerals;
        public string ConvertNumberToRoman(int number)
        {
            romanNumerals = new Dictionary<int, string>();
            romanNumerals.Add(1, "I");
            romanNumerals.Add(2, "II");
            romanNumerals.Add(3, "III");
            romanNumerals.Add(4, "IV");
            romanNumerals.Add(5, "V");
            romanNumerals.Add(6, "VI");
            romanNumerals.Add(7, "VII");
            romanNumerals.Add(8, "VIII");
            romanNumerals.Add(9, "IX");
            romanNumerals.Add(10, "X");
            romanNumerals.Add(20, "XX");
            romanNumerals.Add(30, "XXX");
            romanNumerals.Add(40, "XL");
            romanNumerals.Add(50, "L");
            romanNumerals.Add(60, "LX");
            romanNumerals.Add(70, "LXX");
            romanNumerals.Add(80, "LXXX");
            romanNumerals.Add(90, "XC");
            romanNumerals.Add(100, "C");
            romanNumerals.Add(200, "CC");
            romanNumerals.Add(300, "CCC");
            romanNumerals.Add(400, "CD");
            romanNumerals.Add(500, "D");
            romanNumerals.Add(600, "DC");
            romanNumerals.Add(700, "DCC");
            romanNumerals.Add(800, "DCCC");
            romanNumerals.Add(900, "CM");
            romanNumerals.Add(1000, "M");
            romanNumerals.Add(2000, "MM");
            romanNumerals.Add(3000, "MMM");
            romanNumerals.Add(4000, "MMMM");

            string stringNumber = number.ToString();
            string stringRoman = "";
            int numberLoop = number; 
                    
            if (numberLoop >= 1000)
            {
                stringRoman = romanNumerals[int.Parse(string.Concat(stringNumber.Substring(0, 1), "000"))];
                numberLoop = int.Parse(stringNumber.Substring(1, 3));
            }

            if (numberLoop >= 100)
            {
                stringRoman = string.Concat(stringRoman, romanNumerals[int.Parse(string.Concat(stringNumber.Substring(0, 1), "00"))]);
                numberLoop = int.Parse(stringNumber.Substring(1, 2));
            }

            if (numberLoop >= 10)
            {
                stringRoman = string.Concat(stringRoman, romanNumerals[int.Parse(string.Concat(stringNumber.Substring(0, 1), "0"))]);
                numberLoop = int.Parse(stringNumber.Substring(1, 1));
            }

            if (numberLoop >= 1)
            {
                stringRoman = string.Concat(stringRoman, romanNumerals[int.Parse(stringNumber)]);                
            }
            
            return stringRoman;
        }
    }
}
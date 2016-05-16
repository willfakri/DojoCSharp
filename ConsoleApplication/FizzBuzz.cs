using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public static class FizzBuzz
    {
        public static void RunFizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(Fizz(i));
            }
            Console.ReadKey();
        }

        public static string Fizz(int number)
        {
            if (number % 3 == 0)
            {
                if(number % 5 == 0)
                {
                    return "FizzBuzz";
                }
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}

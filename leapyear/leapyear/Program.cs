using System;
using System.Collections.Generic;
using System.Text;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year :")
               if (((year % 400==0)) && (year % 100==0) && (year % 4==0))
            {
                Console.Write("Year is leap Year ");

            }
            else
            {
                Console.WriteLine("this is not a leapyear :);")
            }
        }
    }
}

using System;
using System.IO;

namespace Powerof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number power of 2 :");
            string number = Console.ReadLine();
            int power = int.Parse(number);
            int result = 1;
            while(power>0)
            {
                result *=2;
                power--;
            }
            Console.WriteLine("The Power of result is :" + result);
        }
    }
}
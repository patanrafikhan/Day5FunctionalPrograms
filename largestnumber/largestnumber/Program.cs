using System;

using System.IO;

namespace largestnumber
{
    internal class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            int a,b,c;
           // int b;
           // int c;
            int large;
            
            //inout the numbers

            Console.WriteLine("Enter first number :");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number :");
            c=Convert.ToInt32(Console.ReadLine());

            //Finding largest number using if-else

            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else
                large= c;
           // Console.WriteLine("Using if-else..");
            Console.WriteLine("Largest Number is {0}:", large);

            //large = (a > b && a > c) ? a : (b > a && b > c) ? b : c;

            //Console.WriteLine("Using Ternary operator...");
           // Console.WriteLine("Largest number is {0}", large);
        }
        
    }
}

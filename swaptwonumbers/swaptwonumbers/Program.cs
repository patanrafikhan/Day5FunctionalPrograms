using System;

namespace swaptwonumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n,reverse = 0, rem;
            Console.WriteLine("\n Input the First Number :");
            n=int.Parse(Console.ReadLine());
            //Console.WriteLine("\n Input the second number :");
           // n=int.Parse(Console.ReadLine());

            while (n!= 0)
            {
                rem = n  % 10;
                reverse = reverse*10+rem;
                n /= 10;
            }
           
            //num1 = num2;
            //num2 = num1;
            Console.WriteLine("\n After Swapping :");
            Console.WriteLine("\n First Number :"+reverse);
            //Console.WriteLine("\n Second Number :" + reverse);
            Console.Read();
        }
    }
}

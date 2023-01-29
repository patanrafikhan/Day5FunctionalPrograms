using System;

namespace evenoroddnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number =");
            n=Convert.ToInt32(Console.ReadLine());
            if ((n&1)==0)
            {
                Console.WriteLine(n + " is even");
            }
            else
            {
                Console.WriteLine(n + "is odd");
            }
            Console.ReadKey();
        }
    }
}

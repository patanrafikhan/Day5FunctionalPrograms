using System;

namespace harmonic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double s = 0.0;
            Console.WriteLine("Calculate the Harmonic series and their sum :\n");
            Console.WriteLine("\n\n");

            Console.WriteLine("Input the number of terms :");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            for(i=1;i<=n; i++)
            {
                Console.WriteLine("1/{0}", i);
                s+= 1 / (float)i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms :{1}\n", n, s);
        }
    }
}

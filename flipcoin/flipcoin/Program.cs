using System;

namespace flipcoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {


                Random ran = new Random();
                int num = ran.Next(0, 2);
                if (num == 0)
                {
                    Console.WriteLine("Head");
                }
                else
                {
                    Console.WriteLine("Tail");
                }
            }
        }

    }
}

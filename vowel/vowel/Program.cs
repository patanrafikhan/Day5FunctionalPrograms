using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("\n\n");
            Console.WriteLine("check whether the input alphabet is a vowel or not:\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Input a Alphabet (A-z or a-z) :");
            ch= Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if(i>=48 && i<=57)
            {
                Console.WriteLine("Enter an Alphabet Number :");
            }
            else
            {
                switch (ch)
                {
                    case'a':
                        Console.WriteLine("The Alphabet is vowel :");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel :");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel :");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel :");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel :");
                        break;
                    default: Console.WriteLine("The Alphabet is not a vowel");
                        break;

                }

            }
            Console.ReadKey();
        }
    }
}

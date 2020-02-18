using System;

namespace Iterative
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("Please enter an integer from 2 to 10");
            n = Console.ReadLine();
            int m;
            m = Convert.ToInt32(n);
            if (m % 2 ==0)
            {
                Console.Write("This is an even number");
            }
            else
            {
                Console.Write("This is an odd number");
            }
        }
    }
}

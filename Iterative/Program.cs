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
                m = m + 1;
                while (m > 0)
                {
                    Console.Write("This is an even number");
                    m = m - 1;
                }
            }
            else
            {
                m = m - 1;
                while (m > 0)
                {
                    Console.Write("This is an odd number");
                    m = m - 1;
                }
            }
        }
    }
}

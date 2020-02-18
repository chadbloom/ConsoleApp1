using System;

namespace Iterative
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("Please enter an integer from 2 to 10:");
            n = Console.ReadLine();
            int m,c;
            m = Convert.ToInt32(n);
            if (m % 2 ==0)
            {
                m = m + 1;
                c = 1;
                while (c < m + 1)
                {
                    Console.WriteLine(c + ". This is an even number");
                    c++;
                }
            }
            else
            {
                m = m - 1;
                c = 1;
                while (c < m + 1)
                {
                    Console.WriteLine(c + ". This is an odd number");
                    c++;
                }
            }
        }
    }
}

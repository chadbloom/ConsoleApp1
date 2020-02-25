using System;

namespace Methodizer
{
    class Program
    {
                // This is the main operation
        static void Main(string[] args)
        {
            String a, b;
            int x, y, c;
            PrintName();
            Console.WriteLine("Enter the first value:");
            a = Console.ReadLine();
            Console.WriteLine("Enter the second value:");
            b = Console.ReadLine();
            x = Convert.ToInt32(a);
            y = Convert.ToInt32(b);

            c = AddInputs(x, y);
            Console.WriteLine(c);

            // this method prints my name
            static void PrintName()
            {
                Console.WriteLine("Chad Bloom");
            }

            // this method performs the addition
            static int AddInputs(int x, int y)
            {
                int c;
                c = x + y;
                return c;
            }
        }
    }
}

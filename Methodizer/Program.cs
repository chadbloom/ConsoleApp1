using System;

namespace Methodizer
{
    class Program
    {
                // This is the main operation
        static void Main(string[] args)
        {
            // declare variables
            String a, b, action;
            int x, y, c;

            // call on the method to print my name
            PrintName();

            // collect pertinent information for calculations
            Console.WriteLine("Which arithmetic operation would you like to do?");
            Console.WriteLine("Please enter '+', '-', '*' or '/':");
            action = Console.ReadLine();
            Console.WriteLine("Enter the first value:");
            a = Console.ReadLine();
            Console.WriteLine("Enter the second value:");
            b = Console.ReadLine(); 
            x = Convert.ToInt32(a);
            y = Convert.ToInt32(b);

            // start if statement here
            if (action == "+")
            {
                c = AddInputs(x, y);
                Console.WriteLine(c);
            }
            //c = AddInputs(x, y);
            //Console.WriteLine(c);

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

            // this method performs the subtraction
            static int SubtractInputs(int x, int y)
            {
                int c;
                c = x - y;
                return c;
            }

            // this method performs the multiplication
            static int MultiplyInputs(int x, int y)
            {
                int c;
                c = x * y;
                return c;
            }

            // this metho performs the division
            static int DivideInputs(int x, int y)
            {
                int c;
                c = x / y;
                return c;
            }
        }
    }
}

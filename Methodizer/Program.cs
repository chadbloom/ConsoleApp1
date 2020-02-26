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
            int x, y;

            // call on the method to print my name
            PrintName();

            // collect pertinent information for calculations
            Console.WriteLine("Which arithmetic operation would you like to do?");
            Console.WriteLine("Please enter '+', '-', '*' or '/' (no quotes):");
            action = Console.ReadLine();
            Console.WriteLine("Enter the first integer:");
            a = Console.ReadLine();
            Console.WriteLine("Enter the second integer:");
            b = Console.ReadLine(); 

            // convert information to usable data
            x = Convert.ToInt32(a);
            y = Convert.ToInt32(b);
            Math(x, y, action);

            // start big method here
            static void Math(int x, int y, string action)
            {
                if (action == "/" && y == 0)
                {
                    Console.WriteLine("Can't divide by zero!");
                }
                else if (action == "+")  // for addition
                {
                    int c;
                    c = x + y;
                    //return c;
                    Console.WriteLine("The sum of " + x + " and " + y + " is " + c);
                }
                else if (action == "-") // for subtraction
                {
                    int c;
                    c = x - y;
                    Console.WriteLine("The difference of " + x + " and " + y + " is " + c);
                }
                else if (action == "*") // for multiplication
                {
                    int c;
                    c = x * y;
                    Console.WriteLine("The product of " + x + " and " + y + " is " + c);
                }
                else if (action == "/") // for division
                {
                    int c;
                    c = x / y;
                    Console.WriteLine("The quotient of dividend: " + x + " and divisor: " + y + " is " + c);
                }
                else                    // for incorrectly entered arithmatic functions
                {
                    Console.WriteLine("You have entered an invlid function.  Please start over.");
                }
            }

            // this method prints my name
            static void PrintName()
            {
                Console.WriteLine("Chad Bloom");
            }
        }
    }
}

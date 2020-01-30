using System;

namespace UserInputChadBloom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Chad Bloom.  Please type your full name and hit the enter Key.");
            string username;
            username = Console.ReadLine();
            Console.WriteLine("You should know this already but your name is " + username);
        }
    }
}

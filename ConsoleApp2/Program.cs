using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What score out of 100 do you expect to get in ISM 4300?");
            Console.WriteLine("Please enter an integer value from 0 to 100.");
            string answer;
            answer = Console.ReadLine();
            int score;
            score = Convert.ToInt32(answer);
            if (score >= 98)
            {
                Console.WriteLine("Your grade will be an A+");
            }
            else
            {
                if (score < 98 && score >= 92)
                {
                    Console.WriteLine("Your grade will be an A");
                }

                else
                {
                    if (score < 92 && score >= 90)
                    {
                        Console.WriteLine("Your grade will be an A-");
                    }

                    else
                    {
                        if (score < 90 && score >= 88)
                        {
                            Console.WriteLine("Your grade will be a B+");
                        }
                        else
                        {
                            if (score < 88 && score >= 82)
                            {
                                Console.WriteLine("Your grade will be a B");
                            }
                            else
                            {
                                if (score < 82 && score >= 80)
                                {
                                    Console.WriteLine("Your grade will be a B-");
                                }
                                else
                                {
                                    if (score < 80 && score >= 78)
                                    {
                                        Console.WriteLine("Your grade will be a C+");
                                    }
                                    else
                                    {
                                        if (score < 78 && score >= 72)
                                        {
                                            Console.WriteLine("Your grade will be a C");
                                        }
                                        else
                                        {
                                            if (score < 72 && score >= 70)
                                            {
                                                Console.WriteLine("Your grade will be a C-");
                                            }
                                            else
                                            {
                                                if (score < 70 && score >= 68)
                                                {
                                                    Console.WriteLine("Your grade will be a D+");
                                                }
                                                else
                                                {
                                                    if (score < 68 && score >= 62)
                                                    {
                                                        Console.WriteLine("Your grade will be a D");
                                                    }
                                                    else
                                                    {
                                                        if (score < 62 && score >= 60)
                                                        {
                                                            Console.WriteLine("Your grade will be a D-");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("You fail.  Be better.");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

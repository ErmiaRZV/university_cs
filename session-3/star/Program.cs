﻿﻿using System;

namespace characterStar
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            Console.Write("Enter a character between E , H , I : ");
            character = Convert.ToChar(Console.ReadLine());
            if (character == 'e' || character == 'E')
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        for (int j = 1; j <= 4; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine("");
                }
            }
            else if (character == 'i' || character == 'I')
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1 || i == 5)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        Console.Write("  *");
                    }
                    Console.WriteLine("");
                }

            }
            else if (character == 'h' || character == 'H')
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 3)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        Console.Write("*   *");
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Enter a characyer between E , H , I please");
            }
            Console.ReadKey();
        }
    }
}
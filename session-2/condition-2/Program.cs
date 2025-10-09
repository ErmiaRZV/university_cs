﻿using System;

namespace condition2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num ;
            Console.Write("Enter a number : ");
            num = Int32.Parse(Console.ReadLine());

            if (num % 7 == 0)
                Console.WriteLine("YES!");
            else
            {
                num *= 3;
                Console.WriteLine(num);
            }

                Console.ReadKey();

        }
    }
}
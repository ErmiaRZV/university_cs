﻿using System;

namespace condition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number : ");
            num = Int32.Parse(Console.ReadLine());

            if (num < 10 && num%2 == 0)
                Console.WriteLine("TRUE!");

            Console.ReadKey();
        }
    }
}
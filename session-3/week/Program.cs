﻿﻿using System;

namespace week
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter your number of week (1:7) : ");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("shanbe");
                    break;
                case 2:
                    Console.WriteLine("yek shanbe");
                    break;
                case 3:
                    Console.WriteLine("do shanbe");
                    break;
                case 4:
                    Console.WriteLine("se shanbe");
                    break;
                case 5:
                    Console.WriteLine("chahar shanbe");
                    break;
                case 6:
                    Console.WriteLine("panj shanbe");
                    break;
                case 7:
                    Console.WriteLine("jome");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1 to 7");
                    break;
            }
            Console.ReadKey();
        }
    }
}
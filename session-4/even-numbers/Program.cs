﻿﻿﻿using System;

namespace evenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int evens = 0;
            int odds = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter your number : ");
                number = Int32.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    evens++;
                }
                else
                {
                    odds++;
                }


            }
            Console.WriteLine($"odds : {odds} \t  evens : {evens} ");
            Console.ReadKey();
        }
    }
}

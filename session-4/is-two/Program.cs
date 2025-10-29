﻿﻿﻿using System;

namespace isTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number ;
            bool isTwo = false;
            int locTwo = -1;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter your number : ");
                number = Int32.Parse(Console.ReadLine());
                if (number == 2)
                {
                    isTwo = true;
                    locTwo = i + 1;
                }



            }
            
            if (isTwo)
            {
                Console.WriteLine($"I found 2 in your number {Convert.ToString(locTwo)} input");
            }
            else
            {
                Console.WriteLine("I didnt find 2 . you didnt enter 2");
            }
            Console.ReadKey();
        }
    }
}

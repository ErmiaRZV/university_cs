﻿﻿using System;

namespace haselZarb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int product = 1;
            
            
            Console.Write("Enter a number (0 to stop): ");
            num = Convert.ToInt32(Console.ReadLine());
            product *= num;
             while (num != 0){
                Console.Write("Enter a number (0 to stop): ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num != 0)
                {
                    product *= num;
                }
                
            }
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
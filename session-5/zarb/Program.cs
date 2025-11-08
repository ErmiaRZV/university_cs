using System;

namespace Zarb
{
    class Program
    {
        public static int Zarb(int a, int b)
        {
            if (b == 0)
            return 0;
            return a + Zarb(a, b-1);
        }


       

        static void Main(string[] args)
        {
            int num1, num2, result;

            Console.Write("Enter your first number : ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your second number : ");
            num2 = Int32.Parse(Console.ReadLine()); 
            result = Zarb(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {result}");
            Console.ReadKey();
        }
    }
}
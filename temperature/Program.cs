using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            double centigrade, fahrenheit;

            Console.Write("Enter centigrade : ");
            centigrade = double.Parse(Console.ReadLine());

            fahrenheit = centigrade * 1.8 + 32;

            Console.WriteLine($"{centigrade} centigrade =  {fahrenheit} fahrenheit");

            Console.ReadKey();

        }
    }
}

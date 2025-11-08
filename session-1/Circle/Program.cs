using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double shoa, pi, mohit, masahat;

            Console.Write("Enter shoa : ");
            shoa = double.Parse(Console.ReadLine());

            pi = 3.14;

            mohit = shoa * 2 * pi;

            masahat = shoa * shoa * pi;

            Console.WriteLine($"mohit = {mohit} and masahat = {masahat} ");
            
            Console.ReadKey();

        }
    }
}

using System;

namespace Function
{
    class Program
    {
        public static int mohitFunc(int zel1, int zel2, int zel3)
        {
            return zel1 + zel2 + zel3;
        }
        public static int masahatFunc(int ghaede, int ertefa)
        {
            return (ghaede * ertefa) / 2;
        }
       
       

        static void Main(string[] args)
        {
            int zel1, zel2, zel3, mohit, masahat, ghaede, ertefa;

            Console.Write("Enter your fist zel : ");
            zel1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your second zel : ");
            zel2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your third zel : ");
            zel3 = Int32.Parse(Console.ReadLine());
            mohit = mohitFunc(zel1, zel2, zel3);
            Console.WriteLine($"mohit = {mohit}");

            Console.Write("Enter your ghaede : ");
            ghaede = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your ertefa : ");
            ertefa = Int32.Parse(Console.ReadLine());
            masahat = masahatFunc(ghaede, ertefa);
            Console.WriteLine($"masahat = {masahat} ");

            Console.ReadKey();
        }
    }
}
using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Operators.Add(1, 2);
            Operators.Subtract(5, 3);
            Operators.Multiply(2, 3);
            Operators.Divide(8, 4);

            Operators.OddEvenFinder(5);
            Operators.OddEvenFinder(8);
        }
    }
}
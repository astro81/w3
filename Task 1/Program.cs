using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            add(1, 2);
            subtract(5, 3);
            multiply(2, 3);
            divide(8, 4);

            OddEvenFinder(5);
            OddEvenFinder(8);

        }

        static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine(a / b);
            else
                Console.WriteLine("Cannot divide by zero!");
        }

        static void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even number" : "Odd number";
            Console.WriteLine(result);
        }
    }
}
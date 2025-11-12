using System;

namespace Task_1
{
    public class Operators
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine(a / b);
            else
                Console.WriteLine("Cannot divide by zero!");
        }

        public static void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even number" : "Odd number";
            Console.WriteLine(result);
        }
    }
}
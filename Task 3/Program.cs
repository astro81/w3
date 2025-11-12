using System;

namespace Task_3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter age: ");
        int? age = Int32.Parse(Console.ReadLine() ?? "0");
        
        Console.WriteLine($"age {age}");

        if (age < 13)
        {
            Console.WriteLine("Child");
        } else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("Teen");
        }
        else if (age >= 20)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Dead");
        }
        
    }
}
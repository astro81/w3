using System;

namespace Task_5;

internal class Program
{
    static void Main(string[] args)
    {
        sumNum();
        whileNum();
        arrarySum();
    }

    static void sumNum()
    {
        Console.WriteLine("Enter number: ");
        int? number = Int32.Parse(Console.ReadLine() ?? "1");

        int sum = 0;
        
        for (int i = 1; i <= number; i++) sum += i;

        Console.WriteLine($"Sum: {sum}");
    }

    static void whileNum()
    {
        int i = 1;
        while (i < 20)
        {
            if (i % 4 == 0)
            {
                i++;
                continue;
            }

            if (i == 15) break;
            
            Console.WriteLine(i);
            i++;
        }
    }

    static void arrarySum()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int arrSum = 0;
        
        foreach (int num in arr) arrSum += num;
        
        Console.WriteLine($"Array Sum: {arrSum}");   
    }


}
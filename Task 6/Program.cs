using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            askNum();
            askPsk();
        }

        static void askNum()
        {
            try
            {
                Console.Write("Enter number: ");
                int num = Int32.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine($"You entered: {num}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program Exec\n");
            }   
        }

        static void askPsk()
        {
            try
            {
                Console.Write("Enter passwd: ");
                string? psk = Console.ReadLine();

                if (string.IsNullOrEmpty(psk)) throw new Exception("Password cannot be null");

                if (psk.Length < 6) throw new Exception("Password must be at least 6 characters.");

                Console.WriteLine("Password satisfied the requirement");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        
    }
}
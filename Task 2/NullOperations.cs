using System;

namespace Task_2
{
    public class NullOperations
    {
        public static void PerformNullChecks()
        {
            string? username = null;

            string result = (username == null) ? "Username is not available" : username;
            Console.WriteLine(result);

            string close = username ?? "Username is not available";
            Console.WriteLine(close);

            string? noClose = null; 
            noClose ??= "user"; 
            Console.WriteLine(noClose);
        }
    }
}


using System;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Expression Lambda: Single-line expression
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine($"Addition using Expression Lambda: {add(5, 3)}");

            // Statement Lambda: Multiple lines, requires curly braces and return statement
            Func<int, int, int> multiply = (x, y) =>
            {
                Console.WriteLine("Performing multiplication...");
                return x * y;
            };
            Console.WriteLine($"Multiplication using Statement Lambda: {multiply(5, 3)}");
            Console.WriteLine("Lab 2.23.a / Bishant Kayastha / Roll No.: 6");
            Console.ReadKey();
        }
    }
}

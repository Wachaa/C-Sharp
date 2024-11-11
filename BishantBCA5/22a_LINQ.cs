using System;
using System.Linq;  // Required for LINQ

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a list of integers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Example 1: Use LINQ to get all even numbers
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            // Display the result
            Console.WriteLine("Even numbers using LINQ:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            // Example 2: Use LINQ to find numbers greater than 5
            var greaterThanFive = numbers.Where(n => n > 5).ToList();

            // Display the resul
            Console.WriteLine("Numbers greater than 5 using LINQ:");
            foreach (var num in greaterThanFive)
            {
                Console.WriteLine(num);
            }

            // Example 3: Use LINQ to find the sum of all numbers
            int sum = numbers.Sum();

            Console.WriteLine($"Sum of all numbers using LINQ: {sum}");
            Console.WriteLine("Lab 2.22 / Bishant Kayastha / Roll No.: 6");
            Console.ReadKey();  // Pause to view the result
        }
    }
}

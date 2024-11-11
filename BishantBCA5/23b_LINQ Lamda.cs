using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ with Lambda: Find even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers using LINQ with Lambda:");
            evenNumbers.ForEach(n => Console.WriteLine(n));

            // LINQ with Lambda: Find numbers greater than 5
            var greaterThanFive = numbers.Where(n => n > 5).ToList();
            Console.WriteLine("\nNumbers greater than 5 using LINQ with Lambda:");
            greaterThanFive.ForEach(n => Console.WriteLine(n));

            // LINQ with Lambda: Find the sum of all numbers
            int sum = numbers.Sum();
            Console.WriteLine($"\nSum of all numbers using LINQ with Lambda: {sum}");
            Console.WriteLine("Lab 2.23.b / Bishant Kayastha / Roll No.: 6");
            Console.ReadKey();
        }
    }
}

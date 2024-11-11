using System;

namespace ThrowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Call a method that throws an exception
                ValidateNumber(-5);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Catch the thrown exception
                Console.WriteLine("Lab 2.24.b / Bishant Kayastha / Roll No.: 6");
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadKey();
        }

        // Method that throws an exception using 'throw'
        static void ValidateNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Number must be greater than or equal to zero.");


            }
            

        }
    }
}

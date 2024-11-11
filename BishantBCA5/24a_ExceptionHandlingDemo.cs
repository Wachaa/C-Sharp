using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Code that may throw an exception
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]);  // Index out of range
            }
            catch (IndexOutOfRangeException ex)
            {
                // Catch the specific exception
                Console.WriteLine("Caught an IndexOutOfRangeException: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Catch any other general exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // This block always runs, regardless of whether an exception occurred
                Console.WriteLine("The 'finally' block is executed.");
                Console.WriteLine("Lab 2.24.a / Bishant Kayastha / Roll No.: 6");
            }

            Console.ReadKey();
        }
    }
}

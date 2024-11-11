using System;

namespace CustomExceptionHandeling
{
    // Custom exception class inheriting from Exception
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Call a method that throws a custom exception
                ValidateAge(15);
            }
            catch (InvalidAgeException ex)
            {
                // Catch the custom exception
                Console.WriteLine("Lab 2.24.c / Bishant Kayastha / Roll No.: 6");
                Console.WriteLine("Custom Exception: " + ex.Message);
            }

            Console.ReadKey();
        }

        // Method that throws a custom exception
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or older.");

            }
            else
            {
                Console.WriteLine("Age is valid.");
            }
         

        }
    }
}

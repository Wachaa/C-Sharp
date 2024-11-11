using System;

namespace DelegateExample
{
    // Declare a delegate
    delegate void MyDelegate(string message);

    class Program
    {
        // Method that matches the delegate signature
        static void ShowMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate
            MyDelegate del = new MyDelegate(ShowMessage);

            // Invoke the delegate
            del("Hello, this is a use of delegate!");

            Console.WriteLine("Lab 2.21.a / Bishant Kayastha / Roll No.: 6");
            Console.ReadLine();
        }
    }
}

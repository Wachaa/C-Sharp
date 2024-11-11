using System;

namespace EventExample
{
    // Define a delegate
    public delegate void Notify();  // Delegate declaration for the event

    // Publisher Class
    public class ProcessBusinessLogic
    {
        // Declare the event as nullable
        public event Notify? ProcessCompleted;

        // Method that triggers the event
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");

            // Perform some process (Addition of two numbers)
            int num1 = 10;
            int num2 = 20;
            int result = num1 + num2;

            Console.WriteLine($"Addition of {num1} and {num2} is: {result}");

            // Raise the event
            OnProcessCompleted();
        }

        // Create a method to raise the event
        protected virtual void OnProcessCompleted()
        {
            // Use the null-conditional operator to raise the event
            ProcessCompleted?.Invoke();
        }
    }

    // Subscriber Class
    public class Program
    {
        static void Main(string[] args)
        {
            // Subscribe to the event
            ProcessBusinessLogic process = new ProcessBusinessLogic();
            process.ProcessCompleted += Process_ProcessCompleted;

            // Start the process
            process.StartProcess();

            Console.ReadKey();  // Pause to view the result
        }

        // Event handler that is called when the event is raised
        public static void Process_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
            Console.WriteLine("Lab 2.21.c / Bishant Kayastha / Roll No.: 6");
        }
    }
}

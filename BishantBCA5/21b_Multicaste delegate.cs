using System;

namespace MulticasteDelegateExample
{

    //Delegate declearation
    delegate void MyDelegate(string message);

    class Program
    {


        //method that matches delegate
        static void showMessage(string message)
        {
            Console.WriteLine($"Message:{message}");

        }
        static void upperCaseMessage(string message)
        {
            Console.WriteLine($"Message in Uppercase:{message.ToUpper()}");
            Console.WriteLine("Lab 2.21.b / Bishant Kayastha / Roll No.: 6");
        }


        static void Main(string[] args)
        {
            MyDelegate del = showMessage;
            del += upperCaseMessage;

            del("Using Multicast delegate");
            Console.ReadLine();
       
        }
    }
}

using System;


namespace Task_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your favorite number between 1 and 100: ");
           string input = Console.ReadLine();

            Console.WriteLine("Amazing!! That's my favorite number too!");
            Console.WriteLine($"No really!!, {input} is my favorite number!");


        }
    }
}

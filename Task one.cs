using System;


namespace Task_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the number of small carpets?: ");
           int smallCarpet = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the number of large carpets?: ");
            int largeCarpet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");

            int cost = (smallCarpet * 25 + largeCarpet * 35);
            double tax = cost * 0.06;

            Console.WriteLine($"Cost : {cost}");
            Console.WriteLine($"Tax : {tax}");

            Console.WriteLine("========================");
            Console.WriteLine($"Total Estimat: {cost + tax}");
            Console.WriteLine($"This estimate is valid for 30 days");




         


        }
    }
}

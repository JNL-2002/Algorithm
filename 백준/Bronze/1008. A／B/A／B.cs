using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            decimal a = decimal.Parse(input[0]);
            decimal b = decimal.Parse(input[1]);

            Console.WriteLine(a / b);
        }
    }
}
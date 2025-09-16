using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int input2 = int.Parse(Console.ReadLine());
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]) + input2;

            int value = A + (B / 60);

            if (A == value)
            {
                Console.WriteLine(A + " " + B);
            }
            else
            {
                Console.WriteLine((value >= 24 ? value-24 : value) + " " + B % 60);
            }    
        }
    }
}
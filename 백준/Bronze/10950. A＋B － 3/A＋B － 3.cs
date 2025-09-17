using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] result = new int[input];
            

            for (int i = 0; i < input; i++)
            {
                string[] value = Console.ReadLine().Split();
                result[i] = int.Parse(value[0]) + int.Parse(value[1]);
            }

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
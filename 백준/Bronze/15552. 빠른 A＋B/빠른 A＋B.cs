using System;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input; i++)
            {
                string[] value = Console.ReadLine().Split(' ');
                int a = int.Parse(value[0]);
                int b = int.Parse(value[1]);
                output.AppendLine((a + b).ToString());
            }

            Console.Write(output);
        }
    }
}
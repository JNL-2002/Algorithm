using System;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();

            while (true)
            {
                string[]? value = Console.ReadLine()?.Split(' ');

                if (value == null || value.Length < 2)
                    break;

                int a = int.Parse(value[0]);
                int b = int.Parse(value[1]);
                output.AppendLine((a + b).ToString());
            }

            Console.Write(output.ToString());
        }
    }
}
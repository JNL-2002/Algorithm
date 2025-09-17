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
                for (int j = 0; j <= i; j++)
                {
                    output.Append("*");
                }
                output.AppendLine();
            }

            Console.WriteLine(output);
        }
    }
}
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
                for (int j = input; j > i+1; j--)
                {
                    output.Append(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    output.Append("*");
                }

                output.AppendLine();
            }

            Console.WriteLine(output);
        }
    }
}

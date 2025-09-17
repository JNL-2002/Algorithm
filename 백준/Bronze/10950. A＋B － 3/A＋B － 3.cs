using System;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < input; i++)
            {
                string[] value = Console.ReadLine().Split();
                sb.Append(int.Parse(value[0]) + int.Parse(value[1]) + "\n");
            }

            Console.WriteLine(sb);
        }
    }
}
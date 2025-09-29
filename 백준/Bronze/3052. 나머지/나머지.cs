using System;
using System.Text;
using System.IO;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int[] arr = new int[10];
            var set = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
                set.Add(arr[i] % 42);
            }

            sb.Append(set.Count);
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}
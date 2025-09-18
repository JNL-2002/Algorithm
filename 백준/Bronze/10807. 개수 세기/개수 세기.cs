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

            int[] N = new int[int.Parse(sr.ReadLine())];
            string[] value = sr.ReadLine().Split();
            int V = int.Parse(sr.ReadLine());

            int index = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (int.Parse(value[i]) == V)
                    index++;
            }

            sb.Append(index);
            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
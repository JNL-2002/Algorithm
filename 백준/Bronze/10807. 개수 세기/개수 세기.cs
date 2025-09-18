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

            foreach (string v in value)
            {
                if (int.Parse(v) == V)
                    index++;
            }

            sb.Append(index);
            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
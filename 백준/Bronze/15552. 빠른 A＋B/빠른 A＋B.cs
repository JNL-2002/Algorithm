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

            int T = int.Parse(sr.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] value = sr.ReadLine().Split();
                int a = int.Parse(value[0]);
                int b = int.Parse(value[1]);
                sb.AppendLine((a + b).ToString());
            }

            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
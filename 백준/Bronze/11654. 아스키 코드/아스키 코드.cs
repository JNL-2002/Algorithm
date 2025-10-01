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

            char[] c = sr.ReadLine().ToCharArray();
            int sum = c[0];

            sb.AppendLine(sum.ToString());

            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
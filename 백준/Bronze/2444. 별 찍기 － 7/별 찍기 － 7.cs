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

            int n = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    sb.Append(" ");
                }
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }

            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 1; j < n - i; j++)
                {
                    sb.Append(" ");
                }
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }


            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
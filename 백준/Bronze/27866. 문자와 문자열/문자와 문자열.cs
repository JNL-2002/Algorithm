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

            string input = sr.ReadLine();
            int num = int.Parse(sr.ReadLine())-1;

            sb.Append(input[num]);
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}
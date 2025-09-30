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

            int num = int.Parse(sr.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string str = sr.ReadLine();
                sb.AppendLine($"{str[0].ToString()}{str[str.Length-1].ToString()}");
            }
            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
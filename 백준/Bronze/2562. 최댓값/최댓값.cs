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

            int[] value = new int[9];

            int max = 0;
            int nub = 0;

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = int.Parse(sr.ReadLine());
                if (max < value[i])
                {
                    max = value[i];
                    nub = i + 1;
                }
            }

            sb.Append(max + "\n" + nub);

            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
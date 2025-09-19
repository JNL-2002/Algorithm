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

            int N = int.Parse(sr.ReadLine());
            int[] index = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int max = index[0];
            int min = index[0];

            for (int i = 1; i < N; i++)
            {
                if (max < index[i])
                    max = index[i];
                else if (min > index[i])
                    min = index[i];
            }

            sb.Append(min + " " + max);

            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
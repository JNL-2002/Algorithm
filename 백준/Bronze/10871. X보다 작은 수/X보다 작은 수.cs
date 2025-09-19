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

            int[] N = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] index = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for (int i = 0; i < N[0]; i++)
            {
                if (index[i] < N[1])
                {
                    sb.Append(index[i] + " ");
                }
            }

            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
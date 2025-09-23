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

            int[] value = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            
            int[] bk = new int[value[0]];

            int[] arr = new int[3];

            for (int i = 0; i < value[1]; i++)
            {
                arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = arr[0] - 1; j < arr[1]; j++)
                {
                    bk[j] = arr[2];
                }
            }

            for (int i = 0; i < bk.Length; i++)
            {
                sb.Append(bk[i] + " ");
            }

            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
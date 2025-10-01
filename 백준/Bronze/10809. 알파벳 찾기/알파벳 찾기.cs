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
            int[] arr = new int[26];

            Array.Fill(arr, -1);

            for (int i = 0; i < c.Length; i++)
            {
                if (arr[c[i] - 97] == -1)
                    arr[c[i] - 97] = i;
            }

            foreach (var item in arr)
            {
                sb.Append(item + " ");
            }

            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
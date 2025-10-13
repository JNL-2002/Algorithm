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
            int[] alpha = new int[26];
            int max = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] >= 97)
                {
                    c[i] -= (char)32;
                }
                alpha[c[i] - 65]++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (alpha[i] > max)
                {
                    max = alpha[i];
                    sb.Clear();
                    sb.Append((char)(i + 65));
                }
            }

            Array.Sort(alpha);
            Array.Reverse(alpha);
            if (alpha[0] == alpha[1])
            {
                sb.Clear();
                sb.Append("?");
            }

            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
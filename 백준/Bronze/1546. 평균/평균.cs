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
            float[] arr = Array.ConvertAll(sr.ReadLine().Split(), float.Parse);

            float num = 100;
            float result = 0;

            Array.Sort(arr);
            Array.Reverse(arr);

            if (arr.Length == 1)
            {
                result = num;
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    result += arr[i] / arr[0] * num;
                }

                result += num;
                result /= n;
            }

            sb.Append(result);
            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}
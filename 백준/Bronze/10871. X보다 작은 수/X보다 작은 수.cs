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

            string[] N = sr.ReadLine().Split();
            string[] index = sr.ReadLine().Split();
            int count = 0;

            for (int i = 0; i < int.Parse(N[0]); i++)
            {
                count = int.Parse(index[i]);
                if (count < int.Parse(N[1]))
                {
                    sb.Append(count + " ");
                }
            }

            sw.WriteLine(sb);
            sr.Close();
            sw.Close();
        }
    }
}
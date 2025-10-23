using System;
using System.Text;
using System.IO;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
                string s = Console.ReadLine();

                s = s.Replace("c=", "*");
                s = s.Replace("c-", "*");
                s = s.Replace("dz=", "*");
                s = s.Replace("d-", "*");
                s = s.Replace("lj", "*");
                s = s.Replace("nj", "*");
                s = s.Replace("s=", "*");
                s = s.Replace("z=", "*");

                Console.WriteLine(s.Length);

        }
    }
}
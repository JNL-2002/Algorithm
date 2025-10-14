using System;

public class Example
{
    public static void Main()
    {
        char[] c = Console.ReadLine().ToCharArray();
        
        for (int i = 0; i < c.Length; i++)
        {
            if (c[i] >= 65 && c[i] <= 90)
            {
                c[i] = (char) (c[i] + 32);
                Console.Write(c[i]);
                continue;
            } 
            else if (c[i] >= 97 && c[i] <= 122)
            {
                c[i] = (char) (c[i] - 32);
                Console.Write(c[i]);
            }
        }
        
    }
}
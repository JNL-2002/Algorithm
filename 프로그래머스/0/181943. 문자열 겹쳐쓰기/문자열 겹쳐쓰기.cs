using System;
using System.Text;

public class Solution {
    public string solution(string a, string b, int s) {
        char[] result = a.ToCharArray();
        int val = s;
        
        for (int i = 0; i < b.Length; i++)
        {
            result[val] = b[i];
            val++;
        }
        
        string sTresult = new string(result);
        
        return sTresult;
    }
}
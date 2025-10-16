using System;

public class Solution {
    public string solution(string str1, string str2) {
        string result = "";
        
        for (int i = 0; i < str1.Length; i++)
        {
            result += $"{str1[i]}{str2[i]}";            
        }
        return result;
    }
}
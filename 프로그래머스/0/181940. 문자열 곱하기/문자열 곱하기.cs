using System;

public class Solution {
    public string solution(string my_string, int k) {
        string answer = my_string;
        for (int i = 1; i < k; i++)
        {
            answer += my_string; 
        }
        return answer;
    }
}
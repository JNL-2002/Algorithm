using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = Int32.Parse(a.ToString() + b.ToString());
        
        if (2 * a * b > answer) {
            answer = 2 * a * b;
        }
        
        return answer;
    }
}
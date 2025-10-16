using System;

public class Solution {
    public int solution(int num, int n) {
        int answer = num % n;
        
        if (answer > 0)
        {
            return 0;
        }
        return 1;
    }
}
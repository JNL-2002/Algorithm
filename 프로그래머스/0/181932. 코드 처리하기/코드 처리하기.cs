using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        bool mode = true;
        
        for (int i = 0; i < code.Length; i++)
        {
            if (code[i].ToString() == "1")
            {
                if (mode == false)
                {
                    mode = true;
                    continue;
                }
                mode = false;
                continue;
            }
                
            if (mode)
            {
                if (i % 2 == 0)
                {
                    answer += code[i];
                }
                continue;
            }
            
            if (i % 2 > 0)
            {
                answer += code[i];
            }
        }
        
        if (answer.Length == 0)
        {
            return "EMPTY";
        }
        return answer;
    }
}
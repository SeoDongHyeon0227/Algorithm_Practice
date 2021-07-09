using System;
public class Solution {
    public bool solution(string s) {
        bool answer = false;
        
        // 숫자로만 구성됐는지
        char[] chr = s.ToCharArray();
        bool num = true;
        foreach(char i in chr){
            int a = Convert.ToInt32(i);
            if(a >= 48 && a <= 57)
                num = true;
            else{
                num = false;
                break;
            }
                
        }
        
        // 길이 4 또는 6인지
        if (s.Length == 4 || s.Length == 6){
            if(num == true)
                answer = true;
        }
        
        return answer;
    }
}

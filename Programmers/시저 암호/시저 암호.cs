using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, int n) {
        char[] arr = s.ToCharArray();
        List<char> list = new List<char>();
        
        foreach (char i in arr){
          int a = Convert.ToInt32(i);
          char abc;
          if (a+1 != 33){
              if(a+n > 122){
                  abc = Convert.ToChar(a+n-26);
              }
              else if(a+n > 90 && a < 91){
                  abc = Convert.ToChar(a+n-26);
              }
              else
                  abc = Convert.ToChar(a+n);
          }
          else
            abc = Convert.ToChar(a);
          list.Add(abc);
        }
        
        string result = new string(list.ToArray());
        return result;
    }
}

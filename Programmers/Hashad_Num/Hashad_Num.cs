using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(int input_int) {
        
        string input_str = Convert.ToString(input_int);

        // 자릿수 개수
        int input_str_len = input_str.Length;

        // 각 자리 숫자 저장할 리스트 생성
        List<int> list = new List<int>();

        // 각 자리 숫자 배열 저장
        int sum = 0;
        for (int i = 0; i < input_str_len; i++)
        {
            list.Add(Convert.ToInt32(input_str.Substring(i, 1)));

            sum += list[i];
        }

        // 나머지 0이면 하샤드 수
        bool answer = false;
        if (input_int % sum == 0)
        {
            answer = true;
        }
        return answer;
    }
}

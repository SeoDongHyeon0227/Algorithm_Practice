using System;

namespace Programmers_phone_number
{
    class Program
    {
        static void Main(string[] args)
        {
            solution("1234567890");
        }
        static string solution(string phone_number)
        {
            string answer = "";

            //전화번호 끝 네 자리 뽑기
            string last_num = phone_number.Substring(phone_number.Length-4, 4);

            // 마지막 네 자리를 제외하고 넣을 별 개수
            for (int i = 0; i < phone_number.Length - 4; i++)
            {
                answer += "*";
            }
            
            Console.WriteLine($"{answer}{last_num}");
            return answer + last_num;
            

        }
    }
}


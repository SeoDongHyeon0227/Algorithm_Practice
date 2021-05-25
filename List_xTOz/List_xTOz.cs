using System;
using System.Collections.Generic;

namespace x_n
{
    class Program
    {
        public static List<int> solution(int x, int n)  //바보같이 리턴 타입에 List<int>를 안 넣고 있어서 계속 헤맸다. 다음엔 이런 실수하지 않도록 하기.
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                list.Add(x * i);
            }

            foreach (int i in list)
                Console.Write(i + " ");

            return list;

        }
        static void Main(string[] args)
        {
            solution(2, 5);
        }
    }
}


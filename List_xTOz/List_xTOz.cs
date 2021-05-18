using System;
using System.Collections.Generic;

namespace x_n
{
    class Program
    {
        public static List<int> solution(int x, int n)
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


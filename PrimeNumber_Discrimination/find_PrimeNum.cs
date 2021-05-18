using System;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 입력 받은 수까지의 소수 구하기
            string str_length = Console.ReadLine();
            int int_length = Convert.ToInt32(str_length);

            int[] arr = new int[int_length];
            for (int i = 0; i < int_length; i++)
            {
                arr[i] = i + 1;
            }


            int count = 0;

            for (int j = 1; j < int_length; j++)
            {
                for ( int k = 1; k <= j+1; k++)
                {
                    if (arr[j] % k == 0)
                        count += 1;
                }
                if (count == 2)
                    Console.Write(arr[j] + " ");
                count = 0;
            }    
        }
    }
}

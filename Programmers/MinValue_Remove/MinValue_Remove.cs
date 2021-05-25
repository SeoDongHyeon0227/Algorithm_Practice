using System;

// 확장 메소드 사용
using System.Collections.Generic;
using System.Linq;

namespace MinValue_Remove
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,32,5,6,3,7,4 };
            solution(arr);
        }
        public static int[] solution(int[] arr)
        {
            // 각 요소 제거하기 위해 List로 치환
            // List는 동적(데이터 크기 정해져있지 않음, 추가삽입 삭제 가능) 검색이 적은경우 유리.
            // Array는 정적(데이터 크기가 정해져있음, 추가삽입 삭제가 되지 않음) 검색이 필요할 때.
            List<int> arr_list = new List<int>(arr);

            // Linq 확장메소드 사용. 해당 Array 혹은 List에서 Min, Max, Sum 값을 구할 수 있음
            int min = arr.Min();

            // ( ) 안에 조건을 만족하는 원소들 모두 삭제
            // x == min 조건을 만족하는 요소 모두 제거
            arr_list.RemoveAll(x => x == min);

            if (arr_list.Count == 0)
                arr_list.Add(-1);

            foreach (int i in arr_list.ToArray())
                Console.Write(i + " ");


            return arr_list.ToArray();
        

        }
    }
}

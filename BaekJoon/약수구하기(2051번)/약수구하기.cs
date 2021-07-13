using System;

class MainClass{
  public static void Main(string[] args){
  
    /*
    Console.Write("약수 판단할 수 : ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("K 번째로 작은 수 (K 입력) : ");
    int K = Convert.ToInt32(Console.ReadLine());
    */
    
    // 백준 문제에 맞게 한 줄에 입력받게 함
    string[] a = (Console.ReadLine()).Split();
    int N = int.Parse(a[0]);
    int K = int.Parse(a[1]);

    int sum = 0;
    for(int i = 1 ; i <= N ; i++){
      if(N % i == 0){
        sum += 1;
      }
    }
    int[] arr = new int[sum];
    
    int tmp = 0;
    for(int i = 1 ; i <= N ; i++){
      if(N % i == 0){
        arr[tmp] = i;
        tmp ++;
      }
    }

    try{
      Console.WriteLine(arr[K-1]);
    }
    catch(IndexOutOfRangeException e){
      Console.WriteLine(0);
    }
  }
}

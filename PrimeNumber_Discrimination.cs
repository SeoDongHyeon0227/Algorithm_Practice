using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool result = TF();
            Console.WriteLine(result);
          
        }
        public static bool TF()
        {
            int i;
            Console.Write("수를 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());

            bool A = true;

            for (i = 2; i < input; i++)
            {
                if ((input % i) == 0)
                {
                    A = false;
                    break;
                }
                else if ((input % i) != 0)
                {
                    continue;
                }
            }
            return A; 
        }
    }
}

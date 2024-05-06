using System;

namespace A019_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // y = int.MaxValue + 10; // 컴파일 에러 발생
            int x = int.MaxValue, y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
            // 오버플로우가 발생해 0이 출력됨
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A019_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue, y = 0; //Int32 최대값 2,147,483,647

            //y = x + 10; //최대값보다 10 오버플로우되어 -2,147,483,639가 출력 
            //Console.WriteLine("int.MaxValue + 10 = {0}", y);

            checked //오버플로우 예외를 발생한다.안하는 경우 실행이 계속됨 
            {
                try
                {
                    y = x + 10; //오버플로우 예외
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y); //변수 y의 값은 0으로 출력된다. 
        }
    }
}

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
            //01. 오버플로 메세지 표현 실패 코드. 오버플로 해서 음수로 나타난다.
            //Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            //int x = int.MaxValue, y = 0;
            //y = x + 10;
            //Console.WriteLine("int.MaxValue + 10 = {0}", y);

            // y = int.MaxValue + 10; 오류 나타나게 함.
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
        }
    }
}

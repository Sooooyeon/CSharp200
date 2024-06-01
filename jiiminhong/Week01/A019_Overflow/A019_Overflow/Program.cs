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
            /*
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue, y = 0;
            y = x + 10;
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
            */



            // y = int.MaxValue + 10; // 이 문장은 컴파일할 때 에러가 나옴
            int x = int.MaxValue, y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}

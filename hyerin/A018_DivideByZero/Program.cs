using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A018_DivideByZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;
            
            Console.WriteLine(10.0 / y); //실수를 0으로 나눠 예외가 아닌 무한대 출력
            
            try
            {
                Console.WriteLine(x / y); //y값이 0이기 때문에 예외 발생
            }
            catch(Exception e) //Exception 클래스 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

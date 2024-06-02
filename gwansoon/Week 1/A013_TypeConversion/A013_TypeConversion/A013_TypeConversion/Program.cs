using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A013_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num; //암시적 형변환. 위의 인트값은 int값의 맥스치.
            Console.WriteLine(bigNum); 

            double x = 1234.5;
            int a;

            a = (int)x; //명시적 변환, 소수점은 잘려서 버려진다.
            Console.WriteLine(a);
        }
    }
}

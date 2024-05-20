using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A033_ConstAndReadonly
{
        class ConstEx
        {
            public const int number = 3;
        }
        class ReadonlyEx
        {
            public readonly int number = 10;
            public ReadonlyEx()
            {
                number = 20;
            }
            public ReadonlyEx(int n)
            {
                number = n;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(ConstEx.number); //const사용->선언 시 값 할당(컴파일)

            ReadonlyEx inst1 = new ReadonlyEx(); //readonly사용->실행 또는 생성자 초기화 시 값 할당 (런타임)
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);
        }
    }
}

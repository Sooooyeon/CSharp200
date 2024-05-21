using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A033_ConstAndReadonly
{
    // ConstEx 클래스 정의
    class ConstEx
    {
        // number의 값을 변경할수 없음
        public const int number = 3;
    }

    // ReadonlyEx 클래스 정의
    class ReadonlyEx
    {
        public readonly int number = 10;
        // 매개변수가 없는 생성자
        public ReadonlyEx() 
        {
            number = 20;
        }

        // int 매개변수를 갖는 생성자
        public ReadonlyEx(int n)
        {
            number = n;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // const number 출력
            Console.WriteLine(ConstEx.number);

            // readonly number 출력
            ReadonlyEx inst1 = new ReadonlyEx();
            Console.WriteLine(inst1.number);

            // readonly number 출력
            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);

        }
    }
}

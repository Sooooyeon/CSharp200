using System;

namespace A033_ConstAndReadonly
{
    class ConstEx
    {
        // const - 선언될 때 값이 할당됨
        public const int number = 3;
    }

    class ReadonlyEx
    {
        // readonly - 실행될 때 또는 객체가 생성자에 의해 초기화 될 때 값이 할당됨
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
            Console.WriteLine(ConstEx.number); // const 사용

            ReadonlyEx inst1 = new ReadonlyEx(); // readonly 사용
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100); // readonly 사용
            Console.WriteLine(inst2.number);
        }

    }

}
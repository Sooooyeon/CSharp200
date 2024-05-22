using System;

namespace A034_ValueAndReference
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "before passing";
            Console.WriteLine(s);
            //before passing 출력

            Test(s);
            Console.WriteLine(s);
            //before passing 출력

            Test(ref s);
            Console.WriteLine(s);
            //sting s 값 변화
            //after passing 출력
        }

        public static void Test(string s)
        {
            s = "after passing";
        }

        public static void Test(ref string s)
        {
            s = "after passing";
        }
    }
}

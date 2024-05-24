using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A034_ValueAndReference
{
    internal class Program
    {
        // Test 정적 메서드 생성
        public static void Test(string s)
        {
            s = "after passing";
        }

        public static void Test(ref string s)
        {
            s = "after passing";
        }
        static void Main(string[] args)
        {
           
            string s = "before passing"; 
            Console.WriteLine(s); //  출력: before passing

            Test(s);
            Console.WriteLine(s); // 출력: before passing

            Test(ref s);
            Console.WriteLine(s); // 출력: after passing
        }
    }
}

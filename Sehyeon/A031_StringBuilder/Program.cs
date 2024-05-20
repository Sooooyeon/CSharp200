using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace A031_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string buffer = "The numbers are: ";
            //for(int i = 0; i < 3; i++)
            //{
            //    buffer += i.ToString();
            //}

            StringBuilder sb = new StringBuilder("This is a StringBuilder Test.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);


            // sb 초기화
            sb.Clear();
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            // 문자열을 뒤에 추가
            sb.Append("This is a new string.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            // sb의 5번째 위치에 "xyz"을 2번 삽입
            sb.Insert(5, "xyz ", 2);
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            // sb의 5번째 위치에 4개의 문자를 삭제함
            sb.Remove(5, 4);
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            // sb 메소드에서 xyz를 abc로 대체
            sb.Replace("xyz", "abc");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            Stopwatch time = new Stopwatch();
            string test = string.Empty; // 빈문자열
            time.Start();
           
            for(int i =0; i<100000; i++)
            {
                test += i;
            }
            time.Stop();
            Console.WriteLine("String: " + time.ElapsedMilliseconds + "ms");


            StringBuilder test1 = new StringBuilder();
            time.Reset();
            time.Start();
            for(int i = 0; i < 100000; i++)
            {
                test1.Append(i);
            }
            time.Stop();
            Console.WriteLine("StringBuilder: " + time.ElapsedMilliseconds + "ms");
        }
    }
}

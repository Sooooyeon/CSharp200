using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A0321_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is a StringBuilder Test.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);
            
            sb.Clear(); //초기화
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);
            
            sb.Append("This is a new string."); //추가
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Insert(5, "xyz ", 2); //5인덱스에 문자 2번추가
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Remove(5, 4); //5인덱스의 4개 문자 삭제 
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Replace("xyz", "abc"); //대치
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            Stopwatch time = new Stopwatch(); 
            string test = string.Empty; 
            time.Start();

            for(int i = 0; i <100000; i++)
            {
                test += i; //시간을 측정한 값을 test에 문자열로 추가 
            }

            time.Stop();
            Console.WriteLine("String: " + time.ElapsedMilliseconds + "ms");

            StringBuilder test1 = new StringBuilder();
            time.Reset();
            time.Start();
            for(int i=0; i<100000; i++)
            {
                test1.Append(i);
            }
            time.Stop();
            Console.WriteLine("String: " + time.ElapsedMilliseconds + "ms");
            //String 사용시 17초이상, StringBuilder 사용시 12밀리초이므로 빈번한 변경 효율적
        }
    }
}

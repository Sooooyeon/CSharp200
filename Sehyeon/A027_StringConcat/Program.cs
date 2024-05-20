using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A027_StringConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "hyonie";
            string date = DateTime.Today.ToShortDateString();

            // + 연산자 사용
            string strPlus = "Hello " + userName + ". Today is " + date + ".";
            Console.WriteLine(strPlus);

            //String.Format() 메소드 사용
            string strFormat = String.Format("Hello {0}. Today is {1}.", userName, date);
            Console.WriteLine(strFormat);

            // 문자열 보간
            string strInterpolation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterpolation);

            // String.Concat()
            string strConcat = String.Concat("Hello ", userName, ". Today is ", date, ".");
            Console.WriteLine(strConcat);

            // String.Join()
            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animals);
            s = String.Join(", ", animals);
            Console.WriteLine(s);

        }
    }
}

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
            string userName = "bikang";
            string date = DateTime.Today.ToShortDateString(); //오늘 날짜로 초기화

            string strPlus = "Hello " + userName + ". Today is " + date + ".";
            Console.WriteLine(strPlus); //그냥 출력 중간에 +로 이어주기

            string strFormat = String.Format("Hello {0}. Today is {1}.", userName, date);
            Console.WriteLine(strFormat); //Foramt{0}으로 이어주기

            string strInterpolation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterpolation); //$ { Method }로 이어주기

            string strConcat = String.Concat("Hello ", userName, ". Today is ", date, ".");
            //Concat으로 ,로 구분한 문자열 연결 

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };//초기화
            string s = String.Concat(animals);//다 잇고 
            Console.WriteLine(s); //다 이어져서 출력 
            s = String.Join(",", animals); //,로 구분하여 출력 
            Console.WriteLine(s);
        }
    }
}

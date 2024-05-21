using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A029_StringFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string max = String.Format("0x{0:x} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(max);
            //16진수형, 지수형, 구분자 숫자형으로 변환, 형식만 다른 같은 값
            Decimal exchangeRate = 1129.20m;

            string s = String.Format("현재 원달러 환율은{0}입니다.", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("현재 원달러 환율은 {0:C2}입니다.", exchangeRate);
            Console.WriteLine(s); //0:C = \표시, 3자리 컴마, 2는 소수점 자리수

            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t}입니다.", DateTime.Now);
            Console.WriteLine(s);

            TimeSpan duration = new TimeSpan(1, 12, 23, 62); //구조체 변수 
            string output = string.Format("소요 시간: {0:c}", duration); //1.12:24:02
            Console.WriteLine(output);
        }
    }
}

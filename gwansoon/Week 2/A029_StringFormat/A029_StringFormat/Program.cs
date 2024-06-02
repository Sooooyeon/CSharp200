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
            //0x7fffffffffffffff 9.223372E+018 9,223,372,036,854,775,807.00

            Decimal excahngeRate = 1129.20m;

            string s = String.Format("현재 원달러 환율은 {0}입니다.", excahngeRate);
            Console.WriteLine(s);
            //현재 원달러 환율은 1129.20입니다.

            s = String.Format("현재 원달러 환율은 {0:C2}입니다.", excahngeRate);
            Console.WriteLine(s);
            //현재 원달러 환율은 \1,129.20입니다.

            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t} 입니다.", DateTime.Now);
            Console.WriteLine(s);
            //오늘 날짜는 2024-05-14, 시간은 오후 11:05 입니다.

            TimeSpan duration = new TimeSpan(1, 12, 23, 62);
            string output = String.Format("소요시간 : {0:c}", duration);
            Console.WriteLine(output);
            //소요시간 : 1.12:24:02
        }
    }
}

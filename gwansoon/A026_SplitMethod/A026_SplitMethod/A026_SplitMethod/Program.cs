using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A026_SplitMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("더하고자 하는 숫자들을 입력하세요 : "); //15 20 30 35 46 77
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            foreach(var i in v)
            {
                sum += int.Parse(i); //내부에서 sum에 15+20+30+35+46+77 한다
            }
            Console.WriteLine("결과는 {0}", sum); //결과값 투영 결과는 223
        }
    }
}

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
            Console.Write("더하고자 하는 숫자들을 입력하세요: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split(); //엔터전까지 입력 후 공백으로 배열 나누기 
            foreach(var i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과는 {0}", sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A015_Covert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("첫 번째 숫자를 입력하세요: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);

            //2진수, 8진수, 10진수, 16진수로 출력하기
            short value = short.MaxValue; //short = Int16 의 최대값 
            Console.WriteLine("\n 2진수, 8진수, 10진수, 16진수로 출력하기");

            int baseNum = 2; //진수값을 2진수로 초기화
            string s = Convert.ToString(value, baseNum); //value를 baseNum진수로 문자열로 변환 
            int i = Convert.ToInt32(s, baseNum); //s를 baseNum진수로 인트형변환 
            Console.WriteLine("i = {0}, {1,2}진수={2,16}", i, baseNum, s);
            //{1,2} {2,16}은 뒷 자리는 나타낼 자릿수이며 남는 앞자리수는 공백으로 채워짐

            baseNum = 8;
            s = Convert.ToString(value, baseNum); 
            i = Convert.ToInt32(s, baseNum); 
            Console.WriteLine("i = {0}, {1,2}진수={2,16}", i, baseNum, s);

            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수={2,16}", i, baseNum, s);

            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수={2,16}", i, baseNum, s);
        }
    }
}

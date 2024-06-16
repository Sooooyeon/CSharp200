using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A058_ArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 25, 75, 35, 15 }; // 배열을 선언하고 초기화
            PrintArray(a);

            int[] b;
            b = (int[])a.Clone(); // 배열 복사 방법 1

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3);  // 배열 복사 방법 2
            PrintArray(c);

            a.CopyTo(c, 3); // 배열 복사 방법 3
            PrintArray(c);

            Array.Sort(a); // 오름차순으로 정렬
            PrintArray(a);

            Array.Reverse(a); // 내림차순으로 정렬
            PrintArray(a);

            Array.Clear(a, 0, a.Length); // 배열을 초기화
            PrintArray(a);
        }
        private static void PrintArray(int[] a)
        {
            foreach (var i in a)
                Console.Write("{0,5}",i);
            Console.WriteLine();
        }
    }
}

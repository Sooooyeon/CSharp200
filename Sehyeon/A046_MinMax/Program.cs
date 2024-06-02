using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A046_MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue; // max는 double 표현할 수 있는 가장 작은 값
            double min = double.MaxValue; // min는 가장 큰 값을 할당
            double sum = 0;

            for (int i =0; i <5; i++)
            {
                Console.WriteLine("키를 입력하세요(단위: cm) : ");
                double h = double.Parse(Console.ReadLine());
                if (h > max)
                    max = h;
                if (h < min)
                    min = h;
                sum += h;
            }
            Console.WriteLine("평균: {0}cm, 최대: {1}cm, 최소 {2}cm", sum/5, max, min);
        }
    }
}

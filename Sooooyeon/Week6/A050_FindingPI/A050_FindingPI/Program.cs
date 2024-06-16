
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A050_FindingPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sign = false;
            double pi = 0;

            for(int i =1; i <= 10000; i += 2)
            {
                if(sign == false)
                {
                    pi += 1.0 / i;
                    sign = true;
                }
                else
                {
                    pi -= 1.0 / i;
                    sign = false;
                }
                Console.WriteLine("i = {0}, PI ={1}",i, 4*pi);
            }
        }
    }
}

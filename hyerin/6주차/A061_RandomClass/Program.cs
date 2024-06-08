using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A061_RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("{0, -16}", "Random Bytes");
            Byte[] b = new byte[5];
            r.NextBytes(b);

            foreach(var x in b)
                Console.Write("{0,12}", x);
            Console.WriteLine();

            Console.Write("{0,-16}", "Random Double");
            double[] d = new double[5];

            for(int i = 0; i < 5; i++)
                d[i] = r.NextDouble();

            foreach (var x in d)
                Console.Write("{0,12:F8}", x);
            Console.WriteLine();

            Console.Write("{0,-16}", "Random Int32");
            int[] a = new int[5];

            for (int i = 0; i < 5; i++)
                a[i] = r.Next();
            PrintArray(a);

            Console.Write("{0,-16}", "Random 0~99");
            int[] v = new int[5];

            for(int i = 0; i < 5; i++)
                v[i] = r.Next();
            PrintArray(v);
        }
        private static void PrintArray(int[] v)
        {
            foreach (var value in v)
                Console.Write("{0,12}", value);
            Console.WriteLine();
        }
    }
}

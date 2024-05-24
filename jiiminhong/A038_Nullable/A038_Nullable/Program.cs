using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A038_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            Console.WriteLine(i.GetValueOrDefault());

            if (i.HasValue)
                Console.WriteLine(i.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine("Null");

            int? x = null;
            int j = x ?? 0;
            Console.WriteLine("x = {0}, j = {1}", x, j);

            Console.WriteLine("x >= 10 ? {0}", x >= 10);
            Console.WriteLine("x < 10 ? {0}", x < 10);

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("j < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");
        }
    }
}

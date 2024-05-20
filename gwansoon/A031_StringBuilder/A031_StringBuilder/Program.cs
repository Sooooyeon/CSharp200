using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A031_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is a SringBuilder Test.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);
            //This is a SringBuilder Test. (28 characters)

            sb.Clear();
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);
            // (0 characters)

            sb.Append("This is a new string");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);
            //This is a new string (20 characters)

            sb.Insert(5, "xyz ", 2);
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);
            //This xyz xyz is a new string (28 characters)

            sb.Remove(5, 4);
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);
            //This xyz is a new string (24 characters)

            sb.Replace("xyz", "abc");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);
            //This abc is a new string (24 characters)

            Stopwatch time = new Stopwatch();
            string test = string.Empty;
            time.Start();
            for (int i  = 0; i < 100000; i++)
            {
                test += i;
            }
            time.Stop();
            Console.WriteLine("String: " + time.ElapsedMilliseconds+ " ms");
            //String: 15788 ms

            StringBuilder test1 = new StringBuilder();
            time.Reset();
            time.Start();
            for(int i = 0; i < 100000; i++)
            {
                test1.Append(i);
            }
            time.Stop();
            Console.WriteLine("StringBuilder: " + time.ElapsedMilliseconds + " ms");
            //StringBuilder: 9 ms
        }
    }
}

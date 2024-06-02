using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A034_ValueAndReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "before passing";
            Console.WriteLine(s); // before passing

            Test(s);
            Console.WriteLine(s); // before passing

            Test(ref s);
            Console.WriteLine(s); // after passing
        }

        public static void Test(string s)
        {
            s = "after passing";
        }

        public static void Test(ref string s)
        {
            s = "after passing";
        }
    }
}

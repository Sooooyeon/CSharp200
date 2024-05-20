using System;

namespace A034_ValueAndReference
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "before passing";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s);

            Test(ref s);
            Console.WriteLine(s);
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
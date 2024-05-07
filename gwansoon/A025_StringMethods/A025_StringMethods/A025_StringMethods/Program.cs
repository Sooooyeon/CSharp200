using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A025_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello, World! ";
            string t;
            
            Console.WriteLine(s.Length); // 15
            Console.WriteLine(s[8]); // W
            Console.WriteLine(s.Insert(8, "C# ")); //  Hello, C# World!
            Console.WriteLine(s.PadLeft(20, '.')); // ..... Hello, World!
            Console.WriteLine(s.PadRight(20, '.')); //   Hello, World! .....
            Console.WriteLine(s.Remove(6)); //   Hello
            Console.WriteLine(s.Remove(6,7)); // Hello!
            Console.WriteLine(s.Replace('1', 'm')); //  Hello, World!
            Console.WriteLine(s.ToLower()); // hello, world!
            Console.WriteLine(s.ToUpper()); // HELLO, WORLD!
            Console.WriteLine('/' + s.Trim() + '/'); // /Hello, World!/
            Console.WriteLine('/' + s.TrimStart() + '/'); // /Hello, World! /
            Console.WriteLine('/' + s.TrimEnd() + '/'); //  / Hello, World!/

            string[] a = s.Split(','); 
            foreach (var i in a)
                Console.WriteLine('/' + i + '/'); // / Hello/

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6); // / World! /
            Console.WriteLine(destination); // World!

            Console.WriteLine('/' + s.Substring(8) + '/'); // /World! /
            Console.WriteLine('/' + s.Substring(8, 5) + '/'); // /World/

            Console.WriteLine(s.Contains("11")); // False
            Console.WriteLine(s.IndexOf('o')); // 5
            Console.WriteLine(s.LastIndexOf('o')); // 9
            Console.WriteLine(s.CompareTo("abc")); // -1

            Console.WriteLine(String.Concat("Hi~", s)); // Hi~ Hello, World!
            Console.WriteLine(String.Compare("abc", s)); // 1
            Console.WriteLine(t = String.Copy(s)); // Hello, World!

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(",", val); 
            Console.WriteLine(result); // apple,orange,grape,pear
        }
    }
}

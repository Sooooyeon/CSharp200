using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A025_StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello, World";
            string t;

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);
            Console.WriteLine(s.Insert(8, "C#"));
            Console.WriteLine(s.PadLeft(20,'.'));
            Console.WriteLine(s.PadRight(20,'.'));
            Console.WriteLine(s.Remove(6,7));
            Console.WriteLine(s.Replace('1','m'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');
            Console.WriteLine('/' + s.TrimStart() + "/");
            Console.WriteLine('/' + s.TrimEnd() + "/");

            string[] a = s.Split(new char[10]);
            foreach(var i  in a) 
                Console.WriteLine('/'+ i + '/') ;

            char[] destination = new char[10]
                s.CopyTo(8, destination, 0, 6);
            Console.WriteLine(destination);
        }
    }
}

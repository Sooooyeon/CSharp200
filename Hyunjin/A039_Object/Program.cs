using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A039_Object
{
     class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i = i + 10;
            int j  = (int)o;

            Console.WriteLine("The value-type value i = {0}",i);
            Console.WriteLine("The value-type value o = {0}",o);
            Console.WriteLine("The value-type value j = {0}", j);

            object p = o;
            o = 100;
            Console.WriteLine("The object-type value o ={0}", o);
            Console.WriteLine("The object-type value p ={0}", p);



        }
    }
}

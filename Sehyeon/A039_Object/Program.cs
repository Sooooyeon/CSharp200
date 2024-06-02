using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A039_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i = i + 10;
            int j = (int)o;

            // i의 값이 변해도 o에 저장된 값은 영향을 받지 않는다.
            Console.WriteLine("The value-type value i = {0}", i);
            Console.WriteLine("The objec-type value o = {0}", o);
            Console.WriteLine("The value-type value j = {0}", j);


            object p = o;
            o = 100;
            Console.WriteLine("The object-type o = {0}", o);
            Console.WriteLine("The object-type p = {0}",p);

        }
    }
}

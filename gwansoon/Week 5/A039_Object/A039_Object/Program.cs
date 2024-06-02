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

            // i의 값이 변해도 o에 저장된 값은 영향을 받지 않습니다.
            Console.WriteLine("The value-type vale i = {0}", i); // 133
            Console.WriteLine("The object-type vale o = {0}", o); // 123 
            Console.WriteLine("The value-type vale j = {0}", j); // 123

            object p = o;
            o = 100;
            Console.WriteLine("The object-type vale o = {0}", o); // 100
            Console.WriteLine("The object-type vale p = {0}", p); // 123

        }
    }
}

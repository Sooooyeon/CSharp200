using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A028_StringContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "Cow";
            bool b = s1.Contains(s2); //s2가 s1에 포함되었는지 확인 
            Console.WriteLine("'{0}' is in the string '{1}':{2}", s2, s1, b);

            if(b)
            {
                int index = s1.IndexOf(s2); //s2가 s1에 몇 번째 인덱스에 위치하는지 
                if (index >= 0)
                    Console.WriteLine("'{0} begins at index {1}", s2, index);
            }

            if (s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0) ;
            {
                Console.WriteLine("'{0}' is in the string '{1}'", s2, s1);
                //s리턴값이 -1이라면 없다, 0이상은 포함되어 있다 
            }
        }
    }
}

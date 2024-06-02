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
            string s2 = "Cow"; // s2 = "cow";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the sring '{1}': {2}", s2, s1, b);
            //'Cow' is in the sring 'mouse, cow, tiger, rabbit, dragon': False
            //'Cow' is in the sring 'mouse, cow, tiger, rabbit, dragon'

            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at index {1}", s2, index);

            }

            if (s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                Console.WriteLine("'{0}' is in the sring '{1}'", s2, s1);
            }
        }
    }
}

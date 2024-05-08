using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18_DivideByZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;

            try
            {
                Console.WriteLine(x / y);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}

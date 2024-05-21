using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A018_DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10; 
            int y = 0;

            try
            {
                Console.WriteLine(x / y);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

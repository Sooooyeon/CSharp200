using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace A019_Overlflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MinValue, y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch(Exception e) {
                
                }            
            }
                Console.WriteLine("int.MaxValue + 10 = {0}",y);
           
        }
    }
}

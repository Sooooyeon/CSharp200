using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A027_StringConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "bikang";
            string date = DateTime.Today.ToString();

            string strPlus = "Hello" + userName + ". Today is" + date + ".";
            Console.WriteLine(strPlus);

            string strFormat = String.Format("Hello {0}. Today is {1}" ,userName, date);
            Console.WriteLine(strFormat);

            string strInterpolation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterpolation);
        
            string strConcat = String.Concat("Hello", userName , ". Today is", date, ".");
            Console.WriteLine(strConcat);

            string[] animal = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animal);
            Console.WriteLine(s);

            s = String.Join(",", animal);
            Console.WriteLine(s);
        }
    }
}

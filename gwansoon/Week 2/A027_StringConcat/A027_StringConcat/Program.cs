using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A027_StringConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "bikang";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "Hello " + userName + ", Today is " + date + ".";
            Console.WriteLine(strPlus); // Hello bikang, Today is 2024-05-14.

            string strFormat = String.Format("Hello {0}. Today is {1}.", userName, date);
            Console.WriteLine(strFormat);
            
            string strInterplation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterplation);

            string strConcat = String.Concat("Hello ", userName, ". Today is ", date, ".");
            Console.WriteLine(strConcat);

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animals); 
            Console.WriteLine(s); // mousecowtigerrabbitdragon
            s = String.Join(", ", animals);
            Console.WriteLine(s); // mouse, cow, tiger, rabbit, dragon

        }
    }
}

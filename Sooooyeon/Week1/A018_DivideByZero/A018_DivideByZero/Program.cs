﻿using System;

namespace A018_DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

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
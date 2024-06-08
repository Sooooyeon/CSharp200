using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A059_MultiDimensionArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2차원 배열: arrA[2,3]");
            int[,] arrA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0;i<2; i++)
            {
                for (int j = 0;j < 3; j++)
                    Console.Write("{0,5}", arrA[i,j]);
                Console.WriteLine();
            }

            Console.WriteLine("가변 배열: arrB[2][3]");
            int[][] arrB = new int[2][];
            arrB[0] = new int[] { 1, 2 };
            arrB[1] = new int[] { 3, 4, 5 };

            for(int i = 0; i<2; i++)
            {
                Console.Write("arrB[{0}]: ", i);
                for(int j = 0; j<arrB[i].Length;j++)
                {
                    Console.Write("{0} ", arrB[i][j]);
                }
                Console.WriteLine() ;
            }
        }
    }
}

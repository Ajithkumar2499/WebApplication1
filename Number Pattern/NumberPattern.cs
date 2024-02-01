using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Number_Pattern
{
    public class NumberPattern
    {
        public static void Main()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.Write("\n");
            }
            Console.Read();

            /*
            5 4 3 2 1
            5 4 3 2
            5 4 3
            5 4
            5
             */
 //-----------------------------------------------------------------------------
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
            /*
            5
            5 4
            5 4 3 
            5 4 3 2
            5 4 3 2 1
             */
//-----------------------------------------------------------------------------
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.Read();
            /*
                1
               12
              123
             1234
            12345
             */
//-----------------------------------------------------------------------------
            for (int x = 5; x >= 1; x--)
            {
                for (int y = 1; y < x; y++)
                {
                    Console.Write(" ");
                }
                for (int y = 5; y >= x; y--)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.Read();
            /*
                5
               54
              543
             5432
            54321
             */
        }
    }
}
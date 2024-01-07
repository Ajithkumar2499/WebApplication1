using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Star_Pyramid
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of rows : ");
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows -i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
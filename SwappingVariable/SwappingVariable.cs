using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwappingVariable
{
    public class SwappingVariable
    {
        public static void Main()
        {
            int a = 10;
            int b = 50;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.Read();
        }
    }
}
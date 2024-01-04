using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factorial
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the data : ");
            int input, result = 1;
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                result = result * i;
            }
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
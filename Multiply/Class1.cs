using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multiply
{
    public class Class1
    {
        //Multiply two numbers without using * operator
        public static void Main()
        {
            int num1 = 5;
            int num2 = 10;
            int result = 0;

            for (int i = 0; i < num2; i++)
            {
                result += num1;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
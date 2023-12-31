using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reverse_string
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the data : ");
            string input = Console.ReadLine();
            string result = string.Empty;
            for (int i = input.Length - 1; i > -1; i--)
            {
                result += input[i];
            }
            Console.Write($"Your reverse data is {result}");
            Console.ReadLine();
        }
    }
}
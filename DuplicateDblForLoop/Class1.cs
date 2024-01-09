using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuplicateDblForLoop
{
    public class Class1
    {
        static void Main(string[] args)  //Find the duplicate values using double for loop
        {
            int[] values = { 1, 2, 3, 1, 3, 5 };

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] == values[j])
                    {
                        Console.WriteLine(values[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
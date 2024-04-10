using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the data : ");
            int input, n1 = 0, n2 = 1, result;
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                result = n1 + n2;
                Console.Write(result + " ");
                n1 = n2;
                n2 = result;
            }
            Console.ReadLine();

            //int input1 = 5, result1, n10 = 0;  //output : 0 1 1 2 3

            //if (input != 0)
            //{
            //    Console.Write(n10 + " ");
            //}
            //if (input1 > 1)
            //{
            //    int n20 = 1;
            //    Console.Write(n2 + " ");
            //    for (int i = 2; i < input1; i++)
            //    {
            //        result1 = n10 + n20;
            //        Console.Write(result1 + " ");
            //        n10 = n20;
            //        n20 = result1;
            //    }
            //    Console.Read();
            //}
        }
    }
}

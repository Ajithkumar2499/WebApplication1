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
        }
    }
}

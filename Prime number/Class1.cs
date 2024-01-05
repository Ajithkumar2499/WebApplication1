using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prime_number
{
    public class Class1
    {
        static void Main(string[] args)  //prime number
        {
            Console.Write("Enter the number : ");
            int a = int.Parse(Console.ReadLine());
            int x = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    x++;
                }
            }
            if (x == 2)
            {
                Console.Write("Prime");
            }
            else
            {
                Console.Write("Not Prime");
            }
            Console.ReadLine();
        }
    }
}
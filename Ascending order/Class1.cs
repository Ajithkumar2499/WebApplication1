using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ascending_order
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int[] A = { 5, 9, 2, 10, 1, 4 };
            int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        result = A[i];
                        A[i] = A[j];
                        A[j] = result;
                    }
                }
            }
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
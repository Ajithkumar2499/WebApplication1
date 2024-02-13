using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoveDuplicate
{
    public class RemoveDuplicate
    {
        public static void Main()
        {
            int[] a = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 1, 4, 8, 9, 9 };
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.Read();
        }
    }
}
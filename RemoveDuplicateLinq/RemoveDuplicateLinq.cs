using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoveDuplicateLinq
{
    public class RemoveDuplicateLinq
    {
        public static void Main()
        {
            int[] a = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 1, 4, 8, 9, 9 };

            IEnumerable<int> unique = a.Distinct<int>();
            Console.Write(string.Join(" ", unique));
            Console.Read();
        }
    }
}
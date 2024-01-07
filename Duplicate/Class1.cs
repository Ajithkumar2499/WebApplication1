using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Duplicate
{
    public class Class1
    {
        static void Main(string[] args)  //Find the duplicate values using single for loop
        {
            int[] s = { 1, 3, 5, 1, 2, 3 };
            Array.Sort(s);
            List<int> duplicates = new List<int>();
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    duplicates.Add(s[i]);
                }
            }
            Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));
            Console.ReadLine();
        }
    }
}
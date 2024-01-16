using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuplicateLINQ
{
    public class Class1
    {
		public static void Main()
		{
			List<int> list = new List<int>() { 3, 5, 3, 2, 7, 7, 5, 6 };

			IEnumerable<int> duplicates = list.GroupBy(x => x)
			.Where(g => g.Count() > 1)
			.Select(x => x.Key);

			Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));
			Console.ReadLine();
		}
	}
}
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
			//List<int> list = new List<int>() { 3, 5, 3, 2, 7, 7, 5, 6 };

			//IEnumerable<int> duplicates = list.GroupBy(x => x)
			//.Where(g => g.Count() > 1)
			//.Select(x => x.Key);

			//var result = list.Skip(3).Take(4).ToList();

			//Console.WriteLine("Skip and Take: " + String.Join(",", result));

			//Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));
			//Console.ReadLine();

			//Duplicate with Count
			int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
			var duplicate = array.GroupBy(x => x)
			.Where(g => g.Count() > 1)
			.Select(y => new { Item = y.Key, Count = y.Count() })
			.ToList();
			Console.WriteLine(String.Join("\n", duplicate));
			Console.ReadLine();
		}
	}
}
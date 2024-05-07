using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveAndNegative
{
    class PositiveAndNegative
    {
        static void Main(string[] args)
        {
            string input = "-1, 5, 6, 2, 1, -5, -4, -3";
            List<int> Positive;
            List<int> Negative;
            separatePositiveandNegative(input, out Positive, out Negative);

            Console.WriteLine("Positive " + String.Join(",", Positive)));
            Console.WriteLine("Negative " + String.Join(",", Negative));
            Console.ReadLine();
        }
        static void separatePositiveandNegative(string input, out List<int> Positive, out List<int> Negative)
        {
            Positive = new List<int>();
            Negative = new List<int>();
            string[] numbers = input.Split(',');
            foreach (string number in numbers)
            {
                int num = int.Parse(number);
                if (num > 0)
                {
                    Positive.Add(num);
                }
                else if (num < 0)
                {
                    Negative.Add(num);
                }
            }
        }
    }
}


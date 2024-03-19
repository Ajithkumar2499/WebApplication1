using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharCount
{
    public class CharCount
    {
        public static void Main()
        {
            string str = "AEROPLANE LANDING";

            for(int i = 0; i < str.Length; i++)
            {
                int Count = 0;
                for(int j = 0; j < str.Length; j++)
                {
                    if(str[i] == str[j])
                    {
                        Count++;
                    }
                }
                Console.WriteLine($" {str[i]} is count {Count}");
            }
            Console.ReadLine();
        }
    }
}
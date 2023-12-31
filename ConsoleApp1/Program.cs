using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HelloWorld
    {
        static void Main()
        {

            Demo d1 = new Demo();
            d1.Print();
            d1.Print();
            Demo.a++; 
            Demo d2 = new Demo();
            d2.Print();
            Demo1 d3 = new Demo1();
            Console.ReadLine();
        }
    }

    public class Demo
    {
        public static int a = 100;
        public void Print()
        {
            a++;
            Console.WriteLine(a);
        }
    }

    class Demo1
    {
        public Demo1()
        {
            Demo d = new Demo();
            d.Print();
        }
    }
}

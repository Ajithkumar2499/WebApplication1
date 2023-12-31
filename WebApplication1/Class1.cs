using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Class1
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the data : ");
        //    string input = Console.ReadLine();
        //    string result = string.Empty;
        //    for (int i = input.Length -1; i > -1; i--)
        //    {
        //        result += input[i];
        //    }
        //    Console.Write($"Your reverse data is {result}");
        //    Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the data : ");
        //    int input, n1 = 0, n2 = 1, result;
        //    input = int.Parse(Console.ReadLine());
        //    for (int i = 1; i <= input; i++)
        //    {
        //        result = n1 + n2;
        //        Console.Write(result + " ");
        //        n1 = n2;
        //        n2 = result;
        //    }
        //    Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the data : ");
        //    int input, result = 1;
        //    input = int.Parse(Console.ReadLine());
        //    for (int i = 1; i <= input; i++)
        //    {
        //        result = result * i;
        //    }
        //    Console.Write(result);
        //    Console.ReadLine();
        //}
        /*class Vehicle  // base class (parent) 
        {
            public string brand = "Ford";  // Vehicle field
            public void honk()             // Vehicle method 
            {
                Console.WriteLine("Tuut, tuut!");
            }
        }

        class Car : Vehicle  // derived class (child)
        {
            public string modelName = "Mustang";  // Car field
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create a myCar object
                Car myCar = new Car();

                // Call the honk() method (From the Vehicle class) on the myCar object
                myCar.honk();

                // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
                Console.WriteLine(myCar.brand + " " + myCar.modelName);
                Console.ReadLine();
            }
        }*/
        /*class Animal  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }*/

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        ClassA myAnimal = new ClassB();  // Create a Animal object


        //        Console.WriteLine(myAnimal);
        //    }
        //    public class ClassA
        //    {
        //        return "yrty";
        //    }
        //    public class ClassB : ClassA
        //    {
        //        return "fgh";
        //    }
        //}

        class Program : System.Exception
        {
            //static void Main1(string[] args)
            //{
            //    //List<int> list = new List<int>() { 3, 5, 3, 2, 7, 7, 5, 6 };

            //    int[] array = { 3, 5, 3, 2, 7, 7, 5, 6 };

            //    IEnumerable<int> duplicates = array.GroupBy(x => x)
            //    .Where(g => g.Count() > 1)
            //    .Select(x => x.Key);

            //    Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));
            //    Console.ReadLine();
            //}

            //static void Main(string[] args)
            //{
            //    //int[] values = { 1, 2, 3, 1, 3, 5 };

            //    //for (int i = 0; i < values.Length; i++)
            //    //{
            //    //    for (int j = i + 1 ; j < values.Length; j++)
            //    //    {
            //    //        if (values[i] == values[j])
            //    //        {
            //    //            // here's your duplicate
            //    //            Console.WriteLine(values[i]);
            //    //        }
            //    //    }
            //    //}
            //    //Console.ReadLine();

            //    int[] arr = { 11, 2, 3, 6, 5 };

            //    int n = arr.Length;
            //    int smallest = 0;
            //    // traversing the array to find 
            //    // smallest element. 
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (arr[i] < smallest)
            //        {
            //            smallest = arr[i];
            //        }
            //    }
            //    int second_smallest = Int32.MaxValue;

            //    // traversing the array to find second smallest 
            //    // element 
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (arr[i] < second_smallest && arr[i] > smallest)
            //        {
            //            second_smallest = arr[i];
            //        }
            //    }
            //    Console.WriteLine("second smallest element is: " + second_smallest);

            //    Console.ReadLine();
            //}

            static void Main(string[] args)
            {
                //int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
                //int temp = 0;

                //for (int i = 0; i <= intArray.Length - 1; i++)
                //{
                //    for (int j = i + 1; j < intArray.Length; j++)
                //    {
                //        if (intArray[i] > intArray[j])
                //        {
                //            temp = intArray[i];
                //            intArray[i] = intArray[j];
                //            intArray[j] = temp;
                //        }
                //    }
                //}
                //Console.WriteLine("Array sort in asscending order");
                //foreach (var item in intArray)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.ReadLine();

                Console.Write("Input number of rows : ");
                int rows = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 0; j < rows - i; j++)
                        Console.Write(" ");
                    for (int j = 0; j < 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
                Console.ReadLine();
            }
        }
    }
}
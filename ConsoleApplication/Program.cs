using System;
using System.Net.NetworkInformation;
using System.Text;

namespace ConsoleApplication
{       
    internal class Program
    {
        class MyClass
        {
            public int GetMax(params int[] arr)
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (max < arr[i])
                        max = arr[i];
                }

                return max;
            }
            public string GetMax(params string[] arr)
            {
                int max = arr[0].Length; 
                int i1 = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (max < arr[i].Length)
                    {
                        max = arr[i].Length;
                        i1 = i;
                    }
                }

                return arr[i1];
            }
        }
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            int max = a.GetMax(1, 2, 3, 4, 5);
            Console.WriteLine($"max number is {max}");
            string max_string = a.GetMax("anime", "hello word!","naruto one love");
            Console.WriteLine($"the biggest word is {max_string}");

        }
    }
}
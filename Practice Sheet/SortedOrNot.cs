using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class SortedOrNot
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
            Console.WriteLine();
        }
        static void sorted(int[] arr)
        {
            int n = arr.Length;
            bool check = true;
            for (int i = 0; i < n-1; i++)
            {
                    if (arr[i] > arr[i + 1])
                    {
                        check = false;
                    }
            }
            if (check)
            {
                Console.WriteLine("sorted");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { -1, 0 };
            Console.WriteLine("Orignal Array:");
            printArray(arr);
            sorted(arr);
        }
    }
}

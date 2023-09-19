using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class SecondLargestInArray
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        static void secondLarge(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(arr[arr.Length-2]);
        }
        static void Main(string[] args)
        {
            int[] arr = {4,5,7,8,2,1};
            Console.WriteLine("Orignal Array");
            printArray(arr);
            Console.WriteLine("Sorted Array");
            secondLarge(arr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class SelectionSort
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i; 
                for(int j=i+1;j< arr.Length; j++)
                {
                    while(j>0 && arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
            printArray(arr);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 3, 2 };
            Console.Write("Orignal Array:");
            printArray(arr);
            Console.Write("Sorted Array:");
            sort(arr);
        }
    }
}

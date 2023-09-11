using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class SortOneZeroTwos
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static void sortZeroesOnesTwos(int[] arr)
        {
            int low = 0;
            int mid = 0;
            int high = arr.Length - 1;

            while (mid<=high)
            {
                if (arr[mid] == 0)
                {
                    swap(arr, low, mid);
                    low++;
                    mid++;
                }
                else if (arr[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    swap(arr, mid, high);
                    high--;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 0, 2, 1, 0, 2 };
            Console.WriteLine("Orignal Array:");
            printArray(arr);
            sortZeroesOnesTwos(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
            Console.ReadLine();
        }
    }
}

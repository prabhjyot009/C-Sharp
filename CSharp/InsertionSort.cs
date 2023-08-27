using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class InsertionSort
    {
        static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n ; i++)
            {
                int j = i;
                while(j>0 && arr[j] < arr[j-1])
                {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        j--;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {5,3,2,1,4};
            insertionSort(arr);
            Console.WriteLine("Using insertion sort:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

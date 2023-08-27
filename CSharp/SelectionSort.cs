using System;

namespace CSharp
{
    class SelectionSort
    {
        static void selectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                int min_index = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                }
                if (min_index != i)
                {
                    int temp = arr[min_index];
                    arr[min_index] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 2 };
            selectionSort(arr);
            Console.WriteLine("Using selection sort:");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}

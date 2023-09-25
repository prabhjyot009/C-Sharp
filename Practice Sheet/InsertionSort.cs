using System;

namespace Practice_Sheet
{
    class InsertionSort
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        static void sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j>0 && arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
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

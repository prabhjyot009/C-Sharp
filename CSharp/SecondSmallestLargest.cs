using System;

namespace CSharp
{
    class SecondSmallestLargest
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void KthSmallLargeArrayUsingLogic(int[] arr)
        {
            int temp = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j>0 && arr[j] < arr[j - 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }
            Console.WriteLine("Sorted Array:");
            printArray(arr);
            Console.WriteLine("Kth Smallest and Largest values using logic are:");
            Console.WriteLine(arr[2] + " " + arr[arr.Length - 3]);
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 8, 5, 9, 8, 0 };
            Console.WriteLine("Orignal Array:");
            printArray(arr);
            KthSmallLargeArrayUsingLogic(arr);
        }
    }
}

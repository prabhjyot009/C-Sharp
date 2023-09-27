using System;

namespace Practice_Sheet
{
    class SecondSmallestAndLargest
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        static void secondLargeSmall(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (global::System.Int32 j = i; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            printArray(arr);
            Console.WriteLine("Second smallest"+arr[1]+"\nSecond largest" + arr[arr.Length-2]);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements in an array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Given array: ");
            printArray(arr);
            secondLargeSmall(arr);
        }
    }
}

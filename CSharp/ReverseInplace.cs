using System;

namespace CSharp
{
    class ReverseInplace
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void swap(int[] arr,int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static void reverse(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                swap(arr, i, j);
                i++;
                j--;
            }
            printArray(arr);

        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Orignal Array");
            printArray(arr);
            Console.WriteLine("Reversed Array:");
            reverse(arr);
        }
    }
}

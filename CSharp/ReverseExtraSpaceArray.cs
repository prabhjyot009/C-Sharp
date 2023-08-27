using System;

namespace CSharp
{
    class ReverseExtraSpaceArray
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] ansArray(int[] arr)
        {
            int n = arr.Length;
            int[] ans = new int[n];
            int j = 0;
            int i = n - 1;
            while (i >= 0)
            {
                ans[j++] = arr[i];
                i--;
            }
            return ans;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Orignal Array");
            printArray(arr);
            int[] ans = ansArray(arr);
            Console.WriteLine("Reversed Array:");
            printArray(ans);
        }
    }
}
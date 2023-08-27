using System;

namespace CSharp
{
    class BubbleSort
    {
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                Boolean flag = false;
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 2, 4 };
            bubbleSort(arr);
            Console.WriteLine("Using bubble sort:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class ReverseArrayInplace
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void reverse(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i <= j)
            {
                swap(arr, i, j);
                i++;
                j--;
            }
            printArray(arr);
        }
        static void swap(int[] arr,int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements in an array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Given Array: ");
            printArray(arr);
            Console.Write("Reversed Array: ");
            reverse(arr);
        }
    }
}

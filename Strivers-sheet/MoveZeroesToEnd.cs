using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class MoveZeroesToEnd
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void moveZeros(int[] arr)
        {
            int left = 0;
            int right = 0;
            int n = arr.Length;
            while (right < n)
            {
                if (arr[right] != 0)
                {
                    swap(arr, left, right);
                    left++;
                }
                right++;
            }
            printArray(arr);
        }
        static void swap(int[] arr, int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 0, 4, 5 };
            Console.WriteLine("Orignal Array");
            printArray(arr);
            Console.WriteLine("New Array:");
            moveZeros(arr);
        }
    }
}

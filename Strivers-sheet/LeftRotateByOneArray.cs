using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class LeftRotateByOneArray
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void leftRotateOne(int[] arr)
        {
            int temp = arr[0];
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[n - 1] = temp;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Orignal Array");
            printArray(arr);
            Console.WriteLine("New Array:");
            leftRotateOne(arr);
        }
    }
}

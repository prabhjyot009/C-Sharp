using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class LeftRotateNarray
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void leftRotateN(int[] arr,int k)
        {
            int n = arr.Length;
            k = k % n;
            reversePart(arr, 0, n - 1);
            reversePart(arr, 0, k - 1);
            reversePart(arr, k , n-1);
            printArray(arr);
        }
        static void reversePart(int[] arr,int i,int j)
        {
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Orignal Array");
            printArray(arr);
            Console.WriteLine("New Array:");
            leftRotateN(arr,k);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class RemoveDuplicatesFromArray
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void removeDuplicates(int[] arr)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                int idx = Math.Abs(arr[i]);
                if (arr[idx] > 0)
                {
                    Console.Write(idx +" ");
                }
                arr[idx] =- arr[idx];
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 3, 4, 5 ,5};
            Console.WriteLine("Orignal Array");
            printArray(arr);
            Console.WriteLine("New Array:");
            removeDuplicates(arr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class SortedOrNot
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void sortedOrnot(int[] arr)
        {
            int n = arr.Length;
            bool check = false;
            for (int i =1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    check = true;
                }
            }
            if (check)
            {
                Console.WriteLine("Sorted");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
        static void Main(string[] args)
        {
                int[] arr = { 1,2,3,4,5};
                Console.WriteLine("Orignal Array");
                printArray(arr);
                sortedOrnot(arr);
        }
    }
}

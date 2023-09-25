using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class AverageOfArray
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Average(int[] arr)
        {
            int n = arr.Length;
            double sum = 0;
            foreach (int ele in arr)
            {
                sum += ele;
            }
            double average = sum / n;
            Console.WriteLine(average);
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
            Average(arr);
        }
    }
}

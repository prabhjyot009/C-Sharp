using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class uniqueElements
    {
    static void printArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
    }
    static void unique(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i+1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    arr[i] = -1;
                    arr[j] = -1;
                }
            }
        }
        int ans = -1;
        for (int i = 0; i < n; i++)
        {
            if (arr[i]!=-1)
            {
                ans = arr[i];
            }
        }
        Console.WriteLine(ans);
    }
    static void Main(string[] args)
    {
        int[] arr = { 2, 2, 1, 3, 3 };
        Console.WriteLine("Orignal Array:");
        printArray(arr);
        unique(arr);
    }
    }
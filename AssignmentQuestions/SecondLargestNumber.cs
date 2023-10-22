using System;

namespace AssignmentQuestions
{
    class SecondLargestNumber
    {
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        static void secondLarge(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("Second Largest Number is: " + arr[arr.Length-2]);
        }
        static void Main(string[] args)
        {
            int[] arr = { 2,3,4,5,1,9,8};
            printArray(arr);
            secondLarge(arr);
            Console.ReadLine();
        }   
    }
}

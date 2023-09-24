using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class DuplicatesInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 3, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                int idx = Math.Abs(arr[i]);
                if (arr[idx] < 0)
                {
                    Console.Write(idx + " ");
                }
                else
                {
                    arr[idx] = -arr[idx];
                }
            }
        }
    }
}

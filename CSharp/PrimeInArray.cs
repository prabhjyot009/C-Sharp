using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class PrimeInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5,7 };
            int j;
            foreach (int i in arr)
            {
                for ( j = 2; j < arr[i]; j++)
                {
                    if (arr[i]%j==0)
                    {
                        Console.WriteLine(i + "is not prime");
                        Console.ReadLine();
                        break;
                    }
                    if (j == arr[i])
                    {
                        Console.WriteLine(i + " is prime");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}

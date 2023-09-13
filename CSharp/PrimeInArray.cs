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
            int count = 0;
            for (int i = 0; i < arr.Length; i++)          
            {
                Boolean isprime = true;
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i]%j==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.Write(arr[i]+" ");
                    Console.WriteLine();
                    count += 1;                  
                }
            }
            Console.WriteLine("Number of primes in array");
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
